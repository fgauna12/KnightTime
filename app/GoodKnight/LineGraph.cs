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
using Graphics = Android.Graphics;
using Android.Util;

using Org.Achartengine;
using Org.Achartengine.Chart;
using Org.Achartengine.Model;
using Org.Achartengine.Renderer;

namespace KnightTime.Android.View
{
    /// <summary>
    /// Version 1.0.2
    /// </summary>
    public class LineGraph
    {
        private double percentageOverLimits = 0.025;			// [Percentage] How much will the maximum and minimum Y-Axis values go beyond the values in data set
        private int maxNumberPointsRealTime = 100;				// How many points will fit inside the window the slides with the data.
        private int maxNumberPointsHistory = 250;				// Reduces the size of the graph to fit 250 points
        private XYMultipleSeriesRenderer _renderer;				// Defined here so that the graphs properties can be adjusted when a new point is added

        // These need to be created outside of the functions so that adding new data points will work
        public TimeSeries series = new TimeSeries("");		// Creates a new series that will hold all the data points and names it
        public TimeSeries series2 = new TimeSeries("");		// Creates a new series that will hold all the data points and names it

        /// <summary>
        /// Color Patellete used in the application
        /// <see cref="http://www.colourlovers.com/palette/2449038/%E2%98%BC_sunset_%E2%98%BE"/>
        /// </summary>
        public struct KnightTimeColor
        {
            public static Graphics.Color Yellow = Graphics.Color.Argb(128, 0xFC, 0xCB, 0x6F);
            public static Graphics.Color DarkYellow = Graphics.Color.Argb(128, 0xE1, 0x9F, 0x41);
            public static Graphics.Color S2Blue = Graphics.Color.Argb(128, 0x01, 0x0D, 0x23);
            public static Graphics.Color NauticalyBlue = Graphics.Color.Argb(128, 0x03, 0x22, 0x3F);
            public static Graphics.Color Aqua = Graphics.Color.Argb(128, 0x03, 0x8B, 0xBB);
        }

        /**
             * Divides the series into sections that are than averaged to create a smaller graph.
             * 
             * @param largeSeries			The original series before it is reduced
             * @return smallSeries			A much smaller series that is exactly the length of maxNumberPointsHistory
             */
        public TimeSeries reduceSeries1Size(TimeSeries largeSeries)
        {
            TimeSeries smallSeries = new TimeSeries(""); // Will store the new series that is returned

            double averageValue = 0;	// Will contain the average of the values that grouped together
            int numberValuesToAverage = largeSeries.ItemCount / maxNumberPointsHistory; // Divids the larger series into sections based on the number of points that should be in the smallSeries when this is done
            int valuesInNewArray = 0;	// Used to determine the location on the X-Axis for the new values


            // This is where the series is converted to a size that is desired.
            if (largeSeries.ItemCount > maxNumberPointsHistory)
            { // Determines if the series even needs to be shortened
                for (int i = 0; i < largeSeries.ItemCount; i++)
                {
                    averageValue += largeSeries.GetY(i);	// Adds up all the values

                    if ((i % numberValuesToAverage) == 0 && i > 0)
                    {
                        averageValue /= numberValuesToAverage;	// Finds the average

                        smallSeries.Add(valuesInNewArray, averageValue);	// Adds this averaged value to the new series

                        averageValue = 0;	// Resets the average so that it can be found again
                        valuesInNewArray++;	// Increments the X-axis so the points are spaced equally
                    }
                }
            }
            else
            { // If the series is already within range just set it to the original.
                smallSeries = largeSeries;
            }

            return smallSeries; // Returns the new series that is the correct length.
        }

        /**
         * This will add a new value to the Y-Axis after the last point that is on the graph.
         * The X-Axis value is incremented so that all the data points are spaced evenly.
         * 
         * This should only be used with Real Time graphs
         * 
         * @param _yValue1		Value to be added to line1
         */
        public void addNewDataPoint_1Line(double _yValue1)
        {
            // Removes points outside of the window
            while (series.ItemCount >= maxNumberPointsRealTime)
            {
                series.Remove(0);
            }

            series.Add(series.MaxX + 1, _yValue1); 	// Line 1


            // Will adjust the Y-Axis to the correct height so that the graph is always visible
            _renderer.YAxisMin = series.MinY * (1 - percentageOverLimits);
            _renderer.YAxisMax = series.MaxY * (1 + percentageOverLimits);		

        }


