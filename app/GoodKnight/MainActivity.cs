using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using AndroidViews = Android.Views;
using Android.Widget;
using Java.IO;
using KnightTime.Core.BusinessLayer.Contracts;
using KnightTime.Core.BusinessLayer;
using File = System.IO.File;
using AndroidFile = Java.IO.File;
using Environment = Android.OS.Environment;
using IOException = System.IO.IOException;
using Uri = Android.Net.Uri;
using Android.Content.PM;
using Android.Media;

namespace KnightTime.Android.View
{
    [Activity(Icon = "@drawable/knighttimelauncher", Theme = "@style/Theme.Activity", UiOptions = UiOptions.SplitActionBarWhenNarrow)]
    public class MainActivity : Activity
    {
        private GraphsFragment _graphsTabFragment;
        private StartMonitorFragment _startMonitorFragment;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Activate the action bar and display it in navigation mode.
            RequestWindowFeature(AndroidViews.WindowFeatures.ActionBar);

            SetContentView(Resource.Layout.Main);

            InitializeActionBar();

            //Check for bluetooth connectivity
            var bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
            if (bluetoothAdapter == null || !bluetoothAdapter.IsEnabled)
            {
                //If bluetooth is not enabled.
                int REQUEST_ENABLE_BT = 5;
                Intent enableBtIntent = new Intent(BluetoothAdapter.ActionRequestEnable);
                StartActivityForResult(enableBtIntent, REQUEST_ENABLE_BT);
            }
        }

        public override bool OnCreateOptionsMenu(AndroidViews.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.ActionItems, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(AndroidViews.IMenuItem item)
        {
            if (item.ItemId == Resource.Id.logout)
            {
                this.Finish();
                StartActivity(typeof(LogInActivity));
                return true;
            }
            else if (item.ItemId == Resource.Id.test)
            {
                Intent intent = new Intent(this, typeof(MonitorActivity));
                var b = new Bundle();
                b.PutString(MonitorActivity.ActivityModeKey, MonitorActivity.ActivityModeTest);
                intent.PutExtras(b);
                StartActivity(intent);
                return true;
            }
            return false;
        }

        private void TimePickerCallback(object sender, TimePickerDialog.TimeSetEventArgs e)
        {
            var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            var oldFailSafe = DateTime.Parse(prefs.GetString(MonitorPreferences.Alarm, MonitorPreferences.AlarmDefaultSetting));
            DateTime newFailSafe = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            var editor = prefs.Edit();
            
            //If we need to add a day
            if (newFailSafe.Hour > e.HourOfDay)
            {
                //newFailSafe = newFailSafe.AddHours((double)(newFailSafe.Hour-e.HourOfDay));
                newFailSafe = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, e.HourOfDay, e.Minute, DateTime.Now.Second);
                newFailSafe = newFailSafe.AddDays(1.0);
            }
            else if (newFailSafe.Hour == e.HourOfDay)
            {
                //This is nap mode
                if (newFailSafe.Minute > e.Minute)
                {
                    
                    newFailSafe = newFailSafe.AddDays(1.0);
                }
                else 
                {
                    //TODO enter nap mode
                    newFailSafe = newFailSafe.AddMinutes((double)(e.Minute - newFailSafe.Minute));
                }
            }
            else 
            {
                newFailSafe = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, e.Minute, DateTime.Now.Second);
                newFailSafe = newFailSafe.AddHours((double)(e.HourOfDay - newFailSafe.Hour));
                //newFailSafe = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, e.HourOfDay, e.Minute, DateTime.Now.Second);
                //newFailSafe = newFailSafe.AddDays(1.0);
            }

            editor.PutString(MonitorPreferences.Alarm, newFailSafe.ToString());
            editor.Commit();

