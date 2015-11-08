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

namespace KnightTime.Android.View.Dialogs
{
    public class LogInDialog : DialogFragment
    {
        public string UserName { private set; get; }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            AlertDialog.Builder bobTheBuilder = new AlertDialog.Builder(Activity);
            bobTheBuilder.SetTitle("Sign In")
                .SetItems(new string[] { "Facebook", "Email" },
                new EventHandler<DialogClickEventArgs>(this.SignIn));

            return base.OnCreateDialog(savedInstanceState);
        }

        private void SignIn(object sender, DialogClickEventArgs args)
        {
            /*Sign in with Facebook*/
            if (args.Which == 0)
            {
                //TODO
            }
            /* Sign in with Email */
            else if (args.Which == 1)
            {
                if (ValidateEmail())
                {
                    //Tell the login acctivity that we're signing in and loading the data.

                }                
            }
        }
        private bool ValidateEmail()
        {
            //Do something fancy here and throw another dialog.
            //Have an email, a username (so others can find him), 
            // also a play button, forgot password, use facebook
            return true;
        }
    }
    
}