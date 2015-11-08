using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']"
	[global::Android.Runtime.Register ("org/achartengine/ChartFactory", DoNotGenerateAcw=true)]
	public partial class ChartFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/field[@name='CHART']"
		[Register ("CHART")]
		public const string Chart = (string) "chart";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/field[@name='TITLE']"
		[Register ("TITLE")]
		public const string Title = (string) "title";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/ChartFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChartFactory); }
		}

		protected ChartFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBarChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='org.achartengine.chart.BarChart.Type']]"
		[Register ("getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBarChartIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='org.achartengine.chart.BarChart.Type'] and parameter[5][@type='java.lang.String']]"
		[Register ("getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3, string p4)
		{
			if (id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ == IntPtr.Zero)
				id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBarChartView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='org.achartengine.chart.BarChart.Type']]"
		[Register ("getBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetBarChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBubbleChartIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetBubbleChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBubbleChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetBubbleChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getBubbleChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getBubbleChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetBubbleChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getCombinedXYChartIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String']]"
		[Register ("getCombinedXYChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetCombinedXYChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string[] p3, string p4)
		{
			if (id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCombinedXYChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getCombinedXYChartView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("getCombinedXYChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetCombinedXYChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string[] p3)
		{
			if (id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCombinedXYChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;)Lorg/achartengine/GraphicalView;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getCubeLineChartView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='float']]"
		[Register ("getCubeLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetCubeLineChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3)
		{
			if (id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F == IntPtr.Zero)
				id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F = JNIEnv.GetStaticMethodID (class_ref, "getCubeLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getCubicLineChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='float']]"
		[Register ("getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetCubicLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3)
		{
			if (id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F == IntPtr.Zero)
				id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F = JNIEnv.GetStaticMethodID (class_ref, "getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getCubicLineChartIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='float'] and parameter[5][@type='java.lang.String']]"
		[Register ("getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;FLjava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetCubicLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3, string p4)
		{
			if (id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_ == IntPtr.Zero)
				id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;FLjava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getDialChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.CategorySeries'] and parameter[3][@type='org.achartengine.renderer.DialRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getDialChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetDialChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DialRenderer p2, string p3)
		{
			if (id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDialChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getDialChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.CategorySeries'] and parameter[3][@type='org.achartengine.renderer.DialRenderer']]"
		[Register ("getDialChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetDialChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DialRenderer p2)
		{
			if (id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ == IntPtr.Zero)
				id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getDialChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getDoughnutChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.MultipleCategorySeries'] and parameter[3][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getDoughnutChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetDoughnutChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.MultipleCategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2, string p3)
		{
			if (id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDoughnutChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getDoughnutChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.MultipleCategorySeries'] and parameter[3][@type='org.achartengine.renderer.DefaultRenderer']]"
		[Register ("getDoughnutChartView", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetDoughnutChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.MultipleCategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2)
		{
			if (id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
				id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getDoughnutChartView", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getLineChartIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getLineChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getLineChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetLineChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getPieChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.CategorySeries'] and parameter[3][@type='org.achartengine.renderer.DefaultRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getPieChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetPieChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2, string p3)
		{
			if (id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPieChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getPieChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.CategorySeries'] and parameter[3][@type='org.achartengine.renderer.DefaultRenderer']]"
		[Register ("getPieChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetPieChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2)
		{
			if (id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
				id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getPieChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getRangeBarChartIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='org.achartengine.chart.BarChart.Type'] and parameter[5][@type='java.lang.String']]"
		[Register ("getRangeBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetRangeBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3, string p4)
		{
			if (id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ == IntPtr.Zero)
				id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRangeBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getRangeBarChartView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='org.achartengine.chart.BarChart.Type']]"
		[Register ("getRangeBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetRangeBarChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getRangeBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getScatterChartIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetScatterChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getScatterChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetScatterChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getScatterChartView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("getScatterChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetScatterChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getTimeChartIntent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetTimeChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getTimeChartIntent' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent GetTimeChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3, string p4)
		{
			if (id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/class[@name='ChartFactory']/method[@name='getTimeChartView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[3][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[4][@type='java.lang.String']]"
		[Register ("getTimeChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Lorg/achartengine/GraphicalView;", "")]
		public static unsafe global::Org.Achartengine.GraphicalView GetTimeChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Lorg/achartengine/GraphicalView;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
