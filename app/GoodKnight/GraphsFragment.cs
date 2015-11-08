using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

using AndroidViews = Android.Views;

using KnightTime.Core.BusinessLayer;

using Org.Achartengine;
using KnightTime.Core.DataAccessLayer;
//using Org.Achartengine.Chart;
//using Org.Achartengine.Model;
//using Org.Achartengine.Renderer;

namespace KnightTime.Android.View
{

    public class GraphsFragment : Fragment
    {
        // Arrays that contain the Y-Axis data
        public readonly CircularArray<double> realTimeBuffer = new CircularArray<double>(1000);
        public readonly CircularArray<double> realTimeBuffer2 = new CircularArray<double>(1000);

        public const string MovementTag = "Movement";
        public const string HeartRateTag = "Heart Rate";
        public const string SkinTempTag = "Skin Temperature";

        public const string AmbientTempTag = "Ambient Temperature";
        public const string AmbientHumidityTag = "Ambient Humidity";
        public const string AmbientNoiseTag = "Ambient Noise";
        public const string AmbientLightTag = "Ambient Light";

        public const string EegTag = "Eeg";

        public const string TestModeTag = "Test Mode";
        public bool IsTestMode { get; set; }
        
	    //For random test data
	    private int minRandom = 75;
	    private int maxRandom = 95;

        // These variables are defined outside of the functions so that they can be updated
        private GraphicalView _graphView;					// Created here so that the graph can be refreshed without creating a new one.
        private LineGraph line = new LineGraph();		// LineGraph is the custom class that will be used 

        private LinearLayout _linearLayout;

        private readonly object _locker = new object();

        public bool IsRealTime { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override AndroidViews.View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            _linearLayout = inflater.Inflate(Resource.Layout.Graphs, container, false) as LinearLayout;

            return _linearLayout;
        }

        /// <summary>
        /// When the activity finishes initializing, start fetching the data from the knightTime database
        /// </summary>
        /// <param name="savedInstanceState"></param>
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            if (_linearLayout != null)
            {
                //If the tag is TestMode then it's automatically real-time graph.
                IsTestMode = (!string.IsNullOrEmpty(Tag) && Tag == TestModeTag) ? true : IsTestMode;

                if (!IsTestMode) LoadKnightTimeData(Tag);
                else
                {
                    //Show the graph and hide the "no content" text view
                    var noTextTextView = _linearLayout.FindViewById<TextView>(Resource.Id.tvNoText);
                    var chart = _linearLayout.FindViewById<LinearLayout>(Resource.Id.Chart);
                    noTextTextView.Visibility = ViewStates.Invisible;
                    chart.Visibility = ViewStates.Visible;
                }
            }
        }

