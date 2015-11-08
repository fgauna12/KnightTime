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
    public interface IMonitor
    {
        void SetNewPoll(KnightTime.Core.BusinessLayer.Poll poll);
        void AttemptToPeripheralConnectionEnded(int deviceId, bool successful, bool isFirstTime);
        void TriggerAlarm();
        void SetNewMsg(IKnightTimeMessage msg);
    }
}