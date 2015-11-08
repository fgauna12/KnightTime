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

namespace KnightTime.Android.View.SmartAlarms
{
    [Activity(Label = "Monitoring", Icon = "@drawable/knighttimelauncher", Theme = "@style/Theme.LogIn")]
    public class MathGame : Activity
    {
        private int _randomNumber;
        private EditText _answerEditText;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Activate the action bar and display it in navigation mode.
            RequestWindowFeature(WindowFeatures.NoTitle);

            SetContentView(Resource.Layout.MathGame);

            Random r = new Random();
            _randomNumber = r.Next(1, 1000);
            
            var title = FindViewById<TextView>(Resource.Id.tvMathProblem_Title);
            title.Text = "What's the derivative of ";

            var problem = FindViewById<TextView>(Resource.Id.tvMathProblem);
            problem.Text = _randomNumber.ToString() + "x";

            _answerEditText = FindViewById<EditText>(Resource.Id.etMathGameAnswer);
            var submitButton = FindViewById<Button>(Resource.Id.btOkButtonMathGame);
            submitButton.Click += (sender, args) =>
                {
                    if (Evaluate())
                    {
                        Dismiss();
                    }
                    else
                    {
                        Toast.MakeText(this, "WRONG ANSWER, TRY AGAIN", ToastLength.Long).Show();
                    }
                };
        }

        private void Dismiss()
        {
            Intent intent = Intent;
            intent.PutExtra("math_game", true);
            SetResult(Result.Ok, intent);
            Finish();    
        }

        private bool Evaluate()
        {
            return int.Parse(_answerEditText.Text) == _randomNumber;
        }
    }
}