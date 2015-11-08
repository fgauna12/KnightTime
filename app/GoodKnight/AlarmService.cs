using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using AndroidNet = Android.Net;
using Android.Preferences;

namespace KnightTime.Android.View
{
    [Service]
    public class KnightTimeAlarmService : Service
    {
        public const string PlayCommand = "Play";
        public const string StopCommand = "Stop";
        public const string CommandExtraName = "Command";

        private MediaPlayer _player;

        public override void OnDestroy()
        {
            base.OnDestroy();

            StopPlaying();
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            string command = intent.GetStringExtra(CommandExtraName);

            switch (command)
            {
                case PlayCommand:
                    StartPlaying();

                    break;
                case StopCommand:
                    StopPlaying();

                    break;
                default:
                    return base.OnStartCommand(intent, flags, startId);
            }

            return StartCommandResult.Sticky;
        }

        private void StartPlaying()
        {
            if (_player != null && _player.IsPlaying)
                return;

            var getAlarms = PreferenceManager.GetDefaultSharedPreferences(BaseContext);
            String alarms = getAlarms.GetString("ringtone", "default ringtone");         
            var alert = AndroidNet.Uri.Parse(alarms);            

            try 
            {
                _player = new MediaPlayer();
                _player.SetDataSource(this, alert);
                AudioManager audioManager = (AudioManager)this.GetSystemService(Context.AudioService);
                if (audioManager.GetStreamVolume(Stream.Alarm) != 0) {
                    _player.SetAudioStreamType(Stream.Alarm);
                    _player.Prepare();
                    _player.Start();
                }
            } catch (Java.IO.IOException e) 
            {
                Log.Error("KnightTime Alarm", "Error playing alarm");                
            }

            //_player = MediaPlayer.Create(this, Resource.Raw.NIN);
            //_player.Start();
            //_player.Completion += (sender, e) => StopSelf();
        }

        private void StopPlaying()
        {
            if (_player == null || !_player.IsPlaying)
                return;

            _player.Stop();
            _player.Release();
            _player = null;
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }
    }
}