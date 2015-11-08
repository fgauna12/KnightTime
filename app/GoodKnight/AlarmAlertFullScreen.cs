using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Preferences;

using Java.Util;
using Android.Util;
using Android.Media;

using AndroidNet = Android.Net;

namespace KnightTime.Android.View
{
    /**
     * Alarm Clock alarm alert: pops visible indicator and plays alarm
     * tone. This activity is the full screen version which shows over the lock
     * screen with the wallpaper as the background.
     */
    [Activity(Theme = "@style/Theme.Activity")]
    public class AlarmAlertFullScreen : Activity
    {

        // These defaults must match the values in res/xml/settings.xml
        private const String DEFAULT_SNOOZE = "10";
        private const String DEFAULT_VOLUME_BEHAVIOR = "2";
        protected const String SCREEN_OFF = "screen_off";

        private int mVolumeBehavior;

        MediaPlayer _player;

        private Ringtone _ringTone;
        
        protected override void OnCreate(Bundle icicle)
        {
            base.OnCreate(icicle);

            //TODO deleted alarm assignment

            mVolumeBehavior = 100;

            RequestWindowFeature(WindowFeatures.NoTitle);
            
            SetContentView(Resource.Layout.AlarmAlert);

            /* Dismiss button */
            var dismiss = FindViewById<Button>(Resource.Id.Dismiss);
            dismiss.Click += (o, s) =>
                {
                    var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
                    var smartAlarmType = (MonitorPreferences.SmartAlarmType)System.Enum.Parse(typeof(MonitorPreferences.SmartAlarmType),
                                            prefs.GetString(MonitorPreferences.SmartAlarm, MonitorPreferences.SmartAlarmTypeDefaultSetting));
                    switch (smartAlarmType)
                    {
                        case MonitorPreferences.SmartAlarmType.None: Dismiss();
                            break;
                        case MonitorPreferences.SmartAlarmType.MathProblem:
                            //it is not locked, therefore start the alarm now
                            Intent intent = new Intent(this, typeof(SmartAlarms.MathGame));
                            StartActivityForResult(intent, 2);
                            break;
                        default:
                            Dismiss();
                            break;
                    }
                    
                };

            /* Set the title to the current time */
            SetTitle();

            //_window.AddFlags(WindowManagerFlags.ShowWhenLocked | WindowManagerFlags.DismissKeyguard);
            
            //if (!Intent.GetBooleanExtra(SCREEN_OFF, false))
            //{
            //    _window.AddFlags(WindowManagerFlags.KeepScreenOn | WindowManagerFlags.TurnScreenOn);
            //}
            
            //StartService(intent);
            StartPlaying();
        }
        
        private void StartPlaying()
        {
            if (_ringTone != null && _ringTone.IsPlaying) return;
            var notification = RingtoneManager.GetDefaultUri(RingtoneType.Alarm);
            _ringTone = RingtoneManager.GetRingtone(ApplicationContext, notification);
            _ringTone.Play();
        }

        private void StopPlaying()
        {
            if (_ringTone!= null && !_ringTone.IsPlaying) return;
            _ringTone.Stop();
        }

        private void SetTitle()
        {
            String label = DateTime.Now.ToString("hh:mm tt");
            TextView title = FindViewById<TextView>(Resource.Id.AlertTitle);
            title.Text = label;
        }

        // Dismiss the alarm.
        private void Dismiss()
        {
            StopPlaying();
            Intent intent = Intent;
            intent.PutExtra("dismiss", true);
            SetResult(Result.Ok, intent);
            Finish();            
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 2)
            {
                if (data != null && data.Extras != null)
                {
                    if (data.Extras.ContainsKey("math_game") && data.Extras.GetBoolean("math_game"))
                    {
                        Dismiss();
                    }
                }
            }
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            // Do this on key down to handle a few of the system keys.
            bool up = e.Action == KeyEventActions.Up;
            switch (e.KeyCode)
            {
                // Volume keys and camera keys dismiss the alarm
                case Keycode.VolumeUp:
                case Keycode.VolumeDown:
                case Keycode.Camera:
                case Keycode.Focus:
                    if (up)
                    {
                        switch (mVolumeBehavior)
                        {
                            case 1:
                                break;

                            case 2:
                                Dismiss();
                                break;

                            default:
                                break;
                        }
                    }
                    return true;
                default:
                    break;
            }
            return base.DispatchKeyEvent(e);
        }

        public override void OnBackPressed()
        {
            // Don't allow back to dismiss. This method is overriden by AlarmAlert
            // so that the dialog is dismissed.
            return;
        }
    }
}