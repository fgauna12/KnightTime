#define BLUESMIRF

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Lang;
using Java.Util;
using KnightTime.Core.BusinessLayer;
using KnightTime.Core.BusinessLayer.Contracts;
using System.Threading;
using KnightTime.Core.DataAccessLayer;
using Thread = System.Threading.Thread;

using KnightTime.Core.BusinessLayer.Contracts;

namespace KnightTime.Android.View
{
    [Service]
    //[IntentFilter(new string[] { "com.knighttime.knighttimeservice" })]
    public class KtService : Service, IMonitorLoop
    {
        // Unique UUID for this application
        private static readonly UUID SerialPortUUID = UUID.FromString("00001101-0000-1000-8000-00805f9b34fb");

        public const int DEVICE_COUNT = 3;

        public const int WRIST_PERIPHERAL_ID = 0;
        public const int MASK_PERIPHERAL_ID = 0;
        public const int BASE_STATION_ID = 0;
        
        /*
         * KnightTime monitor settings that the service cares about
         */
        public  DateTime FailSafeTime { private set; get; }
        private DateTime MonitorQueue { set; get; }
        public  MonitorPreferences.ModeType CurrentMode { private set; get; }
        public  MonitorPreferences.Switch Vibrate { private set; get; }
        public  MonitorPreferences.Switch Buzzer { private set; get; }
        public  bool IsTestMode { private set; get; }

        /// <summary>
        /// The name of the data pertaining to the mode. (The new of the mode intent to create)
        /// </summary>
        public const string KnightTimeModeExtraName = "Mode";
        /* Modes of the monitor algorithm */
        public const string WakeWithSunglightMode = "Com.KnightTime.WakeWithSunlightMode";
        public const string WakeByRem = "Com.KnightTime.WakeByRem";
        public const string NapMode = "Com.KnightTime.NapMode";

        /* Names of Intents to be used by the Connection Threads */
        public const string MotionReceived = "Com.KnightTime.MotionReceived";
        public const string HeartRateReceived = "Com.KnightTime.HeartRateReceived";
        public const string SkinTemperatureReceived = "Com.KnightTime.SkinTemperatureReceived";
        public const string AmbientLightReceived = "Com.KnightTime.AmbientLightReceived";
        public const string AmbientNoiseReceived = "Com.KnightTime.AmbientNoiseReceived";
        public const string AmbientTempReceived = "Com.KnightTime.AmbientTempReceived";
        public const string AmbientHumidityReceived = "Com.KnightTime.AmbientHumidityReceived";
        public const string EegReceived = "Com.KnightTime.EEGReceived";        

        /// <summary>
        /// Tag that will be used by the Android log 
        /// </summary>
        private const string KnightTimeServiceTag = "KnightTimeService";

        private readonly object _locker = new object();
        private readonly object _disconnectLocker = new object();

        class Peripheral
        {
            public int Id { get; set; }
            public bool Connected { get; set; }
            public BluetoothSocket Socket { get; set; }
            public BluetoothDevice Device { get; set; }
            public BluetoothConnection Connection { get; set; }
            string MacAddress { get; set; }

            public Peripheral(int id, string address)
            {
                Id = id;
                Connected = false;
                Socket = null;
                Device = null;
                Connection = null;
                MacAddress = address;
            }
        }

        /* KnightTime Devices */
        private Peripheral _baseStation { get; set; }
        private Peripheral _wrist { get; set; }
        private Peripheral _mask { get; set; }

        /// <summary>
        /// Id that indentifies this application
        /// </summary>
        public const int KnightTimeNotificationId = 777;

        //Green Modules from China CSRs from ebay
#if (!BLUESMIRF)
        private static string WRIST_PERIPHERAL_ADDRESS = "00:12:03:26:51:69";
        private static string PERIPHERAL_2 = "00:12:03:26:54:25";
#endif
#if (BLUESMIRF)

        //private static string MaskPeripheralAddress = "00:12:03:26:54:25";
        private static string MaskPeripheralAddress = "00:12:03:26:51:69";   
        //Chinese
        //private const string WristPeripheralAddress = "00:12:03:26:54:25";

