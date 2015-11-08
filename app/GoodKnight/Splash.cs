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

namespace KnightTime.Android.View.Resources.Layout
{
    [Activity(MainLauncher = true, Theme = "@style/Theme.SplashEmpty", NoHistory = true, Icon = "@drawable/knighttimelauncher")]
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Start KnightTime here
            StartActivity(typeof(LogInActivity));
        }
    }
}