        /**
         * This will add a new value to the Y-Axis on each line after the last point that is on the graph.
         * The X-Axis value is incremented so that all the data points are spaced evenly.
         * 
         * This should only be used with Real Time graphs
         * 
         * @param _yValue1		Value to be added to line1
         * @param _yValue2		Value to be added to line2
         */
        public void addNewDataPoint_2Line(double _yValue1, double _yValue2)
        {
            // Removes points outside of the window
            while (series.ItemCount >= maxNumberPointsRealTime)
            {
                series.Remove(0);
            }

            // Removes points outside of the window
            while (series2.ItemCount >= maxNumberPointsRealTime)
            {
                series2.Remove(0);
            }

            series.Add(series.MaxX + 1, _yValue1);		// Line 1		
            series2.Add(series2.MaxX + 1, _yValue2);	// Line 2

            // Will adjust the Y-Axis to the correct height so that the graph is always visible
            // Since there are two lines it needs to determine which line has the most extreme values
            if (series.MinY < series2.MinY)
            {
                _renderer.YAxisMin = (series.MinY * (1 - percentageOverLimits));
            }
            else
            {
                _renderer.YAxisMin = (series2.MinY * (1 - percentageOverLimits));
            }

            if (series.MaxY > series2.MaxY)
            {
                _renderer.YAxisMax = (series.MaxY * (1 + percentageOverLimits));
            }
            else
            {
                _renderer.YAxisMax = (series2.MaxY * (1 + percentageOverLimits));
            }
        }