            _startMonitorFragment.RefreshMenu();
        }

        protected override Dialog OnCreateDialog(int id)
        {
            var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            switch (id)
            {
                case StartMonitorFragment.TIME_DIALOG_ID:
                {
                    DateTime date = DateTime.Parse(prefs.GetString(MonitorPreferences.Alarm, MonitorPreferences.AlarmDefaultSetting));
                    return new TimePickerDialog(this, TimePickerCallback, date.Hour, date.Minute, false);
                }
                case StartMonitorFragment.MODE_TYPE_DIALOG_ID:
                {
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.SetTitle("Chose how you want to wake up")
                           .SetItems(Resource.Array.pref_monitorModes, new EventHandler<DialogClickEventArgs>(UpdateMode));
                    return builder.Create();
                }
                case StartMonitorFragment.SMARTALARM_TYPE_DIALOG_ID:
                {
                    AlertDialog.Builder builder = new AlertDialog.Builder(this);
                    builder.SetTitle("Choose the Interactive Alarm type")
                           .SetItems(Resource.Array.pref_smartAlarmTypes_entries, new EventHandler<DialogClickEventArgs>(UpdateSmartAlarm));
                    return builder.Create();
                }
            }             
               
            return null;
        }

        /// <summary>
        /// Callback called by the dialogs created to choose modes and settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSmartAlarm(object sender, DialogClickEventArgs e)
        {
            var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            switch (e.Which)
            {
                //Rem
                case 0:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.SmartAlarm, "MathProblem");
                        editor.Commit();
                        Toast.MakeText(this, "Smart Alarm set to Math Problem", ToastLength.Long).Show();
                    } break;
                //Sunlight
                case 1:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.SmartAlarm, "QRCode");
                        editor.Commit();
                        Toast.MakeText(this, "Smart Alarm set to QR Code", ToastLength.Long).Show();
                    } break;
                case 2:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.SmartAlarm, "None");
                        editor.Commit();
                        Toast.MakeText(this, "Smart Alarm disabled", ToastLength.Long).Show();
                    } break;
            }
            _startMonitorFragment.RefreshMenu();
        }

        /// <summary>
        /// Callback called by the dialogs created to choose modes and settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateMode(object sender, DialogClickEventArgs e)
        {
            var prefs = Application.Context.GetSharedPreferences(MonitorPreferences.FileName, FileCreationMode.Private);
            switch (e.Which)
            {
                //Rem
                case 0:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.Mode, "Rem");
                        editor.Commit();
                        Toast.MakeText(this, "Entered REM Mode", ToastLength.Long).Show();
                    } break;
                //Sunlight
                case 1:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.Mode, "Sunlight");
                        editor.Commit();
                        Toast.MakeText(this, "Entered Sunlight Mode", ToastLength.Long).Show();
                    } break;
                case 2:
                    {
                        var editor = prefs.Edit();
                        editor.PutString(MonitorPreferences.Mode, "None");
                        editor.Commit();
                        Toast.MakeText(this, "Alarm disabled", ToastLength.Long).Show();
                    } break;
            }
            _startMonitorFragment.RefreshMenu();
        }

        private void InitializeActionBar()
        {
            if (ActionBar == null)
                return;
            // Set the action bar to Tab mode
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            /*Create new Monitor tab*/
            // Create a new tab (CreateTabSpec on the TabControl)
            var homeTab = ActionBar.NewTab();
            var startMonitorTabListener = new TabListener<StartMonitorFragment>();
            _startMonitorFragment = startMonitorTabListener.Fragment as StartMonitorFragment;
            homeTab.SetTabListener(startMonitorTabListener);
            homeTab.SetIcon(Resource.Drawable.ic_action_knight);
            homeTab.SetText("Monitor");
            // Add the new tab to the action bar
            ActionBar.AddTab(homeTab);

            /*Create new Graphs tab*/
            // Create a new tab (CreateTabSpec on the TabControl)
            var graphTab = ActionBar.NewTab();
            
            graphTab.SetTabListener(new TabListener<ResultsFragment>());
            graphTab.SetText("Results");
            graphTab.SetIcon(Resource.Drawable.ic_action_line_chart);
            // Add the new tab to the action bar
            ActionBar.AddTab(graphTab);
        }
    }
}