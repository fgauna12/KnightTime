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
        TemperatureRequest,            //3, 
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

    /// <summary>
    /// Base class for the KnightTime messages delivered through the network.
    /// </summary>
    public abstract class KnightTimeNetworkMessages : IKnightTimeMessage
    {
        public static byte MessageByteSize = 5;

        public MessageId Id { get; set; }

        public string Header { set; get; }
        public virtual string MAC { set; get; }

        public string Destination { set; get; }
        public string Origin { set; get; }

        public KnightTimeNetworkMessages(string header, string mac, string destination, string origin)
        {
            Header = header;
            MAC = mac;
            Destination = destination;
            Origin = origin;
        }

        public virtual bool SendMessage()
        {
            //TODO
            throw new NotImplementedException();
        }

        public abstract byte[] ToByteArray();

        public abstract string GetDataAsString();
    }

    public abstract class RequestMessage : KnightTimeNetworkMessages
    {
        public RequestMessage(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
        }

        public virtual bool SendMessage(string destination)
        {
            //TODO
            throw new NotImplementedException();
        }

        public override byte[] ToByteArray()
        {
            byte[] array = new byte[5];

            array[0] = (byte)Id;
            return array;
        }

        public override string GetDataAsString()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class ReplyMessage : KnightTimeNetworkMessages
    {
        public string Data { protected set; get; }

        public ReplyMessage(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
        }

        public override byte[] ToByteArray()
        {
            byte[] array = new byte[MessageByteSize];
            array[0] = (byte)Id;
            var dataInBytes = Encoding.ASCII.GetBytes(Data);

            for (int i = 1, j = 0; i < MessageByteSize && j < dataInBytes.Length; i++, j++)
            {
                array[i] = dataInBytes[j];
            }
            return array;
        }

        public override string GetDataAsString()
        {
            return Data.ToString();
        }
    }

    //TODO: what is the command message going to entail.
    public abstract class CommandMessage : KnightTimeNetworkMessages
    {
        public CommandMessage(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {

        }

        public string Command { get; protected set; }

        public override byte[] ToByteArray()
        {
            byte[] array = new byte[MessageByteSize];

            array[0] = (byte)Id;

            var commandInChars = Command.ToCharArray();
            for (int i = 1, j = 0; i < MessageByteSize && j < commandInChars.Length; i++, j++)
            {
                array[i] = (byte)commandInChars[j];
            }
            return array;
        }
    }

    /* Mask Peripheral */
    #region Message 1: Temperature Request Message

    public class Temperature_Request_Message : RequestMessage
    {
        public Temperature_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO: Add more stuff for constructor here
            this.Id = MessageId.TemperatureRequest;
        }
    }
    #endregion

    #region Message 2: Temperature Reply Message

    public class Temperature_Reply_Message : ReplyMessage
    {
        public double Temperature_Celcius
        {
            get
            {
                //TODO: Convert data
                return Data * 1.0;
            }
        }

        public double Temperature_Fahrenheit
        {
            get
            {
                return Temperature_Celcius * 1; //TODO
            }
        }

        public double Data { private set; get; }

        public Temperature_Reply_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.TemperatureReply;
        }
    }
    #endregion

    #region Message 3: HeartRate_Request_Message 

    public class HeartRate_Request_Message : RequestMessage
    {
        public HeartRate_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            this.Id = MessageId.HeartRateRequest;
        }
    }
    #endregion 

    #region Message 4: HeartRate_Reply_Message

    public class HeartRate_Reply_Message : ReplyMessage
    {
        public HeartRate_Reply_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            this.Id = MessageId.HeartRateReply;
        }
    }
    #endregion

    #region Message 5: LightArray_Command_Message

    public class LightArray_Command_Message : CommandMessage
    {
        public LightArray_Command_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO

        }

        public override string GetDataAsString()
        {
            throw new NotImplementedException();
        }

        public override byte[] ToByteArray()
        {
            return base.ToByteArray();
        }
    }

    #endregion

    /* Wrist Peripheral Messages */
    #region Message 6: Movement_Request_Message

    public class Movement_Request_Message : RequestMessage
    {
        public Movement_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.MovementRequest;
        }
        public override byte[] ToByteArray()
        {
            byte id = (byte)this.Id;
            byte[] bytes = new byte[] { id };
            return bytes;
        }
    }
    #endregion

    #region Message 7: Movement_Reply_Messsage

    public class Movement_Reply_Messsage : ReplyMessage
    {
        public Movement_Reply_Messsage(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.MovementReply;
        }
    }

    #endregion

    #region Message 8: Vibrator_Command_Message
    public class Vibrator_Command_Message : CommandMessage
    {
        public Vibrator_Command_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.VibratorCommand;
        }

        public override string GetDataAsString()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    /* Base Station */
    #region Message 9: Ambient_Temperature_Request_Message
    public class Ambient_Temperature_Request_Message : RequestMessage
    {
        public Ambient_Temperature_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientTemperatureRequest;
        }
    }
    #endregion

    #region Message 10: Ambient_Temperature_Reply_Message
    public class Ambient_Temperature_Reply_Message : ReplyMessage
    {
        public Ambient_Temperature_Reply_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientTemperatureReply;
        }
    }
    #endregion

    #region Message 11: Ambient_Noise_Request_Message
    public class Ambient_Noise_Request_Message : RequestMessage
    {
        public Ambient_Noise_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientNoiseRequest;
        }
    }
    #endregion

    #region Message 12: Ambient_Noise_Reply_Message
    public class Ambient_Noise_Reply_Message : ReplyMessage
    {
        public Ambient_Noise_Reply_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientNoiseReply;
        }
    }
    #endregion

    #region Message 13: Ambient_Light_Request_Message
    public class Ambient_Light_Request_Message : RequestMessage
    {
        public Ambient_Light_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientLightRequest;
        }
    }
    #endregion

    #region Message 14: Ambient_Light_Reply_Message
    public class Ambient_Light_Reply_Message : ReplyMessage
    {
        public Ambient_Light_Reply_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientLightReply;
        }
    }
    #endregion

    #region Message 15: Ambient_Humidity_Request_Message
    public class Ambient_Humidity_Request_Message : RequestMessage
    {
        public Ambient_Humidity_Request_Message(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientHumidityRequest;
        }
    }
    #endregion

    #region Message 16: Ambient_Humidity_Reply
    public class Ambient_Humidity_Reply : ReplyMessage
    {
        public Ambient_Humidity_Reply(string header, string mac, string destination, string origin)
            : base(header, mac, destination, origin)
        {
            //TODO
            this.Id = MessageId.AmbientHumidityReply;
        }
    }
    #endregion

}