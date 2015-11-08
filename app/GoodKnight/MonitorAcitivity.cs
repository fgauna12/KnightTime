using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using RadialProgress;
using KnightTime.Core.BusinessLayer.Contracts;
using KnightTime.Core.BusinessLayer;
using Android.Graphics;
using System.Threading;

namespace KnightTime.Android.View
{
    [Activity(Label = "Monitoring", Icon = "@drawable/knighttimelauncher", Theme = "@style/Theme.LogIn")]
    public class MonitorActivity : Activity, IMonitor
    {
        public const string ActivityModeKey = "Activity Mode";
        public const string ActivityModeTest = "Test";
        public const string ActivityModeDefault = "Default";

        public MonitorBinder binder;
        public KnightTimeServiceConnection knightTimeServiceConnection;
        public bool isBound;

        private KnightTimeReceiver _messageReceiver;

        private Intent knightTimeServiceIntent;

        private volatile bool _wristFailedConnection;
        private volatile bool _maskFailedConnection;
        private volatile bool _baseStationFailedConnection;
        private bool _isTestMode;

        /*
         * Views
         */
        private Button _startStopButton;
        private ProgressDialog _progressDialog;

        private TextView _messagesCounter;
        private TextView _pollCounter;

        private ImageView _wristConnectionStateImage;
        private ImageView _maskConnectionStateImage;
        private ImageView _baseStationConnectionStateImage;

        private RadialProgressView _radialProgressView;

        private GraphsFragment _graphsFragment;
        private PowerManager.WakeLock _wakeLock;

        private volatile bool _triggerAlarm;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Activate the action bar and display it in navigation mode.
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.Monitor);

            //Force the orientation of the monitor activity to be landscape
            this.RequestedOrientation = global::Android.Content.PM.ScreenOrientation.Landscape;

            /* 
             * Find out if the activty is being requested to run in test mode or default
             */
            var b = Intent.Extras;
            if (b != null)
            {
                var activityMode = b.GetString(ActivityModeKey);
                if (activityMode != null)
                {
                    _isTestMode = (activityMode == ActivityModeTest) ? true : false;
                }                
            }                      

            //_messagesCounter = FindViewById<TextView>(Resource.Id.ReceivedDataPointsCounter);
            //_pollCounter = FindViewById<TextView>(Resource.Id.PollNumberCounter);
            _radialProgressView = FindViewById<RadialProgressView>(Resource.Id.RadialPollProgress);
            _radialProgressView.Visibility = ViewStates.Invisible;
            _wristConnectionStateImage = FindViewById<ImageView>(Resource.Id.WristConnectionStateImageView);
            _maskConnectionStateImage = FindViewById<ImageView>(Resource.Id.MaskConnectionStateImageView);
            _baseStationConnectionStateImage = FindViewById<ImageView>(Resource.Id.BaseStationConnectionStateImageView);
            _startStopButton = FindViewById<Button>(Resource.Id.AbortMonitorButton);
            _startStopButton.Click += (sender, args) => { HandleStartStopButtonClick(); };
            _startStopButton.Text = (!_isTestMode) ? Resources.GetString(Resource.String.StartMonitorText) : "Begin Test";

            //knightTimeServiceIntent = new Intent("com.knighttime.knighttimeservice");
            knightTimeServiceIntent = new Intent(this, typeof(KtService));
            knightTimeServiceIntent.PutExtra(KtService.KnightTimeModeExtraName, StartMonitorFragment.KnightTimeMode);
            knightTimeServiceConnection = new KnightTimeServiceConnection(this);