        /**
         * Creates a graph that is based on an array containing the data that was gathered over a period of time.
         * The graph will not update with new values.
         */
        public GraphicalView GetViewHistory(Context context, double[] dataPoints, bool realTime)
        {

            series = new TimeSeries("Line1");		// Creates a new series that will hold all the data points and names it		

            // The graph needs to know if it is real time or not so that it can determine how to handle the data
            if (realTime)
            {
                for (int i = (dataPoints.Length - maxNumberPointsRealTime); i < dataPoints.Length; i++)
                {
                    series.Add(i, dataPoints[i]);		// loops through the provided array and puts them into the series
                }
            }
            else
            {
                for (int i = 0; i < dataPoints.Length; i++)
                {
                    series.Add(i, dataPoints[i]);		// loops through the provided array and puts them into the series
                }

                // Used to reduce the size of the graph by averaging the values
                series = reduceSeries1Size(series);
            }

            // Now the series of data points needs to be added to a dataset so that it can be graphed on the XY plane
            XYMultipleSeriesDataset dataset = new XYMultipleSeriesDataset();
            dataset.AddSeries(series);

            _renderer = new XYMultipleSeriesRenderer(); // Holds a collection of XYSeriesRenderer and customizes the graph
            XYSeriesRenderer renderer = new XYSeriesRenderer(); 				 // This will be used to customize line 1


            /**
             * Sets the pan limits as an array of 4 values. Setting it to null or a different size array will disable the panning limitation.
             * Prevents the users from scrolling past these limits
             * 
             * [panMinimumX, panMaximumX, panMinimumY, panMaximumY]
             */
            _renderer.SetPanLimits(new double[] { series.MinX, series.MaxX, 0, series.MaxY });

            /**
             * Sets the margins around the graph
             * Added by Facundo 4-6-13
             */
            var displayMetrics = new DisplayMetrics();
            var display = context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            display.DefaultDisplay.GetMetrics(displayMetrics);
            switch (displayMetrics.DensityDpi)
            {
                case DisplayMetrics.DensityXhigh:
                    _renderer.LabelsTextSize = 40;
                    /* [top, left, bottom, right] */
                    _renderer.SetMargins(new int[] { 10, 160, 10, 10 });
                    break;
                case DisplayMetrics.DensityHigh:
                    _renderer.LabelsTextSize = 30;
                    /* [top, left, bottom, right] */
                    _renderer.SetMargins(new int[] { 10, 120, 10, 10 });
                    break;
                default:
                    _renderer.LabelsTextSize = 20;
                    /* [top, left, bottom, right] */
                    _renderer.SetMargins(new int[] { 10, 80, 10, 10 });
                    break;
            }

            /**
             * Sets the Y-Axis to (100 + percentageOverLimits)% of the max value. 
             * This is just done to improve the appearance of the graph
             */
            _renderer.YAxisMax = series.MaxY * (1 + percentageOverLimits);

            /**
             * Sets the Y-Axis to (100 - percentageOverLimits)% of the max value. 
             * This is just done to improve the appearance of the graph
             */
            _renderer.YAxisMin = series.MinY * (1 - percentageOverLimits);

            /**
             * Aligns the labels on the Y-Axis to be right aligned. Which appears best.
             */
            _renderer.SetYLabelsAlign(Graphics.Paint.Align.Right);

            /**
             * Removes the labels from the X-Axis
             */
            _renderer.XLabels = 0;

            /**
             * Sets the graph background color
             * 
             * Note:
             * Using Color.argb(0x00, 0x01, 0x01, 0x01) instead of Color.TRANSPARENT because of the issue with setMarginsColor.
             * I am not certain if the transparent is broken or just how it handles that but this should work in all the cases.
             */
            _renderer.BackgroundColor = Graphics.Color.Argb(0x00, 0x01, 0x01, 0x01);

            /**
             * Set the margins to transparent
             * Color.TRANSPARENT seems to produce a bug for margins
             */
            _renderer.MarginsColor = Graphics.Color.Argb(0x00, 0x01, 0x01, 0x01);

            /**
             * Used to adjust the color of the actual Axes
             */
            _renderer.AxesColor = Graphics.Color.White;

            /**
             * Adjusts the color of the labels on the Y-Axis
             */
            _renderer.SetYLabelsColor(0, Graphics.Color.White);

            /**
             * Applies the background color to the graph
             */
            _renderer.ApplyBackgroundColor = true;

            /**
             * Will hopefully clear up the text so that it is easier to read
             */
            _renderer.Antialiasing = true;

            /**
             * Allows the users to just scroll from side to side in the graph
             * [boolean enableX, boolean enableY]
             */
            _renderer.PanEnabled = false;
            _renderer.ZoomEnabled = false;

            /**
             * Will turn on and off the legend which is just an indicator telling you the name of the line and what color it is.
             */
            _renderer.ShowLegend = false;

            /**
             * Now add the line(s) to the Multi-Renderer (_renderer)
             */
            _renderer.AddSeriesRenderer(renderer);

            // Customization for line 1!
            renderer.Color = KnightTimeColor.DarkYellow;
            renderer.FillBelowLine = true;
            renderer.FillBelowLineColor = KnightTimeColor.Yellow;
            renderer.LineWidth = 3.0f;


            return ChartFactory.GetCubeLineChartView(context, dataset, _renderer, 0.33f);
        }


