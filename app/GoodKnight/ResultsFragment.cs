using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
//using Android.Views;
using Android.Widget;

using AndroidViews = Android.Views;
using KnightTime.Core.BusinessLayer;

namespace KnightTime.Android.View
{
    public class ResultsFragment : Fragment
    {
        private LinearLayout _linearLayout;
        private ListView _resulstListView;
        private IEnumerable<Run> _previousRunsList;
        private ResultsArrayAdapter _resultsAdapter;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override AndroidViews.View OnCreateView(AndroidViews.LayoutInflater inflater,
            AndroidViews.ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            _linearLayout = inflater.Inflate(Resource.Layout.ResultsFragment, container, false) as LinearLayout;

            InitializeResultsList();

            return _linearLayout;
        }

        private void InitializeResultsList()
        {
            var noResultsTextView = _linearLayout.FindViewById<TextView>(Resource.Id.tvNoResults);
            _resulstListView = _linearLayout.FindViewById<ListView>(Resource.Id.ResultsListView);

            _previousRunsList = Manager.GetRuns();

            //If there are no runs then show that there are no previous runs
            if (_previousRunsList.Any())
            {
                noResultsTextView.Visibility = AndroidViews.ViewStates.Invisible;
                _resulstListView.Visibility = AndroidViews.ViewStates.Visible;
            }
            else
            {
                noResultsTextView.Visibility = AndroidViews.ViewStates.Visible ;
                _resulstListView.Visibility = AndroidViews.ViewStates.Invisible ;
            }
                 
            //Add the main menu to the list view.
            _resultsAdapter = new ResultsArrayAdapter(_linearLayout.Context, Resource.Layout.Results_Item, _previousRunsList);

            _resulstListView.Adapter = _resultsAdapter;
            _resulstListView.ItemClick += ResultItemClicked;
        }

        /// <summary>
        /// Event handler for items that are cliked in the adapter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ResultItemClicked(object sender, AdapterView.ItemClickEventArgs e)
        {
            // Get the item that was just selected
            var runSelected = _previousRunsList.ElementAt(e.Position);
            if (runSelected != null)
            {
                Intent intent = new Intent(this.Activity, typeof(SummaryActivity));
                intent.PutExtra("rid", runSelected.ID);
                StartActivity(intent);
            }
        }

        /// <summary>
        /// This is the adapter used as the main menu settings for KnightTime.
        /// </summary>
        private class ResultsArrayAdapter : ArrayAdapter
        {
            private AndroidViews.LayoutInflater _layoutInflater;

            private IEnumerable<Run> _menuItems;
            
            private LinearLayout _linearLayout;

            private readonly TimeSpan healthySleepTimeThreshold = new TimeSpan(7, 30, 0);

            public ResultsArrayAdapter(Context context, int textViewResourceId, IEnumerable<Run> items)
                : base(context, textViewResourceId)
            {
                _menuItems = items;
               
                // Retrieve the layout inflater from the provided context
                //_layoutInflater = AndroidViews.LayoutInflater.FromContext(context);

                _layoutInflater = context.GetSystemService(Context.LayoutInflaterService) as AndroidViews.LayoutInflater;
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return null;
            }

            public override int Count
            {
                get { return _menuItems.Count(); }
            }

            public override AndroidViews.View GetView(int position, AndroidViews.View convertView, AndroidViews.ViewGroup parent)
            {
                var view = convertView;
                if (view == null)
                {
                    view = _layoutInflater.Inflate(Resource.Layout.Results_Item, null);
                }
                var menuItem = _menuItems.ElementAt(position);
                if (menuItem != null)
                {
                    TextView dayDateTitle = view.FindViewById<TextView>(Resource.Id.tvDayDate);
                    TextView description = view.FindViewById<TextView>(Resource.Id.tvDescription);
                    ImageView icon = view.FindViewById<ImageView>(Resource.Id.result_icon_image_view);

                    dayDateTitle.Text = menuItem.StartTime.ToString("dddd MM/dd/yy");
                    description.Text = "Time Slept: " + menuItem.HoursSlept.ToString("hh':'mm':'ss");
                    icon.SetImageResource(menuItem.HoursSlept > healthySleepTimeThreshold
                                              ? Resource.Drawable.ic_action_heart
                                              : Resource.Drawable.ic_action_sad);
                }
                return view;
            }
        }
    }
}