        /// <summary>
        /// This method loads the data base onto the graph
        /// </summary>
        private void LoadKnightTimeData(string arguement)
        {
            var bundle = Arguments;
            
            //Get the poll from the rid given. If no given, then get the polls fro the latest run.
            var data = (bundle != null)? Manager.GetPollsFromRID(bundle.GetInt("rid")):
                                         Manager.GetPollsFromLatestRun();
            
            IEnumerable<double> polls = null;

            switch (arguement)
            {
                case SkinTempTag:
                    {
                       polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.Temperature)) ? p.Temperature : "0"));
                       var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.Temperature));
                       if (polls.Count() == numEmtpy)
                           polls = null;
                    }
                    break;
                case HeartRateTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.HeartRate)) ? p.HeartRate : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.HeartRate));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case AmbientHumidityTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.AmbientHumidity)) ? p.AmbientHumidity : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.AmbientHumidity));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case AmbientLightTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.AmbientLight)) ? p.AmbientLight : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.AmbientLight));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case AmbientNoiseTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.AmbientNoise)) ? p.AmbientNoise : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.AmbientNoise));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case AmbientTempTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.AmbientTemp)) ? p.AmbientTemp : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.AmbientTemp));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case MovementTag:
                    {
                        polls = data.Select(p => double.Parse((!string.IsNullOrEmpty(p.Motion_Jerk_Mag)) ? p.Motion_Jerk_Mag : "0"));
                        var numEmtpy = data.Count((p) => string.IsNullOrEmpty(p.Motion_Jerk_Mag));
                        if (polls.Count() == numEmtpy)
                            polls = null;
                    }
                    break;
                case EegTag: //Eeg has no implementation
                default:                    
                    break;
            }

            var noTextTextView = _linearLayout.FindViewById<TextView>(Resource.Id.tvNoText);
            var chart = _linearLayout.FindViewById<LinearLayout>(Resource.Id.Chart);

            if (polls != null && polls.Count() > 0)
            {                
                noTextTextView.Visibility = ViewStates.Invisible;
                chart.Visibility = ViewStates.Visible;
                GraphHistory(polls.ToArray());
            }
            else
            {
                noTextTextView.Visibility = ViewStates.Visible;
                chart.Visibility = ViewStates.Invisible;
            }
        }

        // Creates a graph in the same activity so it appears under the buttons without taking up the full screen
        public void GraphReal(double data)
        {
            realTimeBuffer.Push(data);
            
            // A GraphicalView is used instead of an Intent so that it is in the same activity
            _graphView = line.GetViewHistory(this.Activity, realTimeBuffer.Array, true);	// getViewHistory will display only a graph of one line, boolean determines if it is real time

            // Adds the graph to the layout with the id Chart
            _linearLayout.RemoveAllViews();	// Removes any graph that may currently be in this spot
            _linearLayout.AddView(_graphView);		// Adds the new graph to this location in the layout
        }

        // Creates a graph in the same activity so it appears under the buttons and taking up the full screen
        public void GraphTwoLineReal(double data1, double data2)
        {
            realTimeBuffer.Push(data1);
            realTimeBuffer2.Push(data2);

            // A GraphicalView is used instead of an Intent so that it is in the same activity
            _graphView = line.getViewTwoLineHistory(this.Activity, realTimeBuffer.Array, realTimeBuffer2.Array, true);	// getViewTwoLineHistory will display only a graph of two lines, boolean determines if it is real time

            _linearLayout.RemoveAllViews();	// Removes any graph that may currently be in this spot
            _linearLayout.AddView(_graphView);		// Adds the new graph to this location in the layout
        }

        // Creates a graph in the same activity so it appears under the buttons without taking up the full screen
        public void GraphHistory(double[] dataArray)
        {
            // A GraphicalView is used instead of an Intent so that it is in the same activity
            _graphView = line.GetViewHistory(this.Activity, dataArray, false);	// getViewHistory will display only a graph of one line

            // Adds the graph to the layout with the id Chart
            LinearLayout layout = _linearLayout.FindViewById<LinearLayout>(Resource.Id.Chart);
            layout.RemoveAllViews();	// Removes any graph that may currently be in this spot
            layout.AddView(_graphView);		// Adds the new graph to this location in the layout
        }

        // Creates a graph in the same activity so it appears under the buttons and taking up the full screen
        public void GraphTwoLineHistory(double[] dataArray, double[] dataArray2)
        {
            
            // A GraphicalView is used instead of an Intent so that it is in the same activity
            _graphView = line.getViewTwoLineHistory(this.Activity, dataArray, dataArray2, false);	// getViewTwoLineHistory will display only a graph of two lines

            // Adds the graph to the layout with the id Chart
            LinearLayout layout = _linearLayout.FindViewById<LinearLayout>(Resource.Id.Chart);
            layout.RemoveAllViews();	// Removes any graph that may currently be in this spot
            layout.AddView(_graphView);		// Adds the new graph to this location in the layout
        }

        // Refresh current graph
        public void RefreshGraph()
        {
            lock (_locker)
            {
                // When doing a real graph you should use the correct function for each case

                // Add a new value on the Y-Axis for single line
                //var random = new Random();
                //line.addNewDataPoint_1Line(minRandom + (int)(random.Next(minRandom - maxRandom) * ((maxRandom - minRandom) + 1)));

                // Add a new value on the Y-Axis for each line
                //line.addNewDataPoint_2Line(minRandom + (int)(random.Next(minRandom, maxRandom) * ((maxRandom - minRandom) + 1)), minRandom + (int)(random.Next(minRandom, maxRandom) * ((maxRandom - minRandom) + 1)));


                //// If the graph has been created than refresh it
                if (_graphView != null)
                {
                    _graphView.Repaint(); 	// Refresh
                }
            }
        }
    }
}