using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnightTime.Core.BusinessLayer.Contracts;

namespace KnightTime.Core.BusinessLayer
{
    public static class SensorDataUtility
    {
        public struct Temperature
        {
            public int Celcius { get; set; }
        }

        public struct Motion
        {
            public struct Acceleration
            {
                public int X { get; set; }
                public int Y { get; set; }
                public int Z { get; set; }
            }

            public Acceleration Acc { get; set; }
        }

        public struct HeartRate
        {
            public int Bpm { get; set; }
        }

        public struct Eeg
        {
            //TODO: Implement eeg data 
            public double Data;
        }

        public static Temperature BytesToTemperature(byte[] array)
        {
            Temperature temp = new Temperature();
            temp.Celcius = (BitConverter.ToInt16(array, 0));
            return temp;
        }

        public static Motion BytesToMotion(byte[] array)
        {
            Motion motion = new Motion();
            Motion.Acceleration acc = new Motion.Acceleration();
            acc.X = BitConverter.ToInt16(array, 0);
            acc.Y = BitConverter.ToInt16(array, 2);
            acc.Z = BitConverter.ToInt16(array, 4);
            motion.Acc = acc;
            return motion;
        }

        public static HeartRate BytesToHeartRate(byte[] array)
        {
            HeartRate heartRate = new HeartRate();
            heartRate.Bpm = BitConverter.ToInt16(array, 0);
            return heartRate;
        }

        public static Eeg BytesToEeg(byte[] array)
        {
            Eeg eeg = new Eeg();
            eeg.Data = BitConverter.ToSingle(array, 0);
            return eeg;
        }


        /// <summary>
        /// Gets the count of data bytes that follows the message header in a receive buffer.
        /// If it can't identify the header, then it returns -1;
        /// </summary>
        /// <param name="header">The byte corresponding to the message header. Usually the first byte in a buffer.</param>
        /// <returns>The count of data bytes that follows the header.</returns>
        public static int GetDataByteCountFromByteHeader(byte header)
        {
            switch ((MessageId)header)
            {
                //Ax, Ay, Az => Each is 2 bytes
                case MessageId.MovementReply:
                    return 14;
                case MessageId.HeartRateReply:
                    return 2;
                case MessageId.TemperatureReply:
                    return 2;
                case MessageId.AmbientLightReply:
                    return 2;
                case MessageId.AmbientNoiseReply:
                    return 2;
                case MessageId.AmbientTemperatureReply:
                    return 2;
                case MessageId.AmbientHumidityReply:
                    return 2;
                case MessageId.EegReply:
                    return 4;
                default: return -1;
            }
        }
        /// <summary>
        /// Gets the count of data bytes that follows the message header in a receive buffer.
        /// If it can't identify the header, then it returns -1;
        /// </summary>
        /// <param name="header">The byte corresponding to the message header. Usually the first byte in a buffer.</param>
        /// <returns>The count of data bytes that follows the header.</returns>
        public static MessageId GetMessageTypeFromByteHeader(byte header)
        {
            switch ((MessageId)header)
            {
                //Ax, Ay, Az => Each is 2 bytes
                case MessageId.MovementReply:
                    return MessageId.MovementReply;
                case MessageId.HeartRateReply:
                    return MessageId.HeartRateReply;
                case MessageId.TemperatureReply:
                    return MessageId.TemperatureReply;
                case MessageId.AmbientLightReply:
                    return MessageId.AmbientLightReply;
                case MessageId.AmbientNoiseReply:
                    return MessageId.AmbientNoiseReply;
                case MessageId.AmbientTemperatureReply:
                    return MessageId.AmbientTemperatureReply;
                case MessageId.AmbientHumidityReply:
                    return MessageId.AmbientHumidityReply;
                case MessageId.EegReply:
                    return MessageId.EegReply;
                default: return MessageId.Undefined;
            }
        }
    }
}
