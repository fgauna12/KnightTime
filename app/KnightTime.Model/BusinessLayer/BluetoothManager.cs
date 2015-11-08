#define BLUESMIRF

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
using Java.IO;
using Java.Util;

namespace GoodKnight
{
    [Service]
    [IntentFilter(new string[] { "BluetoothManager"})]
    public class BluetoothManager : Service
    {
        // Unique UUID for this application
        private static UUID MY_UUID_SECURE = UUID.FromString("fa87c0d0-afac-11de-8a39-0800200c9a66");
        private static UUID MY_UUID_INSECURE = UUID.FromString("8ce255c0-200a-11e0-ac64-0800200c9a66");
        private static UUID SERIAL_PORT = UUID.FromString("00001101-0000-1000-8000-00805f9b34fb");


        //Green Modules from China CSRs from ebay
#if (!BLUESMIRF)
        private static string PERIPHERAL_1 = "00:12:03:26:51:69";
        private static string PERIPHERAL_2 = "00:12:03:26:54:25";
#endif
#if (BLUESMIRF)
        private static string PERIPHERAL_1 = "00:06:66:49:54:54";
        private static string PERIPHERAL_2 = "00:06:66:49:4B:C7";
#endif

        private static BluetoothManager _instance = null;
        private static BluetoothSocket _socket = null;
        private static InputStream _inputStream = null;
        private static OutputStream _outputStream = null;

        private static BluetoothDevice _baseStation = null;
        public static BluetoothDevice BaseStation
        {
            get { return _baseStation; }
        }

        private static List<BluetoothDevice> _devicesDiscovered;
        public static List<BluetoothDevice> DevicesDiscovered
        {
            private set { _devicesDiscovered = value;  }
            get { return _devicesDiscovered; }
        }        

        public static event EventHandler<DevicesDiscoveredChangedEventArgs> DevicesDiscoveredChangedEvent;

        private static  BluetoothConnectedThread _connectionThreadPeripheral2;
        private static  BluetoothConnectedThread _connectionThreadPeripheral1;

        /// <summary>
        /// Create an instance of the object. (singleton)
        /// </summary>
        /// <param name="baseStation"></param>
        /// <returns></returns>
        public static BluetoothManager Create(BluetoothDevice baseStation)
        {
            if (_instance == null)
            {
                DevicesDiscovered = new List<BluetoothDevice>();
                _instance = new BluetoothManager();
            }
            return _instance;        
        }

        public static void OnDevicesDiscoveredChanged()
        {
            var handler = DevicesDiscoveredChangedEvent;
            if (handler != null)
            {
                handler(null, new DevicesDiscoveredChangedEventArgs(BluetoothManager.GetDeviceNames()));
            }
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            _baseStation = null;
            _instance = null;
            _devicesDiscovered.Clear();
            _connectionThreadPeripheral2.Cancel();
            _connectionThreadPeripheral1.Cancel();
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void UnbindService(IServiceConnection conn)
        {
            _baseStation = null;
            _instance = null;
            _devicesDiscovered.Clear();
            base.UnbindService(conn);
        }
        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }

        public static string[] GetDeviceNames()
        {
            string[] bluetoothDevices = null;
            if (BluetoothManager.DevicesDiscovered != null)
            {
                bluetoothDevices = new string[BluetoothManager.DevicesDiscovered.Count];
                for (int i = 0; i < bluetoothDevices.Length; i++)
                {
                    bluetoothDevices[i] = BluetoothManager.DevicesDiscovered.ElementAt(i).Name;
                }
            }
            return bluetoothDevices;
        }

        public static bool ConnectViaMacPeripheral2()
        {
            var bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
            var device = bluetoothAdapter.GetRemoteDevice(PERIPHERAL_2);
            var socket = device.CreateInsecureRfcommSocketToServiceRecord(SERIAL_PORT);

            if (bluetoothAdapter.IsDiscovering)
            {
                bluetoothAdapter.CancelDiscovery();
            }
            try
            {
                if (!socket.IsConnected)
                {
                    socket.Connect();
                }
                _connectionThreadPeripheral2 = new BluetoothConnectedThread(socket);
                _connectionThreadPeripheral2.Start();
                _connectionThreadPeripheral2.Write(Encoding.ASCII.GetBytes("H"));
                _connectionThreadPeripheral2.Run();
                return true;
            }
            catch (System.IO.IOException)
            {
                try
                {
                    socket.Close();
                    return false;
                }
                catch (System.IO.IOException)
                {
                    return false;
                }
            }
        }


        internal static bool ConnectViaMacPeripheral1()
        {
            var bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
            var device = bluetoothAdapter.GetRemoteDevice(PERIPHERAL_1);
            var socket = device.CreateInsecureRfcommSocketToServiceRecord(SERIAL_PORT);

            if (bluetoothAdapter.IsDiscovering)
            {
                bluetoothAdapter.CancelDiscovery();
            }
            try
            {
                if (!socket.IsConnected)
                {
                    socket.Connect();
                }
                //BluetoothConnectedThread thread = new BluetoothConnectedThread(socket);
                //thread.Start();
                //thread.Write(Encoding.ASCII.GetBytes("H"));
                //thread.Run();
                return true;
            }
            catch (System.IO.IOException)
            {
                try
                {
                    socket.Close();
                    return false;
                }
                catch (System.IO.IOException)
                {
                    return false;
                }
            }
        }
    }
    public class DevicesDiscoveredChangedEventArgs : EventArgs
    {
        public string[] devicesDiscovered;
        public string[] DevicesDiscovered
        {
            get { return devicesDiscovered; }
        }

        public DevicesDiscoveredChangedEventArgs(string[] devicesDiscovered) : base()
        {
            this.devicesDiscovered = devicesDiscovered;
        }
    }
    
}