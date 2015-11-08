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

namespace KnightTime.Android.View
{
    public class KnightTimeServiceConnection : Java.Lang.Object, IServiceConnection
    {
        private MonitorActivity activity;

        public KnightTimeServiceConnection(MonitorActivity acitivity)
        {
            this.activity = acitivity;
        }

        public void OnServiceConnected(ComponentName name, IBinder service)
        {
            var knightTimeServiceBinder = service as MonitorBinder;

            if (knightTimeServiceBinder != null)
            {
                var binder = (MonitorBinder) service;
                activity.binder = binder;
                binder.SetMonitorActivity(activity);
                activity.isBound = true;
            }
        }

        public void OnServiceDisconnected(ComponentName name)
        {
            activity.isBound = false;
            activity.binder = null;
        }
    }
}