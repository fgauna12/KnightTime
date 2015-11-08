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
using AndroidViews = Android.Views;

namespace KnightTime.Android.View
{
    /// <summary>
    /// Listener that handles the selection of a tab in the user interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TabListener<T> : Java.Lang.Object, ActionBar.ITabListener
        where T : Fragment, new()
    {
        public T Fragment { private set; get; }
        private Activity _activity;

        /// <summary>
        /// initializes a new instance of the tab listener
        /// </summary>
        public TabListener()
        {
            Fragment = new T();
        }

        /// <summary>
        /// Initializes a new instance of the tab listener
        /// </summary>
        /// <param name="fragment"></param>
        protected TabListener(Activity activity, T fragment)
        {
            _activity = activity;
            Fragment = fragment;
        }

        /// <summary>
        /// Handles the reselection of the tab
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="ft"></param>
        public void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
        {

        }

        /// <summary>
        /// Adds the fragment when the tab was selected
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="ft"></param>
        public void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            ft.Replace(Resource.Id.Main, Fragment, typeof(T).FullName);
            //ft.Commit();
        }

        /// <summary>
        /// Removes the fragment when the tab was deselected
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="ft"></param>
        public void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
        {
            if (Fragment != null)
            {
                ft.Remove(Fragment);
            }
        }
    }
}