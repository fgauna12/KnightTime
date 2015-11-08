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

using KnightTime.Core.BusinessLayer.Contracts;

namespace KnightTime.Android.View
{
    public class MonitorBinder : Binder
    {
        private readonly KtService service;
        private IMonitor activity;

        private readonly object _locker = new object();
        private readonly object _informLocker = new object();
        
        public MonitorBinder(KtService service)
        {
            this.service = service;
        }

        public void SetMonitorActivity(IMonitor activity)
        {
            this.activity = activity;
        }

        public KtService GetBluetoothService()
        {
            return service;
        }

        public IMonitor GetMonitorActivity()
        {
            return activity;
        }

        /// <summary>
        /// Stop the KnightTime service from polling the peripherals.
        /// </summary>
        public void StopService()
        {
            service.AbortPolling();
        }

        /// <summary>
        /// Service received a KnightTime message. Invoke the message handler for the Monitor Activity.
        /// </summary>
        public void ReceivedPoll(object sender, KnightTime.Core.BusinessLayer.Poll poll)
        {
            if (sender == service)
            {
                activity.SetNewPoll(poll);
            }
        }

        public void ReceivedMessage(object sender, KnightTime.Core.BusinessLayer.Contracts.IKnightTimeMessage msg)
        {
            if (sender == service)
            {
                activity.SetNewMsg(msg);
            }
        }

        /// <summary>
        /// Called by the service whenever the service finishes bluetooth connection attempt.
        /// It calls the activity.
        /// </summary>
        /// <param name="sender">The KnightTime service</param>
        /// <param name="deviceId">0: wrist, 1: mask, 2: base station</param>
        /// <param name="successful">Whether the connection was successfuly established.</param>
        /// <param name="successful">Whether it's the first time the service tried connecting with the peripheral</param>
        public void AttemptToPeripheralConnectionEnded(object sender, int deviceId, bool successful, bool isFirstTime)
        {
            lock (_locker)
            {
                if (sender == service)
                {
                    activity.AttemptToPeripheralConnectionEnded(deviceId, successful, true);
                }
            }
        }

        /// <summary>
        /// Tell the service when the failsafe time is and what the mode of monitoring is.
        /// </summary>
        /// <param name="sender">The monitoring activity</param>
        /// <param name="m">The mode.</param>
        /// <param name="failSafe">The time of the failsafe alarm.</param>
        public void InitializeKnightTimeService(object sender, bool isTestMode)
        {
            lock (_locker)
            {
                if (activity == sender)
                {
                    service.InitializeKnightTime(isTestMode);
                }
            }
        }

        /// <summary>
        /// Find out whether the KnightTime service is monitoring the user with the devices (polling).
        /// </summary>
        public bool IsMonitoring
        {
            get
            {
                bool result;
                lock (_locker)
                {
                    result = service.IsRunning;
                }
                return result;
            }
        }

        public void RetryConnectionToKnightTimeDevices(object sender)
        {
            if (sender == activity)
            {
                service.ConnectToKnightTimeDevices();
            }
        }

        /// <summary>
        /// Tell the activity to trigger the alarm.
        /// </summary>
        /// <param name="sender">The service</param>
        public void NotifyActivityToWakeUp(object sender)
        {
            lock (_locker)
            {
                if (service == sender)
                {
                    activity.TriggerAlarm();
                }
            }
        }

        /// <summary>
        /// Tell the service to shut down the alarm if it's on.
        /// </summary>
        /// <param name="sender">The activity</param>
        public void DismissAlarm(object sender)
        {
            lock (_locker)
            {
                if (sender == activity)
                {
                    service.DismissAlarm();
                }
            }
        }
    }
}