        private const string WristPeripheralAddress = "00:06:66:49:4B:C7";
        //private const string MaskPeripheralAddress = "00:06:66:49:4B:C7";
        //private const string WristPeripheralAddress = "00:06:66:49:54:54";
#endif
        //TODO: Define mac address for the base station.
        private const string BaseStationAddress = "00:12:03:26:54:25";
        //private const string BaseStationAddress = "00:12:03:26:51:69";   

        private Task _monitorThread;

        /// <summary>
        /// Whether or not the service finished attempting to connect with the peripherals.
        /// </summary>
        private volatile bool _isFinishedConnecting = false;

        /// <summary>
        /// Whether or not the service is actively polling the peripherals.
        /// </summary>
        private volatile bool _isPollingPeripherals = false;

        /// <summary>
        /// Returns weather the service is running. Called by the binder.
        /// </summary>
        public bool IsRunning { get { return _isPollingPeripherals; } }

        /// <summary>
        /// Whether or not the service SHOULD poll the peripherals.
        /// </summary>
        private volatile bool _doPolling = false;

        private KnightTimePollRepository _repository;
        private MonitorBinder binder;
        internal Run CurrentRun { private set; get; }

        private volatile bool _isServiceRunning = false;

        public override void OnCreate()
        {
            base.OnCreate();

            if (_isServiceRunning) return;

            _wrist = new Peripheral(0, WristPeripheralAddress);
            _mask = new Peripheral(1, MaskPeripheralAddress);
            _baseStation = new Peripheral(2, BaseStationAddress);

            Log.Info(KnightTimeServiceTag, "Service created!");

            ConnectToKnightTimeDevices();
        }

        public void ConnectToKnightTimeDevices()
        {
            ThreadPool.QueueUserWorkItem((state) =>
            {
                for (int deviceNumber = 0; deviceNumber < 3; deviceNumber++)
                {
                    //Attempt to connect to each of the devices.
                    //If it fails, the notify the user with a toast.
                    int number = deviceNumber;
                    if (ConnectViaMac(number))
                    {
                        switch (number)
                        {
                            case 0:
                                _wrist.Connection = new BluetoothConnection(_wrist.Socket);
                                Log.Info(KnightTimeServiceTag, "Wrist Peripheral did connected.");
                                break;
                            case 1:
                                _mask.Connection = new BluetoothConnection(_mask.Socket);
                                Log.Info(KnightTimeServiceTag, "Mask Peripheral did connected.");
                                break;
                            case 2:
                                _baseStation.Connection = new BluetoothConnection(_baseStation.Socket);
                                Log.Info(KnightTimeServiceTag, "Base station did connected.");
                                break;
                        }
                        //Inform the activity that the device connected successfully
                        if (binder != null)
                        binder.AttemptToPeripheralConnectionEnded(this, number, true, true);
                    }
                    else
                    {
                        switch (number)
                        {
                            case 0: Log.Info(KnightTimeServiceTag, "Wrist Peripheral did not connect.");
                                break;
                            case 1: Log.Info(KnightTimeServiceTag, "Mask Peripheral did not connect.");
                                break;
                            case 2: Log.Info(KnightTimeServiceTag, "Base station did not connect.");
                                break;
                        }
                        //Inform the activity that the device did not connect successfully
                        if (binder != null)
                        binder.AttemptToPeripheralConnectionEnded(this, number, false, true);
                    }
                }
                _isFinishedConnecting = true;
            });
        }

        public override IBinder OnBind(Intent intent)
        {
            binder = new MonitorBinder(this);
            return binder;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            if (intent != null)
            {
                string command = intent.GetStringExtra(KnightTimeModeExtraName);

                Log.Info(KnightTimeServiceTag, "Service Started!");

                _monitorThread = Task.Factory.StartNew(() =>
                    {
                        while (!_isFinishedConnecting)
                        {
                            Thread.Sleep(1000);
                        }
                        if (!IsTestMode)
                        {
                            //Add a new run to the run Db. 
                            CurrentRun = new Run()
                            {
                                StartTime = DateTime.Now
                            };
                            KnightTimeRunRepository.SaveRun(CurrentRun);
                        }                        
                        PollKnightTimeDevices(WakeByRem);
                        
                    });
            }
            //It's a non-sticky service becuase if restarted by Android, it will not resume.
            return StartCommandResult.NotSticky;
        }

