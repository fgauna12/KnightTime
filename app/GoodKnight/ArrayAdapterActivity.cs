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

namespace KnightTime.Android.View
{
    [Activity(Label = "Select a Device")]
    public class ArrayAdapterActivity : ListActivity
    {
        public List<string> Lines;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            ArrayAdapter adapter = new ArrayAdapter(this, Resource.Layout.TextViewItem, Lines);
            if (adapter != null)
            {
                ListAdapter = adapter;
            }

        }
        public void Insert(string Text)
        {
            Lines.Insert(0, Text);
        }

        //Add a line of text to the adapter
        private void OnTextChanged()
        {
            //This is supposed to be launched.
        }
        //protected override void OnListItemClick(ListView l, View v, int position, long id)
        //{
        //    base.OnListItemClick(l, v, position, id);
        //    Toast.MakeText(this, Lines[position],
        //    ToastLength.Short).Show();
        //}
    }
}