using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace GoodKnight
{
    public class BluetoothConnectedThread : Thread
    {
        private readonly BluetoothSocket _socket;
        private readonly Stream _inputStream;
        private readonly Stream _outputStream;

        public BluetoothConnectedThread(BluetoothSocket socket)
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
            catch (IOException) { }

            _inputStream = tmpIn;
            _outputStream = tmpOut;
        }

        public void Run()
        {
            byte[] buffer = new byte[1024];  // buffer store for the stream
            int bytes; // bytes returned from read()

            // Keep listening to the InputStream until an exception occurs
            while (true)
            {
                try
                {
                    // Read from the InputStream
                    bytes = _inputStream.Read(buffer, 0, buffer.Length);
                    // Send the obtained bytes to the UI activity
                    // TODO: Be awesome and send a message to the UI.
                    //mHandler.obtainMessage(MESSAGE_READ, bytes, -1, buffer)
                    //        .sendToTarget();
                }
                catch (IOException)
                {
                    break;
                }
            }
        }

        /* Call this from the main activity to send data to the remote device */
        public void Write(byte[] bytes)
        {
            try
            {
                _outputStream.Write(bytes, 0, bytes.Length);
            }
            catch (IOException) { }
        }

        /* Call this from the main activity to shutdown the connection */
        public void Cancel()
        {
            try
            {
                _socket.Close();
            }
            catch (IOException) { }
        }
    }
}