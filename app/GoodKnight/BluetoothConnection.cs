using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using KnightTime.Core.BusinessLayer;
using KnightTime.Core.BusinessLayer.Contracts;
using Thread = System.Threading.Thread;

namespace KnightTime.Android.View
{
    public class BluetoothConnection
    {
        private readonly BluetoothSocket _socket;
        private readonly Stream _inputStream;
        private readonly Stream _outputStream;

        private ConcurrentQueue<byte> _receiverBuffer { get; set; }

        private readonly Thread _receivingThread = null;

        public BluetoothConnection(BluetoothSocket socket)
        {
            _socket = socket;
            _inputStream = null;
            _outputStream = null;

            Stream tmpIn = null;
            Stream tmpOut = null;

            // Get the input and output streams, using temp objects because
            // member streams are final
            try
            {
                tmpIn = socket.InputStream;
                tmpOut = socket.OutputStream;
            }
            catch (IOException)
            {
            }

            _receiverBuffer = new ConcurrentQueue<byte>();

            _inputStream = tmpIn;
            _outputStream = tmpOut;
        }

        public byte[] WaitForNextMessage(int byteSize, byte messageHeader)
        {
            List<byte[]> bufferList = new List<byte[]>(byteSize);
            byte[] buffer = new byte[1];  // buffer store for the stream
            int bytes; // bytes returned from read()
            int counter = 0;

            try
            {
                for (int i = 0; i < byteSize; i ++)
                {
                    bufferList.Add(new byte[1]);
                }

                    // Read from the InputStream
                    foreach (var bytese in bufferList)
                    {
                        bytes = _inputStream.Read(bytese, 0, 1);
                    }

                if (bufferList.First()[0] == messageHeader)
                {
                    byte[] returnList = new byte[byteSize];
                    for (int i = 0; i < returnList.Length; i++)
                    {
                        returnList[i] = bufferList[i][0];
                    }
                    return returnList;
                }
                else return WaitForNextMessage(byteSize, messageHeader);
            }
            catch (IOException)
            {
                
                return null;
            }
            return null;
        }

        /* Call this from the main activity to send data to the remote device */
        public void Write(byte[] bytes)
        {
            try
            {
                _outputStream.Write(bytes, 0, bytes.Length);
            }
            catch (Java.IO.IOException)
            {
            }
            catch (IOException)
            {
            }
        }

        /* Call this from the main activity to shutdown the connection */
        public void Cancel()
        {
            try
            {
                _socket.Close();
            }
            catch (Java.IO.IOException)
            {
            }
            catch (IOException)
            {
            }
        }

        //private void UpdateKnightTimeService(Intent intent, KtService service)
        //{
        //    // Send the obtained bytes to the UI activity
        //    // TODO: Be awesome and send a message to the UI.
        //    service.SendBroadcast(intent);
        //}

        /* 
         * -----------------------------------
         *          KnightTime Logic 
         * -----------------------------------
         */

        /// <summary>
        /// Uses the Receive Buffer to obtain the latest KnightTime message from the queue.
        /// Returns null if the data bytes are not in yet.
        /// </summary>
        /// <returns>The adquired messsage byte array.</returns>
        private byte[] GetRawPeripheralData()
        {
            byte messageHeaderByte;
            if (_receiverBuffer.TryDequeue(out messageHeaderByte))
            {
                int dataByteCount = SensorDataUtility.GetDataByteCountFromByteHeader(messageHeaderByte);
                //If we're able to identify the message header.
                if (dataByteCount != -1)
                {
                    //Make sure that the Receive Buffer has the data bits in there.
                    if (_receiverBuffer.Count < dataByteCount) return null;

                    byte[] messageBytes = new byte[dataByteCount + 1];
                    messageBytes[0] = messageHeaderByte;

                    for (int i = 1; i < dataByteCount; i ++)
                    {
                        if (!_receiverBuffer.TryDequeue(out messageBytes[i]))
                        {
                            //If Dequeuing was unsuccessful, then we're in trouble.
                            throw new Java.Lang.Exception("The Receive Buffer does not contain the necessary amount of data bytes for the KnightTime message.");
                        }
                    }
                    //Return the newly adquired message as a byte array.
                    return messageBytes;
                }
            }
            throw new Java.Lang.Exception("The Receive Buffer does not contain the necessary amount of data bytes for the KnightTime message.");
        }

        /// <summary>
        /// Generates the intent that will be broadcasted by KTService based on the KnightTime message type.
        /// This intent informs to everyone that is receiving what kind of data was received.
        /// </summary>
        /// <param name="messageType">The KnightTime message type.</param>
        /// <param name="messageBytes">The message as a byte array.</param>
        /// <returns>The intent to send. Returns null if message was not recognized.</returns>
        private Intent GenerateMessageIntent(MessageId messageType, byte[] messageBytes)
        {
            Intent messageReceivedIntent = null;
            switch (messageType)
            {
                case MessageId.MovementReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.MotionReceived, messageBytes);
                    }
                    break;
                case MessageId.HeartRateReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.HeartRateReceived, messageBytes);
                    }
                    break;
                case MessageId.TemperatureReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.SkinTemperatureReceived, messageBytes);
                    }
                    break;
                case MessageId.AmbientLightReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.AmbientLightReceived, messageBytes);
                    }
                    break;
                case MessageId.AmbientNoiseReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.AmbientNoiseReceived, messageBytes);
                    }
                    break;
                case MessageId.AmbientTemperatureReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.AmbientTempReceived, messageBytes);
                    }
                    break;
                case MessageId.AmbientHumidityReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.AmbientHumidityReceived, messageBytes);
                    }
                    break;
                case MessageId.EegReply:
                    {
                        messageReceivedIntent = new Intent();
                        //Pass the bytes and the type of message that was received
                        messageReceivedIntent.PutExtra(KtService.EegReceived, messageBytes);
                    }
                    break;
            }
            return messageReceivedIntent;
        }
    }
}