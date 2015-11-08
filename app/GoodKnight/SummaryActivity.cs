using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using System.Threading;

using File = System.IO.File;
using AndroidFile = Java.IO.File;
using Environment = Android.OS.Environment;
using IOException = System.IO.IOException;
using Uri = Android.Net.Uri;

using AndroidViews = Android.Views;
using System.IO;

using KnightTime.Core.BusinessLayer.Contracts;
using KnightTime.Core.BusinessLayer;
using Android.Content.PM;

using Org.Achartengine;

namespace KnightTime.Android.View
{
    [Activity(Label = "Summary", Icon = "@drawable/knighttimelauncher", Theme = "@style/Theme.Activity", UiOptions = UiOptions.SplitActionBarWhenNarrow)]
    public class SummaryActivity : Activity
    {
        private string _csvDebugFilePath;

        private GraphicalView _graphView;
        private int _rid;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Activate the action bar and display it in navigation mode.
            RequestWindowFeature(AndroidViews.WindowFeatures.ActionBar);

            // Create your application here
            SetContentView(Resource.Layout.Summary);

            if (Intent != null)
                _rid = Intent.GetIntExtra("rid", -1);
            else _rid = -1;

            InitializeActionBar();
        }

        private void InitializeActionBar()
        {
            if (ActionBar == null)
                return;

            //TODO Initalize with a dropdown list
            // Set the action bar to Tab mode
            ActionBar.NavigationMode = ActionBarNavigationMode.List;

            ActionBar.SetListNavigationCallbacks(new NavigationSpinnerAdapter(this) , new NavigationListener(FragmentManager, _rid));
        }

        public override bool OnCreateOptionsMenu(AndroidViews.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.SummaryActionItems, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(AndroidViews.IMenuItem item)
        {
            if (item.ItemId == Resource.Id.export_as_csv)
            {
                ThreadPool.QueueUserWorkItem((state) =>
                    {
                        ToCsvFile();
                        RunOnUiThread(() => SendCsvFileOverEmail());
                    });

                return true;
            }
            else if (item.ItemId == Resource.Id.share)
            {
                //TODO share results
                return true;
            }
            return false;
        }

        /*
         * --------------- HELPER METHODS -----------------
         */
        public void ToCsvFile()
        {
            int count = 0;

            //Get the polls from the database from all the days stored
            var data = KnightTime.Core.DataAccessLayer.KnightTimePollRepository.GetPolls();

            // (they don't want non-user-generated data in Documents)
            //string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            string libraryPath = Environment.ExternalStorageDirectory.ToString();
            _csvDebugFilePath = Path.Combine(libraryPath, "KnightTime_Data.csv");

            var file = File.CreateText(_csvDebugFilePath);

            //Print header
            file.WriteLine(string.Join(",", "ID", "RID", 
                                        //"First Name", "Last Name", "Birthdate", "Gender", 
                                        "Date and Time", "Acceleration - X", "Acceleration - Y", "Acceleration - Z",
                                        "Gyroscope - X", "Gyroscope - Y", "Gyroscope - Z",
                                        "Heartrate", "Skin Temperature", "EEG", "Ambient Light", "Ambient Humidity",
                                        "Ambient Noise", "Ambient Temperature", "Jerk Magnitude", "Gyro Magnitude", "Movement Score"));
            foreach (Poll line in data)
            {
                string row = line.ID.ToString();
                foreach (var sensorData in line.ToArray())
                {
                    row = string.Join(",", row, sensorData);
                }
                file.WriteLine(row);
            }
            file.Close();
        }

        public void SendCsvFileOverEmail()
        {
            Intent sendIntent = new Intent(Intent.ActionSend);
            sendIntent.SetType("text/html");
            sendIntent.PutExtra(Intent.ExtraEmail, new string[] { "fgauna12@gmail.com", "anthonyb2477@gmail.com, ryanmurphy.ee@gmail.com, bart.straka@gmail.com" });
            sendIntent.PutExtra(Intent.ExtraSubject, "KnightTime CSV File for" + DateTime.Now.ToString("MM/dd hh:mm tt"));
            sendIntent.PutExtra(Intent.ExtraText, "CSV file is attached. Representing the internal SQLite DB.");
            AndroidFile F = new AndroidFile(_csvDebugFilePath);
            Uri uri = Uri.FromFile(F);
            sendIntent.PutExtra(Intent.ExtraStream, uri);
            StartActivity(Intent.CreateChooser(sendIntent, "Send Mail"));
        }
    }

