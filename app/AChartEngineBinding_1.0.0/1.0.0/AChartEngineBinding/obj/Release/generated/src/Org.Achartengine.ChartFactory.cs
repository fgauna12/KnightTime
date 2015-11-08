using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine {

	[global::Android.Runtime.Register ("org/achartengine/ChartFactory", DoNotGenerateAcw=true)]
	public partial class ChartFactory : global::Java.Lang.Object {


		[Register ("CHART")]
		public const string Chart = (string) "chart";

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
		[Register ("getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_;
		[Register ("getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3, string p4)
		{
			if (id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ == IntPtr.Zero)
				id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		[Register ("getBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetBarChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetBubbleChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		[Register ("getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetBubbleChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getBubbleChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetBubbleChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getBubbleChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBubbleChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_;
		[Register ("getCombinedXYChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetCombinedXYChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string[] p3, string p4)
		{
			if (id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCombinedXYChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCombinedXYChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_;
		[Register ("getCombinedXYChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetCombinedXYChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string[] p3)
		{
			if (id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCombinedXYChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;[Ljava/lang/String;)Lorg/achartengine/GraphicalView;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCombinedXYChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_arrayLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static IntPtr id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F;
		[Register ("getCubeLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetCubeLineChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3)
		{
			if (id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F == IntPtr.Zero)
				id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F = JNIEnv.GetStaticMethodID (class_ref, "getCubeLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubeLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F;
		[Register ("getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetCubicLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3)
		{
			if (id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F == IntPtr.Zero)
				id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F = JNIEnv.GetStaticMethodID (class_ref, "getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;F)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_F, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_;
		[Register ("getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;FLjava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetCubicLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, float p3, string p4)
		{
			if (id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_ == IntPtr.Zero)
				id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCubicLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;FLjava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCubicLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_FLjava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_;
		[Register ("getDialChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetDialChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DialRenderer p2, string p3)
		{
			if (id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDialChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDialChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_;
		[Register ("getDialChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetDialChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DialRenderer p2)
		{
			if (id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ == IntPtr.Zero)
				id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getDialChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDialChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_;
		[Register ("getDoughnutChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetDoughnutChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.MultipleCategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2, string p3)
		{
			if (id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDoughnutChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoughnutChartIntent_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_;
		[Register ("getDoughnutChartView", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetDoughnutChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.MultipleCategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2)
		{
			if (id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
				id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getDoughnutChartView", "(Landroid/content/Context;Lorg/achartengine/model/MultipleCategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoughnutChartView_Landroid_content_Context_Lorg_achartengine_model_MultipleCategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		[Register ("getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetLineChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetLineChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getLineChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLineChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_;
		[Register ("getPieChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetPieChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2, string p3)
		{
			if (id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPieChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPieChartIntent_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_;
		[Register ("getPieChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetPieChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.CategorySeries p1, global::Org.Achartengine.Renderer.DefaultRenderer p2)
		{
			if (id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
				id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getPieChartView", "(Landroid/content/Context;Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPieChartView_Landroid_content_Context_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_;
		[Register ("getRangeBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetRangeBarChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3, string p4)
		{
			if (id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ == IntPtr.Zero)
				id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRangeBarChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRangeBarChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		[Register ("getRangeBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetRangeBarChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, global::Org.Achartengine.Chart.BarChart.Type p3)
		{
			if (id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
				id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getRangeBarChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRangeBarChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetScatterChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		[Register ("getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetScatterChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register ("getScatterChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetScatterChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2)
		{
			if (id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetStaticMethodID (class_ref, "getScatterChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)Lorg/achartengine/GraphicalView;");
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getScatterChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		[Register ("getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetTimeChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_;
		[Register ("getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public static global::Android.Content.Intent GetTimeChartIntent (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3, string p4)
		{
			if (id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartIntent", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartIntent_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_;
		[Register ("getTimeChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Lorg/achartengine/GraphicalView;", "")]
		public static global::Org.Achartengine.GraphicalView GetTimeChartView (global::Android.Content.Context p0, global::Org.Achartengine.Model.XYMultipleSeriesDataset p1, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p2, string p3)
		{
			if (id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ == IntPtr.Zero)
				id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeChartView", "(Landroid/content/Context;Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Ljava/lang/String;)Lorg/achartengine/GraphicalView;");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Org.Achartengine.GraphicalView __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeChartView_Landroid_content_Context_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Ljava_lang_String_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

	}
}