        /**
         * Creates a graph that is based on two arrays containing the data that was gathered over a period of time.
         * The graph will not update with new values.
         */
        public GraphicalView getViewTwoLineHistory(Context context, double[] dataPoints, double[] dataPoints2, bool realTime)
        {

            series = new TimeSeries("Line1");		// Creates a new series that will hold all the data points and names it		
            series2 = new TimeSeries("Line2");		// Creates a new series that will hold all the data points and names it

            // The graph needs to know if it is real time or not so that it can determine how to handle the data
            if (realTime)
            {

                for (int i = (dataPoints.Length - maxNumberPointsRealTime); i < dataPoints.Length; i++)
                {
                    series.Add(i, dataPoints[i]);		// loops through the provided array and puts them into the series
                }


                for (int i = (dataPoints2.Length - maxNumberPointsRealTime); i < dataPoints2.Length; i++)
                {
                    series2.Add(i, dataPoints2[i]);		// loops through the provided array and puts them into the series
                }

            }
            else
            {

                for (int i = 0; i < dataPoints.Length; i++)
                {
                    series.Add(i, dataPoints[i]);		// loops through the provided array and puts them into the series
                }


                for (int i = 0; i < dataPoints2.Length; i++)
                {
                    series2.Add(i, dataPoints2[i]);		// loops through the provided array and puts them into the series
                }

                // Used to reduce the size of the graph by averaging the values
                series = reduceSeries1Size(series);
                series2 = reduceSeries1Size(series2);
            }

            // Now the series of data points needs to be added to a dataset so that it can be graphed on the XY plane
            XYMultipleSeriesDataset dataset = new XYMultipleSeriesDataset();
            dataset.AddSeries(series);
            dataset.AddSeries(series2);


            _renderer = new XYMultipleSeriesRenderer(); // Holds a collection of XYSeriesRenderer and customizes the graph
            XYSeriesRenderer renderer = new XYSeriesRenderer(); 	// This will be used to customize line 1
            XYSeriesRenderer renderer2 = new XYSeriesRenderer(); 	// This will be used to customize line 2


            /**
             * Sets the pan limits as an array of 4 values. Setting it to null or a different size array will disable the panning limitation.
             * Prevents the users from scrolling past these limits
             * 
             * [panMinimumX, panMaximumX, panMinimumY, panMaximumY]
             */
            _renderer.SetPanLimits(new double[] { series.MinX, series.MaxX, 0, series.MaxY });

            /**
             * Sets the margins around the graph
             * 
             * [top, left, bottom, right]
             */
            _renderer.SetMargins(new int[] { 10, 30, 10, 10 });

            /**
             * Sets the Y-Axis to (100 + percentageOverLimits)% of the max value. 
             * This is just done to improve the appearance of the graph
             */
            _renderer.YAxisMax = series.MaxY * (1 + percentageOverLimits);

            /**
             * Sets the Y-Axis to (100 - percentageOverLimits)% of the max value. 
             * This is just done to improve the appearance of the graph
             */
            _renderer.YAxisMin = series.MinY * (1 - percentageOverLimits);


            /**
             * Aligns the labels on the Y-Axis to be right aligned. Which appears best.
             */
            _renderer.SetYLabelsAlign(Graphics.Paint.Align.Right);

            /**
             * Removes the labels from the X-Axis
             */
            _renderer.XLabels = 0;

            /**
             * Sets the graph background color
             * 
             * Note:
             * Using Color.argb(0x00, 0x01, 0x01, 0x01) instead of Color.TRANSPARENT because of the issue with setMarginsColor.
             * I am not certain if the transparent is broken or just how it handles that but this should work in all the cases.
             */
            _renderer.BackgroundColor = Graphics.Color.Argb(0x00, 0x01, 0x01, 0x01);

            /**
             * Set the margins to transparent
             * Color.TRANSPARENT seems to produce a bug for margins
             */
            _renderer.MarginsColor = Graphics.Color.Argb(0x00, 0x01, 0x01, 0x01);

            /**
             * Used to adjust the color of the actual Axes
             */
            _renderer.AxesColor = Graphics.Color.White;

            /**
             * Adjusts the color of the labels on the Y-Axis
             */
            _renderer.SetYLabelsColor(0, Graphics.Color.White);

            /**
             * Applies the background color to the graph
             */
            _renderer.ApplyBackgroundColor = true;

            /**
             * Will hopefully clear up the text so that it is easier to read
             */
            _renderer.Antialiasing = true;

            /**
             * Allows the users to just scroll from side to side in the graph
             * [boolean enableX, boolean enableY]
             */
            _renderer.PanEnabled = false;
            _renderer.ZoomEnabled = false;

            /**
             * Will turn on and off the legend which is just an indicator telling you the name of the line and what color it is.
             */
            _renderer.ShowLegend = false;

            /**
             * Now add the line(s) to the Multi-Renderer (_renderer)
             */
            _renderer.AddSeriesRenderer(renderer2);
            _renderer.AddSeriesRenderer(renderer);

            // Customization for line 1!
            renderer.Color = KnightTimeColor.Yellow;
            renderer.FillBelowLine = true;
            renderer.FillBelowLineColor = KnightTimeColor.DarkYellow;
            renderer.LineWidth = 3.0f;

            // Customization for line 2!
            renderer2.Color = KnightTimeColor.DarkYellow;
            renderer2.FillBelowLine = true;
            renderer2.FillBelowLineColor = KnightTimeColor.Yellow;
            renderer2.LineWidth = 3.0f;


            return ChartFactory.GetCubeLineChartView(context, dataset, _renderer, 0.33f);
        }
    }
}