    public class NavigationSpinnerAdapter : BaseAdapter
    {
        private List<Java.Lang.Object> _spinnerItems;
        private AndroidViews.LayoutInflater _layoutInflater;

        public NavigationSpinnerAdapter(Context context)
        {
            _spinnerItems = new List<Java.Lang.Object>();       
            
            _spinnerItems.Add(new Java.Lang.String("Motion"));
            _spinnerItems.Add(new Java.Lang.String("Heart Rate"));
            _spinnerItems.Add(new Java.Lang.String("Skin Temperature"));
            //_spinnerItems.Add(new Java.Lang.String("Eeg"));

            _spinnerItems.Add(new Java.Lang.String("Ambient Temperature"));
            _spinnerItems.Add(new Java.Lang.String("Ambient Noise"));
            _spinnerItems.Add(new Java.Lang.String("Ambient Humidity"));
            _spinnerItems.Add(new Java.Lang.String("Ambient Light"));

            // Retrieve the layout inflater from the provided context
            _layoutInflater = AndroidViews.LayoutInflater.FromContext(context);

            
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return _spinnerItems[position];
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override AndroidViews.View GetView(int position, AndroidViews.View convertView, AndroidViews.ViewGroup parent)
        {
            var view = convertView;

            // Try to reuse views as much as possible.
            // It is alot faster than inflating new views all the time
            // and it saves quite a bit on memory usage aswell.
            if (view == null)
            {
                // inflate a new layout for the view.
                view = _layoutInflater.Inflate(Resource.Layout.Simple_Spinner_Item, parent, false);
            }

            var textView = view.FindViewById<TextView>(Resource.Id.textItem);
            textView.Text = _spinnerItems[position].ToString();

            return view;
        }

        public override int Count
        {
            get { return _spinnerItems.Count; }
        }
    }

    public class NavigationListener : Java.Lang.Object, ActionBar.IOnNavigationListener
    {
        FragmentManager _fragmentManager;
        private int _rid;
        public NavigationListener(FragmentManager fragmentManager, int rid)
        {
            if (fragmentManager == null) throw new ArgumentNullException("Null arguement given to NavigationListener");

            _fragmentManager = fragmentManager;
            _rid = rid;
        }
        public bool OnNavigationItemSelected(int itemPosition, long itemId)
        {
            // Create new fragment from our own Fragment class
            GraphsFragment newFragment = new GraphsFragment();

            if (_rid != -1)
            {
                var bundle = new Bundle();
                bundle.PutInt("rid", _rid);
                newFragment.Arguments = bundle;
            }

            FragmentTransaction ft = _fragmentManager.BeginTransaction();
            
            // Replace whatever is in the fragment container with this fragment
            //  and give the fragment a tag name equal to the string at the position selected
            // Determine what kind of graph to display
            switch (itemPosition)
            {
                case 0: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.MovementTag); break;
                case 1: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.HeartRateTag); break;
                case 2: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.SkinTempTag); break;
                //case 3: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.EegTag); break;
                case 3: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.AmbientTempTag); break;
                case 4: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.AmbientNoiseTag); break;
                case 5: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.AmbientHumidityTag); break;
                case 6: ft.Replace(Resource.Id.GraphContainer, newFragment, GraphsFragment.AmbientLightTag); break;
            }
            ft.Commit();
            return true;
        }
    }
}