        public override void UnbindService(IServiceConnection conn)
        {
            base.UnbindService(conn);
            lock (_disconnectLocker)
            {
                DisconnectFromDevices();
            }
            _isFinishedConnecting = false;
            Log.Info(KnightTimeServiceTag, "Service has been unbinded.");
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            //If this is not test mode, then save when the run ended.
            if (!IsTestMode && CurrentRun != null)
            {
                CurrentRun.EndTime = DateTime.Now;
                KnightTimeRunRepository.SaveRun(CurrentRun);
            }

            SendLightArrayCommand(OnOffCommand.OFF);

            lock (_disconnectLocker)
            {
                DisconnectFromDevices();
            }
            _isFinishedConnecting = false;
            Log.Info(KnightTimeServiceTag, "Service is now being destroyed.");
            _isServiceRunning = false;
        }
      
        /*
         * --------------------------------------------
         *                  Logic 
         * --------------------------------------------
         */
        /// <summary>
        /// Initalizes the knightime variables according to the application's settings
        /// </summary>
        public void InitializeKnightTime(bool isTestMode)
        {
            var settings = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            FailSafeTime = DateTime.Parse(settings.GetString(MonitorPreferences.Alarm, MonitorPreferences.AlarmDefaultSetting));
            MonitorQueue = FailSafeTime.Subtract(new TimeSpan(0, 30, 0));
            Vibrate = (MonitorPreferences.Switch)System.Enum.Parse(typeof(MonitorPreferences.Switch), settings.GetString(MonitorPreferences.Vibrate, MonitorPreferences.VibrateDefaultSetting));
            Buzzer = (MonitorPreferences.Switch)System.Enum.Parse(typeof(MonitorPreferences.Switch), settings.GetString(MonitorPreferences.Buzzer, MonitorPreferences.BuzzerDefaultSetting));
            CurrentMode = (MonitorPreferences.ModeType)System.Enum.Parse(typeof(MonitorPreferences.ModeType), 
                                            settings.GetString(MonitorPreferences.Mode, MonitorPreferences.ModeDefaultSetting));
            IsTestMode = isTestMode;
        }

        /// <summary>
        /// Stops the service from polling and forces the service to disconnect from the peripherals.
        /// <remarks>
        /// The polling stops once the last peripheral (base station) was polled and reply messages were stored.
        /// </remarks>
        /// </summary>
        public void AbortPolling()
        {
            lock (_disconnectLocker)
            {
                DisconnectFromDevices();
            }
        }

        /// <summary>
        /// Disconnects the connected devices from bluetooth.
        /// </summary>
        private void DisconnectFromDevices()
        {
            lock (_locker)
            {
                _isPollingPeripherals = false;
            }

            /* Close the existing bluetooth connections */
            if (_wrist.Connection != null)
                _wrist.Connection.Cancel();
            if (_mask.Connection != null)
                _mask.Connection.Cancel();
            if (_baseStation.Connection != null)
                _baseStation.Connection.Cancel();
        }