            //If the service successfuly started, notify the user of success.
            if (BindService(knightTimeServiceIntent, knightTimeServiceConnection, Bind.AutoCreate))
            {
                /* Register the receiver that will catch the broadcasts by the KnightTime service */
                var filter = new IntentFilter(KtService.MotionReceived);
                filter.AddCategory(Intent.ActionDefault);
                RegisterReceiver(_messageReceiver, filter);

                _progressDialog = ProgressDialog.Show(this, "Connecting to KnightTime Peripherals", "Please wait...");

                isBound = true;
            }
            else
            {
                //The service unsucessfuly started.
                Toast.MakeText(this, "Error: Service unable to restart", ToastLength.Long);
            }
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 1)
            {
                if (data != null && data.Extras != null)
                {
                    if (data.Extras.ContainsKey("dismiss") && data.Extras.GetBoolean("dismiss"))
                    {
                        binder.DismissAlarm(this);
                        this.Finish();

                        StartActivity(typeof(SummaryActivity));
                        
                        _wakeLock.Release();
                    }
                }
            }
        }

        /// <summary>
        /// This method initialized the click event handler for the Start/Stop button of the activity
        /// </summary>
        private void HandleStartStopButtonClick()
        {
            //Make sure that the KnightTime service is binded to the activity
            if (knightTimeServiceConnection != null && isBound && binder != null)
            {
                //If Start
                if (_startStopButton.Text == Resources.GetString(Resource.String.StartMonitorText) || _startStopButton.Text == "Begin Test")
                {
                    _startStopButton.Text = Resources.GetString(Resource.String.StopMonitorText);
                    var stopIconDrawable = Resources.GetDrawable(Resource.Drawable.ic_action_playback_stop);
                    _startStopButton.SetCompoundDrawablesWithIntrinsicBounds(stopIconDrawable, null,  null, null);

                    //When the service is started make sure that the progress circle is showing 
                    _radialProgressView.Visibility = ViewStates.Visible;

                    binder.InitializeKnightTimeService(this, _isTestMode);

                    InitializeGraphFragment();

                    this.StartService(knightTimeServiceIntent);
                }
                //If Stop
                else if (_startStopButton.Text == Resources.GetString(Resource.String.StopMonitorText))
                {
                    Log.Info("MonitorActivity", "Request to abort KnightTime service submitted.");
                    binder.StopService();
                    this.Finish();
                    if (!_isTestMode)
                        StartActivity(typeof(SummaryActivity));
                }
            }
        }

        /// <summary>
        /// Method loads the graph fragment into the container and delegates whether it's real-time or history mode.
        /// </summary>
        private void InitializeGraphFragment()
        {
            FragmentTransaction ft = FragmentManager.BeginTransaction();

            //If the activity is launched in test mode, then show real-time graphing
            if (_isTestMode)
            {
                _graphsFragment = new GraphsFragment()
                {
                    IsTestMode = _isTestMode
                };
                ft.Add(Resource.Id.GraphContainerMonitorActivity, _graphsFragment, GraphsFragment.TestModeTag);
            }
            //Else by default show the monitor default panel, in this case, a clock (4-9-12)
            else
            {
                var defaultMonitorPanelFragment = new MonitorPanelFragment();
                ft.Add(Resource.Id.GraphContainerMonitorActivity, defaultMonitorPanelFragment);
            }

            ft.Commit();
        }

        /// <summary>
        /// When the user presses the back button, make sure that there's a confirmation and the service is stopped.
        /// </summary>
        public override void OnBackPressed() 
        {
            if (knightTimeServiceConnection != null && isBound && binder != null)
            {
                //find out whether the KnightTime service is polling
                if (binder.IsMonitoring)
                {
                    new AlertDialog.Builder(this)
                           .SetMessage("If you exit, the monitoring will end. \nDo you want to continue?")
                           .SetCancelable(false)
                           .SetPositiveButton("Yes", (sender, e) => this.Finish())
                           .SetNegativeButton("No", (sender, e) => { })
                           .Show();
                }
                else base.OnBackPressed();
            }
            else base.OnBackPressed();
        }

        public void TriggerAlarm()
        {
            RunOnUiThread(() =>
            {
                KeyguardManager myKM = this.ApplicationContext.GetSystemService(Context.KeyguardService) as KeyguardManager;
                if (myKM.InKeyguardRestrictedInputMode())
                {
                    //it is locked
                    _triggerAlarm = true;
                }
                else
                {
                    //it is not locked, therefore start the alarm now
                    Intent intent = new Intent(this, typeof(AlarmAlertFullScreen));
                    StartActivityForResult(intent, 1);
                }
                WakeUpAndroidDevice();                
            });
        }

        private void WakeUpAndroidDevice()
        {
            var powerManager = GetSystemService(Context.PowerService) as PowerManager;
            _wakeLock = powerManager.NewWakeLock(WakeLockFlags.Full, "KnightTime Wakelock");
            _wakeLock.Acquire();

            Window.SetFlags(WindowManagerFlags.Fullscreen |
                            WindowManagerFlags.DismissKeyguard |
                            WindowManagerFlags.ShowWhenLocked |
                            WindowManagerFlags.TurnScreenOn,
                            WindowManagerFlags.Fullscreen |
                            WindowManagerFlags.DismissKeyguard |
                            WindowManagerFlags.ShowWhenLocked |
                            WindowManagerFlags.TurnScreenOn);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (knightTimeServiceConnection != null && isBound && binder != null)
            {
                StopService(new Intent(this, typeof(KtService)));
                UnbindService(knightTimeServiceConnection);
                isBound = false;
            }
            //If the service was started before the activity closes.
            if (_messageReceiver != null)
                UnregisterReceiver(_messageReceiver);
        }

        /// <summary>
        /// Method that is called whenever the device wakes
        /// </summary>
        protected override void OnRestart()
        {
            base.OnRestart();

            if (_triggerAlarm)
            {
                Intent intent = new Intent(this, typeof(AlarmAlertFullScreen));
                StartActivityForResult(intent, 1);
                _triggerAlarm = false;
            }
        }

        /// <summary>
        /// This method is called by the service that calls the binder which then calls the activity.
        /// </summary>
        /// <param name="poll"></param>
        public void SetNewPoll(Poll poll)
        {
            if (poll == null) throw new ArgumentNullException("Poll given to the monitor activity is null!");
            if (!_isTestMode) return;
            double result;

            if (Double.TryParse(poll.Motion_Jerk_Mag, out result))
            {
                RunOnUiThread(() => _graphsFragment.GraphReal(result));
            }            
        }

        public void SetNewMsg(IKnightTimeMessage msg)
        {
            switch (msg.GetType())
            {
                case MessageId.AmbientHumidityReply: break;
                case MessageId.AmbientLightReply: break;
                case MessageId.AmbientNoiseReply: break;
                case MessageId.AmbientTemperatureReply: break;
                //case MessageId.EegReply: break;
                case MessageId.HeartRateReply: break;
                case MessageId.MovementReply: break;
            }
            UpdateNewRadialProgressView();
        }

        private bool _failedConnection;
        /// <summary>
        /// Called by the binder whenever the service finishes bluetooth connection attempt.
        /// </summary>
        /// <param name="deviceId">0: wrist, 1: mask, 2: base station</param>
        /// <param name="successful">Whether the connection was successfuly established.</param>
        public void AttemptToPeripheralConnectionEnded(int deviceId, bool successful, bool isFirstTime)
        {
            int deviceNumber = deviceId;

            
            RunOnUiThread(() => 
            { 
                switch (deviceNumber)
                {
                    //Wrist 
                    case 0:
                        if (successful)
                        {
                            _wristConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_tick);
                        }
                        else
                        {
                            _wristConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_cancel);
                            _failedConnection = true;
                        }
                        break;
                    case 1:
                        if (successful)
                        {
                            _maskConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_tick);
                        }
                        else
                        {
                            _maskConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_cancel);
                            _failedConnection = true;
                        }
                        break;
                    case 2:
                        if (successful)
                        {
                            _baseStationConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_tick);
                        }
                        else
                        {
                            _baseStationConnectionStateImage.SetImageResource(Resource.Drawable.ic_action_cancel);
                            _failedConnection = true;
                        }
                        _progressDialog.Hide();

                        // If it's the first poll from the service, then ask to retry after each of the peripherals has been attempted.
                        if (_failedConnection) AskForBtConnectionRetry();
                        break;
                }
            });
        }

        private void AskForBtConnectionRetry()
        {
            if (this.IsFinishing) return;

            /* After all devices were polled for bluetooth connections, offer to reattempt for the ones that failed */
            new AlertDialog.Builder(this)
               .SetMessage("Some devices did not connect properly. Would you like to reattempt?")
               .SetCancelable(false)
               .SetPositiveButton("Yes", (sender, e) =>
               {
                   if (binder != null)
                   {
                       _failedConnection = false;
                       _progressDialog.Show();
                       binder.RetryConnectionToKnightTimeDevices(this);
                   }
               })
               .SetNegativeButton("No", (sender, e) => { })
               .Show();
        }

        private void UpdateNewRadialProgressView()
        {
            RunOnUiThread(() =>
            {
                if (_radialProgressView.IsDone)
                {
                    _radialProgressView.Reset();
                }
                else
                {
                    _radialProgressView.Value++;
                }
            });
        }
    }
}