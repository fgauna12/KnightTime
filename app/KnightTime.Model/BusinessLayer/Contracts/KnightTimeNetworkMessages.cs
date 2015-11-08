#define BLUESMIRF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnightTime.Core.BusinessLayer.Contracts
{
    public enum MessageId
    {                                       //#, Description
        
        /* Wrist Peripheral Messages */
        MovementRequest =0,                //0, 
        MovementReply,                     //1,
        VibratorCommand,                   //2, 

        /* Mask Peripheral Messages */
        TemperatureRequest,                //3, 
        TemperatureReply,                  //4, 
        HeartRateRequest,                  //5, 
        HeartRateReply,                    //6, 
        EegRequest,                        //7,
        EegReply,                          //8,
        BuzzerCommand,                     //9,
        LightArrayCommand,                 //10, 

        /* Base Station Messages */
        AmbientTemperatureRequest,        //11, 
        AmbientTemperatureReply,          //12, 
        AmbientNoiseRequest,              //13, 
        AmbientNoiseReply,                //14, 
        AmbientLightRequest,              //15, 
        AmbientLightReply,                //16, 
        AmbientHumidityRequest,           //17, 
        AmbientHumidityReply,             //18, 

        Undefined
    }

    public enum OnOffCommand
    {
        OFF =0,
        ON
    }

    public static class MovementGlobalVariables
    {

        public static int previous_acc_x;
        public static int previous_acc_y;
        public static int previous_acc_z;

        public static int previous_gyr_x;
        public static int previous_gyr_y;
        public static int previous_gyr_z;

        public static bool notFirstTime_acc;
        public static bool notFirstTime_gyr;
    }

    /*
     * Wrist Peripheral
     */
    #region Wrist Messages
    public struct MovementReplyMessage : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.MovementReply;

        public byte[] RawData { get; set; }

        /// <summary>
        /// Return an object with the accelerations on the X, Y, Z axis.
        /// </summary>
        /// <returns>The acceleration coordinates</returns>
        public Tuple<int, int, int> GetAccelerations()
        {
            var x = BitConverter.ToInt16(RawData, 1);
            var y = BitConverter.ToInt16(RawData, 3);
            var z = BitConverter.ToInt16(RawData, 5);
            return (new Tuple<int, int, int>(x, y, z));
        }

        /// <summary>
        /// Return an object with the gyroscope on the X, Y, Z axis.        
        /// </summary>
        /// <returns>The gyroscope coordinates</returns>
        public Tuple<int, int, int> GetGyroscope()
        {
            var x = BitConverter.ToInt16(RawData, 7);
            var y = BitConverter.ToInt16(RawData, 9);
            var z = BitConverter.ToInt16(RawData, 11);
            return (new Tuple<int, int, int>(x, y, z));
        }

        public static void Initialize()
        {
            MovementGlobalVariables.notFirstTime_acc = false;
            MovementGlobalVariables.notFirstTime_gyr = false;
            MovementGlobalVariables.previous_acc_x = 0;
            MovementGlobalVariables.previous_acc_y = 0;
            MovementGlobalVariables.previous_acc_z = 0;
            MovementGlobalVariables.previous_gyr_x = 0;
            MovementGlobalVariables.previous_gyr_y = 0;
            MovementGlobalVariables.previous_gyr_z = 0;
        }

        /// <summary>
        /// Returns the magnitude of the jerk (derivative of the acceleration)
        /// </summary>
        /// <param name="x">The current x-acceleration</param>
        /// <param name="y">The current y-acceleration</param>
        /// <param name="z">The current z-acceleration</param>
        /// <returns></returns>
        public static double GetAccJerkMagnitude(int x, int y, int z)
        {
            //If this is the first time the method is called, then return 0 since there is no change yet.
            if (!MovementGlobalVariables.notFirstTime_acc)
            {
                MovementGlobalVariables.notFirstTime_acc = true;
                MovementGlobalVariables.previous_acc_x = x;
                MovementGlobalVariables.previous_acc_y = y;
                MovementGlobalVariables.previous_acc_z = z;
                return 0;
            }

            var delta_x = x - MovementGlobalVariables.previous_acc_x;
            var delta_y = y - MovementGlobalVariables.previous_acc_y;
            var delta_z = z - MovementGlobalVariables.previous_acc_z;

            MovementGlobalVariables.previous_acc_x = x;
            MovementGlobalVariables.previous_acc_y = y;
            MovementGlobalVariables.previous_acc_z = z;

            var resultVector = (Math.Pow(delta_x, 2.0) + Math.Pow(delta_y, 2.0) + Math.Pow(delta_z, 2.0));
            if (resultVector < 0)
                return 0;
            return Math.Sqrt(resultVector);
        }

        /// <summary>
        /// Returns the magnitude of the gyro derivative
        /// </summary>
        /// <param name="x">The current x-gyro</param>
        /// <param name="y">The current y-gyro</param>
        /// <param name="z">The current z-gyro</param>
        /// <returns></returns>
        public static double GetGyroMagnitude(int x, int y, int z)
        {
            if (!MovementGlobalVariables.notFirstTime_gyr)
            {
                MovementGlobalVariables.notFirstTime_gyr = true;
                return 0;
            }

            var delta_x = x - MovementGlobalVariables.previous_gyr_x;
            var delta_y = y - MovementGlobalVariables.previous_gyr_y;
            var delta_z = z - MovementGlobalVariables.previous_gyr_z;

            return Math.Sqrt((delta_x * delta_x) + (delta_y * delta_y) + (delta_z * delta_z));
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    #endregion 
    /*
     * Mask Peripheral
     */
    #region Mask Messages
    public struct TemperatureReplyMessage : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.TemperatureReply;

        public byte[] RawData { get; set; }

        public double ConvertRawData() 
        {
            //Convert Raw sensor data to Celcius
            var rawBytes = BitConverter.ToUInt16(RawData, 1);
            var tempTemp= (rawBytes / 50) - 273;
            return ((1.8) * tempTemp + 32);
        }


        public new MessageId GetType()
        {
            return Type;
        }
    }
    public struct HeartRateReplyMessage : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.HeartRateReply;

        public byte[] RawData { get; set; }

        /// <summary>
        /// If the BPM is more than 200 then it's going to return a BPM of -1
        /// </summary>
        /// <returns></returns>
        public ushort ConvertRawData()
        {
            ushort ret = BitConverter.ToUInt16(RawData, 1);
            return ret = (ret > 250 || ret < 40) ? (ushort)0 : ret;
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }

    public struct EegReplyMessage : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.EegReply;

        public byte[] RawData  { get; set;}

        public T ConvertRawData<T>()
        {
            throw new NotImplementedException();
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    #endregion 
    /* 
    * Base Station
    */
    #region Base Station Messages
    public struct AmbientTemperatureReply : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.AmbientTemperatureReply;

        public byte[] RawData { get; set; }

        public double ConvertRawData()
        {
            var data = BitConverter.ToUInt16(RawData, 1);
            return ((((double)data) / 10.0) * (9.0/5.0)) + 32.0;
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    public struct AmbientHumidityReply : IKnightTimeMessage
    {
        public const MessageId Type = MessageId.AmbientHumidityReply;

        public byte[] RawData { get; set; }

        public double ConvertRawData()
        {
            var data = BitConverter.ToUInt16(RawData, 1);
            return (((double)data) / 10.0);
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    public struct AmbientNoiseReply: IKnightTimeMessage
    {
        public const MessageId Type = MessageId.AmbientNoiseReply;

        public byte[] RawData { get; set; }

        public int ConvertRawData()
        {
            return BitConverter.ToUInt16(RawData, 1);
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    public struct AmbientLightReply: IKnightTimeMessage
    {
        public const MessageId Type = MessageId.AmbientLightReply;

        public byte[] RawData { get; set; }

        public int ConvertRawData()
        {
            return BitConverter.ToUInt16(RawData, 1);
        }

        public new MessageId GetType()
        {
            return Type;
        }
    }
    #endregion
   
}