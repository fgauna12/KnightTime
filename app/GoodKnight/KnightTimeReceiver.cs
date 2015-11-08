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

using Android.Bluetooth;

namespace KnightTime.Android.View
{
    /// <summary>
    /// This class is the bluetooth receiver for the KnightTime application. It listens for broadcasts in the network.
    /// </summary>
    [BroadcastReceiver]
    public class KnightTimeReceiver : BroadcastReceiver
    {
        //When discovery finds a device
        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
            var messageBytes = intent.GetByteArrayExtra(KtService.MotionReceived);

            switch (action)
            {
                // Wrist
                case KtService.MotionReceived:
                    break;

                // Headband
                case KtService.HeartRateReceived:
                    //TODO
                    break;
                case KtService.SkinTemperatureReceived:
                    //TODO
                    break;

                // Base Station
                case KtService.EegReceived:
                    //TODO
                    break;
                case KtService.AmbientNoiseReceived:
                    //TODO
                    break;
                case KtService.AmbientHumidityReceived:
                    //TODO
                    break;
            }
        }
    }
}