        /// <summary>
        /// Connect to KnightTime device. 
        /// <remarks>
        /// 0: Wrist
        /// 1: Mask
        /// 2: Base Station
        /// </remarks>
        /// </summary>
        /// <param name="deviceNumber"></param>
        /// <returns></returns>
        public bool ConnectViaMac(int deviceNumber)
        {
            string macAddress;
            string deviceName;
            BluetoothSocket socket = null;
            BluetoothDevice device = null;

            var bluetoothAdapter = BluetoothAdapter.DefaultAdapter;

            if (bluetoothAdapter == null)
            {
                //Device does not support bluetooth
                //TODO
                Toast.MakeText(this, "This device does not support bluetooth!", ToastLength.Long);
            }

            try
            {
                switch (deviceNumber)
                {
                    case 0:
                        if (_wrist != null && _wrist.Device != null && _wrist.Connected) return true;
                        macAddress = WristPeripheralAddress;
                        device = _wrist.Device = bluetoothAdapter.GetRemoteDevice(macAddress);
                        socket = _wrist.Socket = device.CreateInsecureRfcommSocketToServiceRecord(SerialPortUUID);
                        deviceName = "Wrist Peripheral";
                        break;
                    case 1:
                        if (_mask != null && _mask.Device != null && _mask.Connected) return true;
                        macAddress = MaskPeripheralAddress;
                        device = _mask.Device = bluetoothAdapter.GetRemoteDevice(macAddress);
                        socket = _mask.Socket = device.CreateInsecureRfcommSocketToServiceRecord(SerialPortUUID);
                        deviceName = "Mask Peripheral";
                        break;
                    case 2:
                        if (_baseStation != null && _baseStation.Device != null && _baseStation.Connected) return true;
                        macAddress = BaseStationAddress;
                        device = _baseStation.Device = bluetoothAdapter.GetRemoteDevice(macAddress);
                        socket = _baseStation.Socket = device.CreateInsecureRfcommSocketToServiceRecord(SerialPortUUID);
                        deviceName = "Base Station";
                        break;
                    default:
                        throw new IllegalArgumentException("Device number not recognized");
                }
            }
            catch (Java.IO.IOException e)
            {
                Log.Warn(KnightTimeServiceTag, "Failed to create the Bluetooth socket.");
                return false;
            }


            if (bluetoothAdapter.IsDiscovering)
            {
                bluetoothAdapter.CancelDiscovery();
            }
            try
            {
                if (!socket.IsConnected)
                {
                    //Yay finally conect!
                    socket.Connect();
                }
                
                //If no exceptions are thrown yet, then the device successfully connected.
                switch (deviceNumber)
                {
                    case 0:
                        Log.Info(KnightTimeServiceTag, "Wrist Peripheral has been succesfully connected.");
                        _wrist.Connected = true;
                        break;
                    case 1:
                        Log.Info(KnightTimeServiceTag, "Mask Peripheral has been successfully connected.");
                        _mask.Connected = true;
                        break;
                    case 2:
                        Log.Info(KnightTimeServiceTag, "Base Station has been successfully connected.");
                        _baseStation.Connected = true;
                        break;
                }
                return true;
            }
            catch (Java.IO.IOException ex)
            {
                try
                {
                    Log.Warn(KnightTimeServiceTag, "Failed to establish bluetooth connection. " + ex.Message);
                    if (socket.IsConnected)
                        socket.Close();
                    return false;
                }
                catch (Java.IO.IOException)
                {
                    Log.Warn(KnightTimeServiceTag, "Failed to establish bluetooth connection and close the socket." + ex.Message);
                    return false;
                }
            }
            catch (IllegalThreadStateException ex)
            {
                Log.Error(KnightTimeServiceTag, "IllegalThreadStateException when connecting to device " + deviceName + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Send a message to the a KnightTime device. 
        /// </summary>
        /// <param name="deviceID">The Device ID of the KnightTime device.</param>
        /// <param name="array">The message as a byte array.</param>
        private void RequestTo(int deviceID, byte[] array)
        {
            switch (deviceID)
            {
                case 0:
                    Log.Info(KnightTimeServiceTag, "Sending request message to Wrist Peripheral.");
                    _wrist.Connection.Write(array);
                    break;
                case 1:
                    Log.Info(KnightTimeServiceTag, "Sending request message to Mask Peripheral.");
                    _mask.Connection.Write(array);
                    break;
                case 2:
                    Log.Info(KnightTimeServiceTag, "Sending request message to Base Station.");
                    _baseStation.Connection.Write(array);
                    break;
                default: throw new IllegalArgumentException("Device id not recognized.");
            }
        }

        private uint _motion_moving_avg_counter = 0;
        private double _motion_moving_sum = 0;
        private const int MOTION_SAMPLING_N = 10;
        private double _previous_motion_moving_avg = 0;

        /// <summary>
        /// This is the Polling algorithm.
        /// Polls each deveice that is connected and then polls each message that corresponds to the device.
        /// </summary>
        private void PollKnightTimeDevices(string mode)
        {
            _isPollingPeripherals = true;
            _doPolling = true;
                        
            int msDeltaDelay = 30;
            int msDeltaPollDelay = 100;
            bool triggerAlarm = false;

            // Initialize the movement reply message deltas
            MovementReplyMessage.Initialize();

            do
            {
                var currentPoll = new Poll()
                        {
                            DateTime = DateTime.Now.ToString(),
                            
                        };
                if (!IsTestMode) currentPoll.RID = Manager.GetLatestRun().ID;

                byte[] messageBytes;

                if (_wrist.Connected)
                {
                    RequestTo(0, new byte[] {(byte) MessageId.MovementRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _wrist.Connection.WaitForNextMessage(13, (byte)MessageId.MovementReply);
                    Log.Info(KnightTimeServiceTag, "Wrist Peripheral Reply message received!");

                    MovementReplyMessage movementReplyMsg = new MovementReplyMessage { RawData = messageBytes };

                    var acc_coordinates = movementReplyMsg.GetAccelerations();
                    currentPoll.Motion_Acc_X = acc_coordinates.Item1.ToString();
                    currentPoll.Motion_Acc_Y = acc_coordinates.Item2.ToString();
                    currentPoll.Motion_Acc_Z = acc_coordinates.Item3.ToString();

                    var gyro_coordinates = movementReplyMsg.GetGyroscope();
                    currentPoll.Motion_Gyr_X = gyro_coordinates.Item1.ToString();
                    currentPoll.Motion_Gyr_Y = gyro_coordinates.Item2.ToString();
                    currentPoll.Motion_Gyr_Z = gyro_coordinates.Item3.ToString();

                    var temp_motion_jerk_mag = MovementReplyMessage.GetAccJerkMagnitude(
                                                                    acc_coordinates.Item1,
                                                                    acc_coordinates.Item2,
                                                                    acc_coordinates.Item3);
                    currentPoll.Motion_Jerk_Mag = temp_motion_jerk_mag.ToString();

                    currentPoll.Motion_Gyro_Mag = MovementReplyMessage.GetGyroMagnitude(
                                                                    gyro_coordinates.Item1,
                                                                    gyro_coordinates.Item2,
                                                                    gyro_coordinates.Item3).ToString();

                    //Calculate the moving average for the jerk magnitude.
                    if (_motion_moving_avg_counter++ % MOTION_SAMPLING_N == 0 && _motion_moving_avg_counter != 0)
                    {
                        _motion_moving_sum += temp_motion_jerk_mag;
                        _previous_motion_moving_avg = _motion_moving_sum / MOTION_SAMPLING_N;
                        currentPoll.Motion_Jerk_Mag_MovingAvg = _previous_motion_moving_avg.ToString();
                        _motion_moving_sum = 0;
                    }
                    else
                    {
                        currentPoll.Motion_Jerk_Mag_MovingAvg = _previous_motion_moving_avg.ToString();
                    }

                    binder.ReceivedMessage(this, movementReplyMsg);
                }
                if (_mask.Connected)
                {
                    RequestTo(1, new byte[] {(byte) MessageId.HeartRateRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _mask.Connection.WaitForNextMessage(3, (byte)MessageId.HeartRateReply);
                    Log.Info(KnightTimeServiceTag, "Mask Peripheral Reply message received! bytes: ", messageBytes.ToString());                                    
                    var heartRateReplyMsg = new HeartRateReplyMessage { RawData = messageBytes };
                    currentPoll.HeartRate = heartRateReplyMsg.ConvertRawData().ToString();
                    binder.ReceivedMessage(this, heartRateReplyMsg);

                    RequestTo(1, new byte[] {(byte) MessageId.TemperatureRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _mask.Connection.WaitForNextMessage(3, (byte)MessageId.TemperatureReply);
                    var temperatureReplyMsg = new TemperatureReplyMessage { RawData = messageBytes };
                    Log.Info(KnightTimeServiceTag, "Mask Peripheral Reply message received! bytes: ", messageBytes.ToString());
                    currentPoll.Temperature = temperatureReplyMsg.ConvertRawData().ToString();
                    binder.ReceivedMessage(this, temperatureReplyMsg);

                    /* EEG not implemented */
                    //RequestTo(2, new byte[] {(byte) MessageId.EegRequest});
                    ////TODO change the bytesize of WaitForNextMessage
                    //messageBytes = _baseStation.Connection.WaitForNextMessage(3, (byte)MessageId.EegReply);
                    //Log.Info(KnightTimeServiceTag, "Base Station Reply message received!");
                    //currentPoll.EEG = BitConverter.ToUInt16(messageBytes, 1).ToString();
                    //Log.Debug(KnightTimeServiceTag, "EEG: " + currentPoll.EEG);
                    //dataPoints++;
                }
                if (_baseStation.Connected)
                {
                    RequestTo(2, new byte[] {(byte) MessageId.AmbientLightRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _baseStation.Connection.WaitForNextMessage(3, (byte)MessageId.AmbientLightReply);
                    Log.Info(KnightTimeServiceTag, "Base Station Reply message received!");
                    var ambientLightReplyMsg = new AmbientLightReply { RawData = messageBytes };
                    currentPoll.AmbientLight = ambientLightReplyMsg.ConvertRawData().ToString();
                    binder.ReceivedMessage(this, ambientLightReplyMsg);
                    

                    RequestTo(2, new byte[] {(byte) MessageId.AmbientNoiseRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _baseStation.Connection.WaitForNextMessage(3, (byte)MessageId.AmbientNoiseReply);
                    Log.Info(KnightTimeServiceTag, "Base Station Reply message received!");
                    var ambientNoiseReplyMsg = new AmbientNoiseReply { RawData = messageBytes };
                    currentPoll.AmbientNoise = ambientNoiseReplyMsg.ConvertRawData().ToString();
                    binder.ReceivedMessage(this, ambientNoiseReplyMsg);

                    RequestTo(2, new byte[] {(byte) MessageId.AmbientTemperatureRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _baseStation.Connection.WaitForNextMessage(3, (byte)MessageId.AmbientTemperatureReply);
                    Log.Info(KnightTimeServiceTag, "Base Station Reply message received!");
                    var ambientTempReplyMsg = new AmbientTemperatureReply { RawData = messageBytes };
                    currentPoll.AmbientTemp = ambientTempReplyMsg.ConvertRawData().ToString();
                    Log.Debug(KnightTimeServiceTag, "Ambient Temperature: " + currentPoll.AmbientTemp);
                    binder.ReceivedMessage(this, ambientTempReplyMsg);

                    RequestTo(2, new byte[] {(byte) MessageId.AmbientHumidityRequest});
                    Thread.Sleep(msDeltaDelay);
                    messageBytes = _baseStation.Connection.WaitForNextMessage(3, (byte)MessageId.AmbientHumidityReply);
                    Log.Info(KnightTimeServiceTag, "Base Station Reply message received!");
                    var humidityTemp = BitConverter.ToUInt16(messageBytes, 1);
                    var ambientHumidityReplyMsg = new AmbientHumidityReply { RawData = messageBytes };
                    currentPoll.AmbientHumidity = ambientHumidityReplyMsg.ConvertRawData().ToString();
                    Log.Debug(KnightTimeServiceTag, "Ambient Humidity: " + currentPoll.AmbientHumidity);
                    binder.ReceivedMessage(this, ambientHumidityReplyMsg);
                }

                Log.Info(KnightTimeServiceTag, "Storing Received Messages...");
                if (!IsTestMode && (_wrist.Connected || _mask.Connected || _baseStation.Connected))
                {
                    KnightTimePollRepository.SavePoll(currentPoll);
                }

                binder.ReceivedPoll(this, currentPoll);

                Thread.Sleep(msDeltaPollDelay);
            } while (!(triggerAlarm = IsOptimalTimeForWakeUp()) && _doPolling);
            _isPollingPeripherals = false;

            if (triggerAlarm && !IsTestMode)
            {
                TriggerAlarm();
            }

        }

        private void TriggerAlarm()
        {
            binder.NotifyActivityToWakeUp(this);

            if (Vibrate == MonitorPreferences.Switch.On)
            {
                if (_wrist.Connected)
                {
                    //Send a command to turn on the vibrator on the wrist
                    RequestTo(0, new byte[] { (byte)MessageId.VibratorCommand, (byte)OnOffCommand.ON });
                }
            }
            if (Buzzer == MonitorPreferences.Switch.On)
            {
                if (_mask.Connected)
                {
                    //Send a command to turn on the buzzer on the mask.
                    RequestTo(1, new byte[] { (byte)MessageId.BuzzerCommand, (byte)OnOffCommand.ON });
                }
            }            
        }

        /// <summary>
        /// Send off commands to the buzzer, vibrator, and light array if they are connected.
        /// </summary>
        public void DismissAlarm()
        {
            if (Vibrate == MonitorPreferences.Switch.On)
            {
                if (_wrist.Connected)
                {
                    //Send a command to turn on the vibrator on the wrist
                    RequestTo(0, new byte[] { (byte)MessageId.VibratorCommand, (byte)OnOffCommand.OFF });
                }
            }
            if (Buzzer == MonitorPreferences.Switch.On)
            {
                if (_mask.Connected)
                {
                    //Send a command to turn on the buzzer on the mask.
                    RequestTo(1, new byte[] { (byte)MessageId.BuzzerCommand, (byte)OnOffCommand.OFF });

                    RequestTo(1, new byte[] { (byte)MessageId.EegRequest, (byte)OnOffCommand.OFF });
                }
            } 
        }

        /// <summary>
        /// This is the core of the whole application. This decides whether or not the user should wake.
        /// </summary>
        /// <returns>T/F for whether the user should wake.</returns>
        private bool IsOptimalTimeForWakeUp()
        {
            Log.Info(KnightTimeServiceTag, "Analyzing Poll data. Is it a good time to wake up?");

            //Do not analyze if on test mode.
            if (IsTestMode) return false;
            
            // Check for the failsafe
            if (DateTime.Now >= FailSafeTime)
            {
                return true;
            }

            // If the user doesn't want to be woken up at the best time
            if (CurrentMode == MonitorPreferences.ModeType.None) return false;

            // If it's not in the last n minutes of the sleep, then quit monitoring.
            if (DateTime.Now < MonitorQueue) return false;

            // Begin lighting the light array incrementally
            SendLightArrayCommand(OnOffCommand.ON);

            switch (CurrentMode)
            {
                case MonitorPreferences.ModeType.Rem:
                    {
                        if (_wrist.Connected && Manager.GetLatestJerkMagnitude() > 3000.0)
                            return true;
                    }
                    break;
                case MonitorPreferences.ModeType.Sunlight:
                    {

                    }
                    break;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SendLightArrayCommand(OnOffCommand cmd)
        {
            if (_mask != null && _mask.Connected && Buzzer == MonitorPreferences.Switch.On)
            {
                //RequestTo(1, new byte[] { (byte)MessageId.LightArrayCommand });
                //RequestTo(1, new byte[] { (byte)OnOffCommand.ON });
                RequestTo(1, new byte[] { (byte)MessageId.EegRequest, (byte)cmd });
            }
        }



        /*
         * --------------------------------------------
         *              HELPER METHODS
         * --------------------------------------------
         */
        /// <summary>
        /// Retries an Action a certain number of times.
        /// </summary>
        /// <param name="action">The action to retry.</param>
        /// <param name="numRetries">The number of times to retry.</param>
        /// <param name="retryTimeout">The time between each retry.</param>
        public static bool RetryAction(Action action, int numRetries, int retryTimeout)
        {
            if (action == null)
                throw new ArgumentNullException("action"); // slightly safer...
            do
            {
                try { action(); return true; }
                catch
                {
                    if (numRetries <= 0)
                    {
                        //throw;  // improved to avoid silent failure
                        return false;
                    }
                    else System.Threading.Thread.Sleep(retryTimeout);
                }
            } while (numRetries-- > 0);
            return false;
        }

        /// <summary>
        /// Show a notification.
        /// </summary>
        /// <param name="message">The message that is going to be displayed.</param>
        /// <param name="title">The title that is going to be displayed for the message.</param>
        private void NotifyUser(string message, string title)
        {
            var notificationMessenger = (NotificationManager) GetSystemService((NotificationService));
            //TODO change the icon and understand what's happening with the pending intent.
            var notification = new Notification(Resource.Drawable.knighttimelauncher, message);
            var pendingIntent = PendingIntent.GetActivity(this, 0, new Intent(this, typeof (MainActivity)), 0);
            notification.SetLatestEventInfo(this, title, message, pendingIntent);
            notificationMessenger.Notify(KnightTimeNotificationId, notification);                
        }
    }
}