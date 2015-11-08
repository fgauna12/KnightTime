#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Xamarin.Auth;

namespace KnightTime.Android.View
{
    [Activity(Label = "Log In", Icon = "@drawable/knighttimelauncher", Theme = "@style/Theme.LogIn")]
    public class LogInActivity : Activity
    {
        private int REQUEST_ENABLE_BT = -1;

        private static KnightTimeReceiver _receiver = null;
        private static BluetoothDevice _baseStation = null;

        private readonly TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

        private const string FacebookAppId = "157968244360327";
        private const string FacebookAppSecret = "5d1ca5b33f7922f01e724ce36738230a";

        ProgressDialog _progressDialog = null;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Activate the action bar and display it in navigation mode.
            RequestWindowFeature(WindowFeatures.NoTitle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LogIn);

            LinearLayout layout = new LinearLayout(this);

            var facebookLoginButton = FindViewById<Button>(Resource.Id.LoginButton);
            var guestLoginButton = FindViewById<Button>(Resource.Id.GuestButton);
            guestLoginButton.Click += (sender, args) =>
                {
                    StartActivity(typeof(MainActivity));
                };
            //Define the event handler for when the button is clicked.
            facebookLoginButton.Click += LoginToFacebook;
        }

        void LoginToFacebook(object sender, EventArgs e)
        {
            var auth = new OAuth2Authenticator(
                clientId: FacebookAppId,
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));

            // If authorization succeeds or is canceled, .Completed will be fired.
            auth.Completed += (s, eventArgs) =>
            {
                if (!eventArgs.IsAuthenticated)
                {
                    //todo not autheticated
                    return;
                }
                else
                {
                    StartActivity(typeof(MainActivity));
                }

                // Now that we're logged in, make a OAuth2 request to get the user's info.
                var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me"), null, eventArgs.Account);
                request.GetResponseAsync().ContinueWith(t =>
                {
                    if (t.IsFaulted)
                        Log.Info("KnightTimeView", "Error: " + t.Exception.InnerException.Message);
                    else
                    {
                        string json = t.Result.GetResponseText();
                        Log.Info("KnightTimeView", json);
                    }
                });
            };

            Intent intent = auth.GetUI(this);
            StartActivityForResult(intent, 42);
        }

        protected override void OnDestroy()
        {
            if (_receiver != null)
                UnregisterReceiver(_receiver);
            base.OnDestroy();
        }
        private bool IsUsernameValid(string username)
        {
#if DEBUG
            return true;
#endif
            throw new NotImplementedException();
        }
    }
}