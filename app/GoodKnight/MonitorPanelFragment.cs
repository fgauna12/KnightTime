using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using AndroidViews = Android.Views;
using Android.Widget;

namespace KnightTime.Android.View
{
    public class MonitorPanelFragment : Fragment
    {
        private LinearLayout _linearLayout;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override AndroidViews.View OnCreateView(AndroidViews.LayoutInflater inflater,
            AndroidViews.ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            _linearLayout = inflater.Inflate(Resource.Layout.MonitorPaneFragment, container, false) as LinearLayout;

            return _linearLayout;
        }
    }
}