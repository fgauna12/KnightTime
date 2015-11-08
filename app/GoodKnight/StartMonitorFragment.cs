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

using File = System.IO.File;
using AndroidFile = Java.IO.File;
using Environment = Android.OS.Environment;
using IOException = System.IO.IOException;
using Uri = Android.Net.Uri;

using AndroidViews = Android.Views;
using System.IO;

using KnightTime.Core.BusinessLayer.Contracts;
using KnightTime.Core.BusinessLayer;
using Android.Media;
using Android.Provider;

namespace KnightTime.Android.View
{
    public class StartMonitorFragment : Fragment
    {
        public static string KnightTimeMode;

        public const int TIME_DIALOG_ID = 0;
        public const int MODE_TYPE_DIALOG_ID = 1;
        public const int SMARTALARM_TYPE_DIALOG_ID = 2;
        public const int RINGTONE_TYPE_DIALOG_ID = 3;

        private Button _timeChooserButton;

        //Views
        private ListView _mainMenu;
        private MainMenuAdapter _adapter;
        private LinearLayout _linearLayout;

        //Used for preferences
        private ISharedPreferences _knightTimeSettings;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            _knightTimeSettings = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
        }

        public override AndroidViews.View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            if (container == null)
            {
                return null;
            }
            _linearLayout = inflater.Inflate(Resource.Layout.StartMonitor, container, false) as LinearLayout;

            if (_linearLayout == null)
                return _linearLayout;

            var startStopButton = _linearLayout.FindViewById<Button>(Resource.Id.StartStopButton);
            startStopButton.Click += (sender, e) =>
            {
                Activity.StartActivity(typeof(MonitorActivity));
            };

            InitalizeMainMenu();

