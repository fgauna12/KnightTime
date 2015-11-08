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
using Android.Media;

using AndroidNet = Android.Net;

namespace KnightTime.Android.View
{
    public static class MonitorPreferences
    {
        public static string FileName = "KnightTimePrefsFile";

        public const string Alarm = "Failsafe Alarm";
        public const string Ringtone = "Ringtone";
        public const string Vibrate = "Vibrate";
        public const string Buzzer = "Buzzer";
        public const string Mode = "Mode";
        public const string SmartAlarm = "Smart Alarm";
        public const string AirplaneMode = "Airplane Mode";

        /// <summary>
        /// Gets the time 8 hours from this current time as the Property is called.
        /// </summary>
        public static string AlarmDefaultSetting { get { return DateTime.Now.AddHours(8.0).ToString(); } }
        public static AndroidNet.Uri RingtoneDefaultSettingURI
        {
            get
            {
                return RingtoneManager.GetDefaultUri(RingtoneType.Alarm);
            }
        }
        public const string VibrateDefaultSetting = "On";
        public const string BuzzerDefaultSetting = "On";
        public const string ModeDefaultSetting = "Rem";
        public const string SmartAlarmTypeDefaultSetting = "None";
        public const string AirplaneModeDefaultSetting = "Off";

        public enum Switch
        {
            Off = 0,
            On
        }

        public enum ModeType
        {
            Rem,
            Sunlight,
            None
        }

        public enum SmartAlarmType
        {
            None,
            MathProblem, 
            QrCode
        }
    }
}