            return _linearLayout;
        }

        private void InitalizeMainMenu()
        {
            _mainMenu = _linearLayout.FindViewById<ListView>(Resource.Id.MainMenuListView);

            //Add the main menu to the list view.
            _adapter= new MainMenuAdapter(_linearLayout.Context, Resource.Layout.MainMenu_Item);

            _mainMenu.Adapter = _adapter;
            //_mainMenu.Click += MainMenuHandleClick;
            _mainMenu.ItemClick += MainMenuItemClicked;
        }

        void MainMenuItemClicked(object sender, AdapterView.ItemClickEventArgs e)
        {
            switch (e.Position)
            {
                case 0: 
                    Activity.ShowDialog(TIME_DIALOG_ID); 
                    break;
                case 1:
                    Intent intent = new Intent(RingtoneManager.ActionRingtonePicker);
                    intent.PutExtra(RingtoneManager.ExtraRingtoneTitle, "Choose an alarm sound");
                    Uri uri = ContentUris.WithAppendedId(MediaStore.Audio.Media.ExternalContentUri, 11);
                    // Don't show 'Silent'
                    intent.PutExtra(RingtoneManager.ExtraRingtoneShowDefault, true);
                    intent.PutExtra(RingtoneManager.ExtraRingtoneShowSilent, true);
                    //intent.PutExtra(RingtoneManager.ExtraRingtoneType, 4); //Constant value of 4 is the alarm.
                    intent.PutExtra(RingtoneManager.ExtraRingtoneExistingUri, uri);
                    intent.PutExtra(RingtoneManager.ExtraRingtonePickedUri, true);
                    StartActivityForResult(intent, 123);
                    break;
                case 2:
                    TogglePreference(MonitorPreferences.Vibrate);
                    break;
                case 3:
                    TogglePreference(MonitorPreferences.Buzzer);
                    break;
                case 4:
                    Activity.ShowDialog(MODE_TYPE_DIALOG_ID); break;
                    break;
                case 5: 
                    Activity.ShowDialog(SMARTALARM_TYPE_DIALOG_ID); break;
                    break;
                //case 6:
                //    TogglePreference(MonitorPreferences.AirplaneMode);
                //    break;
            }
            RefreshMenu();            
        }

        public void RefreshMenu()
        {
            //Notify the adapter that the settings have changed.
            _adapter.NotifyDataSetChanged();
        }

        public override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            //If the user clicked ok.
            if (requestCode == 123 && resultCode == Result.Ok)
            {
                if (data == null) return;
                var result = data.GetParcelableExtra(RingtoneManager.ExtraRingtonePickedUri) as Uri;                
                if (result == null)
                {
                    RingtoneManager.SetActualDefaultRingtoneUri(this.Activity, RingtoneType.Alarm, null);
                }
                else
                {
                    RingtoneManager.SetActualDefaultRingtoneUri(this.Activity, RingtoneType.Alarm, result);
                }
                _adapter.NotifyDataSetChanged();
            }
        }

        /// <summary>
        /// Toggle a setting on/off. Also launches a toast to inform the user.
        /// </summary>
        /// <param name="settingType"></param>
        private void TogglePreference(string settingType)
        {            
            var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            string currentSetting = string.Empty;
            switch (settingType)
            {
                case MonitorPreferences.Vibrate:
                    currentSetting = prefs.GetString(settingType, MonitorPreferences.VibrateDefaultSetting);
                    break;
                case MonitorPreferences.Buzzer:
                    currentSetting = prefs.GetString(settingType, MonitorPreferences.BuzzerDefaultSetting);
                    break;
                //case MonitorPreferences.AirplaneMode:
                //    currentSetting = prefs.GetString(settingType, MonitorPreferences.AirplaneModeDefaultSetting);
                //    break;
                default: return;
            }

            var value = (MonitorPreferences.Switch)Enum.Parse(typeof(MonitorPreferences.Switch), currentSetting);
            value = (value == MonitorPreferences.Switch.On) ? MonitorPreferences.Switch.Off : MonitorPreferences.Switch.On;
            var editor = prefs.Edit();
            editor.PutString(settingType, value.ToString());
            editor.Commit();
            
            //Inform the user of the setting change.
            Toast.MakeText(this.Activity, settingType + " was turned " + value.ToString().ToLower(), ToastLength.Long).Show();
        }

        /// <summary>
        /// This is the adapter used as the main menu settings for KnightTime.
        /// </summary>
        private class MainMenuAdapter : ArrayAdapter
        {
            private AndroidViews.LayoutInflater _layoutInflater;

            private List<Java.Lang.Object> _menuItems;
            private List<Java.Lang.Object> _menuCaptions;
            private LinearLayout _linearLayout;

            public MainMenuAdapter(Context context, int textViewResourceId)
                : base(context, textViewResourceId)
            {
                _menuItems = new List<Java.Lang.Object>();
                _menuCaptions = new List<Java.Lang.Object>();

                _menuItems.Add(new Java.Lang.String(MonitorPreferences.Alarm));
                _menuItems.Add(new Java.Lang.String(MonitorPreferences.Ringtone));
                _menuItems.Add(new Java.Lang.String(MonitorPreferences.Vibrate));
                _menuItems.Add(new Java.Lang.String(MonitorPreferences.Buzzer));
                _menuItems.Add(new Java.Lang.String(MonitorPreferences.Mode));
                _menuItems.Add(new Java.Lang.String(MonitorPreferences.SmartAlarm));
                //_menuItems.Add(new Java.Lang.String(MonitorPreferences.AirplaneMode));

                // Retrieve the layout inflater from the provided context
                //_layoutInflater = AndroidViews.LayoutInflater.FromContext(context);

                _layoutInflater = context.GetSystemService(Context.LayoutInflaterService) as LayoutInflater;
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return _menuItems[position];
            }

            public override int Count
            {
                get { return _menuItems.Count; }
            }

            public override AndroidViews.View GetView(int position, AndroidViews.View convertView, AndroidViews.ViewGroup parent)
            {
                var view = convertView;
                if (view == null)
                {
                    view = _layoutInflater.Inflate(Resource.Layout.MainMenu_Item, null);
                }
                var menuItem = GetItem(position);
                if (menuItem != null)
                {
                    TextView title = view.FindViewById<TextView>(Resource.Id.MainMenu_Name);
                    TextView caption = view.FindViewById<TextView>(Resource.Id.MainMenu_Caption);

                    var _knightTimePrefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
                    if (title != null)
                    {
                        title.Text = menuItem.ToString();

                        var icon = view.FindViewById<ImageView>(Resource.Id.MainMenu_icon);
                        switch (title.Text)
                        {
                            case MonitorPreferences.Alarm:
                                icon.SetImageResource(Resource.Drawable.ic_action_alarm_2);
                                //Set the failsafe time to 8 hours from now.
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.Alarm, MonitorPreferences.AlarmDefaultSetting);
                                break;
                            case MonitorPreferences.Ringtone:
                                icon.SetImageResource(Resource.Drawable.ic_action_music_2);
                                var defaultRingtoneUri = MonitorPreferences.RingtoneDefaultSettingURI;
                                Ringtone defaultRingtone = RingtoneManager.GetRingtone(this.Context, defaultRingtoneUri);
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.Ringtone, defaultRingtone.GetTitle(this.Context));
                                break;
                            case MonitorPreferences.Vibrate:
                                icon.SetImageResource(Resource.Drawable.ic_action_phone);
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.Vibrate, MonitorPreferences.VibrateDefaultSetting);
                                break;
                            case MonitorPreferences.Buzzer:
                                icon.SetImageResource(Resource.Drawable.ic_action_volume_up);
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.Buzzer, MonitorPreferences.BuzzerDefaultSetting);
                                break;
                            case MonitorPreferences.Mode:
                                icon.SetImageResource(Resource.Drawable.ic_action_line_chart);
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.Mode, MonitorPreferences.ModeDefaultSetting);
                                break;
                            case MonitorPreferences.SmartAlarm:
                                icon.SetImageResource(Resource.Drawable.ic_action_bulb);
                                caption.Text = _knightTimePrefs.GetString(MonitorPreferences.SmartAlarm, MonitorPreferences.SmartAlarmTypeDefaultSetting);
                                break;
                            //case MonitorPreferences.AirplaneMode:
                            //    caption.Text = _knightTimePrefs.GetString(MonitorPreferences.AirplaneMode, MonitorPreferences.AirplaneModeDefaultSetting);
                            //    icon.SetImageResource(Resource.Drawable.ic_action_plane);
                            //    break;
                        }
                    }
                }
                return view;
            }
        }
    }
}