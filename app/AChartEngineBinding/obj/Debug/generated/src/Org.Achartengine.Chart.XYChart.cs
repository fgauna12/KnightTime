using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/XYChart", DoNotGenerateAcw=true)]
	public abstract partial class XYChart : global::Org.Achartengine.Chart.AbstractChart {


		static IntPtr mDataset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/field[@name='mDataset']"
		[Register ("mDataset")]
		protected global::Org.Achartengine.Model.XYMultipleSeriesDataset MDataset {
			get {
				if (mDataset_jfieldId == IntPtr.Zero)
					mDataset_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataset", "Lorg/achartengine/model/XYMultipleSeriesDataset;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDataset_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDataset_jfieldId == IntPtr.Zero)
					mDataset_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataset", "Lorg/achartengine/model/XYMultipleSeriesDataset;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mDataset_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRenderer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/field[@name='mRenderer']"
		[Register ("mRenderer")]
		protected global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer MRenderer {
			get {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRenderer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mRenderer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/XYChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYChart); }
		}

		protected XYChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/constructor[@name='XYChart' and count(parameter)=2 and parameter[1][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[2][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register (".ctor", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", "")]
		public unsafe XYChart (global::Org.Achartengine.Model.XYMultipleSeriesDataset p0, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (XYChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/constructor[@name='XYChart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe XYChart ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (XYChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getChartType;
#pragma warning disable 0169
		static Delegate GetGetChartTypeHandler ()
		{
			if (cb_getChartType == null)
				cb_getChartType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartType);
			return cb_getChartType;
		}

		static IntPtr n_GetChartType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChartType);
		}
#pragma warning restore 0169

		public abstract string ChartType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getChartType' and count(parameter)=0]"
			[Register ("getChartType", "()Ljava/lang/String;", "GetGetChartTypeHandler")] get;
		}

		static Delegate cb_getDataset;
#pragma warning disable 0169
		static Delegate GetGetDatasetHandler ()
		{
			if (cb_getDataset == null)
				cb_getDataset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataset);
			return cb_getDataset;
		}

		static IntPtr n_GetDataset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dataset);
		}
#pragma warning restore 0169

		static IntPtr id_getDataset;
		public virtual unsafe global::Org.Achartengine.Model.XYMultipleSeriesDataset Dataset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getDataset' and count(parameter)=0]"
			[Register ("getDataset", "()Lorg/achartengine/model/XYMultipleSeriesDataset;", "GetGetDatasetHandler")]
			get {
				if (id_getDataset == IntPtr.Zero)
					id_getDataset = JNIEnv.GetMethodID (class_ref, "getDataset", "()Lorg/achartengine/model/XYMultipleSeriesDataset;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (JNIEnv.CallObjectMethod  (Handle, id_getDataset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataset", "()Lorg/achartengine/model/XYMultipleSeriesDataset;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultMinimum;
#pragma warning disable 0169
		static Delegate GetGetDefaultMinimumHandler ()
		{
			if (cb_getDefaultMinimum == null)
				cb_getDefaultMinimum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDefaultMinimum);
			return cb_getDefaultMinimum;
		}

		static double n_GetDefaultMinimum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultMinimum;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultMinimum;
		public virtual unsafe double DefaultMinimum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getDefaultMinimum' and count(parameter)=0]"
			[Register ("getDefaultMinimum", "()D", "GetGetDefaultMinimumHandler")]
			get {
				if (id_getDefaultMinimum == IntPtr.Zero)
					id_getDefaultMinimum = JNIEnv.GetMethodID (class_ref, "getDefaultMinimum", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getDefaultMinimum);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultMinimum", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_isRenderNullValues;
#pragma warning disable 0169
		static Delegate GetIsRenderNullValuesHandler ()
		{
			if (cb_isRenderNullValues == null)
				cb_isRenderNullValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRenderNullValues);
			return cb_isRenderNullValues;
		}

		static bool n_IsRenderNullValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRenderNullValues;
		}
#pragma warning restore 0169

		static IntPtr id_isRenderNullValues;
		protected virtual unsafe bool IsRenderNullValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='isRenderNullValues' and count(parameter)=0]"
			[Register ("isRenderNullValues", "()Z", "GetIsRenderNullValuesHandler")]
			get {
				if (id_isRenderNullValues == IntPtr.Zero)
					id_isRenderNullValues = JNIEnv.GetMethodID (class_ref, "isRenderNullValues", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isRenderNullValues);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRenderNullValues", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPointsChart;
#pragma warning disable 0169
		static Delegate GetGetPointsChartHandler ()
		{
			if (cb_getPointsChart == null)
				cb_getPointsChart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointsChart);
			return cb_getPointsChart;
		}

		static IntPtr n_GetPointsChart (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointsChart);
		}
#pragma warning restore 0169

		static IntPtr id_getPointsChart;
		public virtual unsafe global::Org.Achartengine.Chart.ScatterChart PointsChart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getPointsChart' and count(parameter)=0]"
			[Register ("getPointsChart", "()Lorg/achartengine/chart/ScatterChart;", "GetGetPointsChartHandler")]
			get {
				if (id_getPointsChart == IntPtr.Zero)
					id_getPointsChart = JNIEnv.GetMethodID (class_ref, "getPointsChart", "()Lorg/achartengine/chart/ScatterChart;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ScatterChart> (JNIEnv.CallObjectMethod  (Handle, id_getPointsChart), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ScatterChart> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointsChart", "()Lorg/achartengine/chart/ScatterChart;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRenderer;
#pragma warning disable 0169
		static Delegate GetGetRendererHandler ()
		{
			if (cb_getRenderer == null)
				cb_getRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderer);
			return cb_getRenderer;
		}

		static IntPtr n_GetRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Renderer);
		}
#pragma warning restore 0169

		static IntPtr id_getRenderer;
		public virtual unsafe global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer Renderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getRenderer' and count(parameter)=0]"
			[Register ("getRenderer", "()Lorg/achartengine/renderer/XYMultipleSeriesRenderer;", "GetGetRendererHandler")]
			get {
				if (id_getRenderer == IntPtr.Zero)
					id_getRenderer = JNIEnv.GetMethodID (class_ref, "getRenderer", "()Lorg/achartengine/renderer/XYMultipleSeriesRenderer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (JNIEnv.CallObjectMethod  (Handle, id_getRenderer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderer", "()Lorg/achartengine/renderer/XYMultipleSeriesRenderer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScreenR;
#pragma warning disable 0169
		static Delegate GetGetScreenRHandler ()
		{
			if (cb_getScreenR == null)
				cb_getScreenR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScreenR);
			return cb_getScreenR;
		}

		static IntPtr n_GetScreenR (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScreenR);
		}
#pragma warning restore 0169

		static Delegate cb_setScreenR_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetSetScreenR_Landroid_graphics_Rect_Handler ()
		{
			if (cb_setScreenR_Landroid_graphics_Rect_ == null)
				cb_setScreenR_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScreenR_Landroid_graphics_Rect_);
			return cb_setScreenR_Landroid_graphics_Rect_;
		}

		static void n_SetScreenR_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScreenR = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScreenR;
		static IntPtr id_setScreenR_Landroid_graphics_Rect_;
		protected virtual unsafe global::Android.Graphics.Rect ScreenR {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getScreenR' and count(parameter)=0]"
			[Register ("getScreenR", "()Landroid/graphics/Rect;", "GetGetScreenRHandler")]
			get {
				if (id_getScreenR == IntPtr.Zero)
					id_getScreenR = JNIEnv.GetMethodID (class_ref, "getScreenR", "()Landroid/graphics/Rect;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getScreenR), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenR", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='setScreenR' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setScreenR", "(Landroid/graphics/Rect;)V", "GetSetScreenR_Landroid_graphics_Rect_Handler")]
			set {
				if (id_setScreenR_Landroid_graphics_Rect_ == IntPtr.Zero)
					id_setScreenR_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "setScreenR", "(Landroid/graphics/Rect;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScreenR_Landroid_graphics_Rect_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScreenR", "(Landroid/graphics/Rect;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_clickableAreasForPoints_arrayFarrayDFII;
#pragma warning disable 0169
		static Delegate GetClickableAreasForPoints_arrayFarrayDFIIHandler ()
		{
			if (cb_clickableAreasForPoints_arrayFarrayDFII == null)
				cb_clickableAreasForPoints_arrayFarrayDFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, int, int, IntPtr>) n_ClickableAreasForPoints_arrayFarrayDFII);
			return cb_clickableAreasForPoints_arrayFarrayDFII;
		}

		static IntPtr n_ClickableAreasForPoints_arrayFarrayDFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3, int p4)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.ClickableAreasForPoints (p0, p1, p2, p3, p4));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='clickableAreasForPoints' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='double[]'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("clickableAreasForPoints", "([F[DFII)[Lorg/achartengine/chart/ClickableArea;", "GetClickableAreasForPoints_arrayFarrayDFIIHandler")]
		protected abstract global::Org.Achartengine.Chart.ClickableArea[] ClickableAreasForPoints (float[] p0, double[] p1, float p2, int p3, int p4);

		static Delegate cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ == null)
				cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_);
			return cb_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		}

		static void n_Draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='draw' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, int p4, global::Android.Graphics.Paint p5)
		{
			if (id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII;
#pragma warning disable 0169
		static Delegate GetDrawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFIIHandler ()
		{
			if (cb_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII == null)
				cb_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_DrawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII);
			return cb_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII;
		}

		static void n_DrawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5, int p6)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p2 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p3, JniHandleOwnership.DoNotTransfer);
			float[] p4 = (float[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawChartValuesText (p0, p1, p2, p3, p4, p5, p6);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		static IntPtr id_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawChartValuesText' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.model.XYSeries'] and parameter[3][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[4][@type='android.graphics.Paint'] and parameter[5][@type='float[]'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("drawChartValuesText", "(Landroid/graphics/Canvas;Lorg/achartengine/model/XYSeries;Lorg/achartengine/renderer/SimpleSeriesRenderer;Landroid/graphics/Paint;[FII)V", "GetDrawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFIIHandler")]
		protected virtual unsafe void DrawChartValuesText (global::Android.Graphics.Canvas p0, global::Org.Achartengine.Model.XYSeries p1, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p2, global::Android.Graphics.Paint p3, float[] p4, int p5, int p6)
		{
			if (id_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII == IntPtr.Zero)
				id_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII = JNIEnv.GetMethodID (class_ref, "drawChartValuesText", "(Landroid/graphics/Canvas;Lorg/achartengine/model/XYSeries;Lorg/achartengine/renderer/SimpleSeriesRenderer;Landroid/graphics/Paint;[FII)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawChartValuesText_Landroid_graphics_Canvas_Lorg_achartengine_model_XYSeries_Lorg_achartengine_renderer_SimpleSeriesRenderer_Landroid_graphics_Paint_arrayFII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawChartValuesText", "(Landroid/graphics/Canvas;Lorg/achartengine/model/XYSeries;Lorg/achartengine/renderer/SimpleSeriesRenderer;Landroid/graphics/Paint;[FII)V"), __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII;
#pragma warning disable 0169
		static Delegate GetDrawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FIIHandler ()
		{
			if (cb_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII == null)
				cb_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int, int>) n_DrawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII);
			return cb_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII;
		}

		static void n_DrawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, float p4, int p5, int p6)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p3 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DrawSeries (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawSeries' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='float[]'] and parameter[4][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("drawSeries", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;[FLorg/achartengine/renderer/SimpleSeriesRenderer;FII)V", "GetDrawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FIIHandler")]
		public abstract void DrawSeries (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, float[] p2, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p3, float p4, int p5, int p6);

		static Delegate cb_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I;
#pragma warning disable 0169
		static Delegate GetDrawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_IHandler ()
		{
			if (cb_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I == null)
				cb_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, int, IntPtr, int>) n_DrawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I);
			return cb_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I;
		}

		static void n_DrawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, float p5, int p6, IntPtr native_p7, int p8)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p4 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation p7 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.DrawSeries (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawSeries' and count(parameter)=9 and parameter[1][@type='org.achartengine.model.XYSeries'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='android.graphics.Paint'] and parameter[4][@type='java.util.List&lt;java.lang.Float&gt;'] and parameter[5][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='org.achartengine.renderer.XYMultipleSeriesRenderer.Orientation'] and parameter[9][@type='int']]"
		[Register ("drawSeries", "(Lorg/achartengine/model/XYSeries;Landroid/graphics/Canvas;Landroid/graphics/Paint;Ljava/util/List;Lorg/achartengine/renderer/SimpleSeriesRenderer;FILorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;I)V", "GetDrawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_IHandler")]
		protected virtual unsafe void DrawSeries (global::Org.Achartengine.Model.XYSeries p0, global::Android.Graphics.Canvas p1, global::Android.Graphics.Paint p2, global::System.Collections.Generic.IList<global::Java.Lang.Float> p3, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p4, float p5, int p6, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer.Orientation p7, int p8)
		{
			if (id_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I == IntPtr.Zero)
				id_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I = JNIEnv.GetMethodID (class_ref, "drawSeries", "(Lorg/achartengine/model/XYSeries;Landroid/graphics/Canvas;Landroid/graphics/Paint;Ljava/util/List;Lorg/achartengine/renderer/SimpleSeriesRenderer;FILorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;I)V");
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawSeries_Lorg_achartengine_model_XYSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_Ljava_util_List_Lorg_achartengine_renderer_SimpleSeriesRenderer_FILorg_achartengine_renderer_XYMultipleSeriesRenderer_Orientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawSeries", "(Lorg/achartengine/model/XYSeries;Landroid/graphics/Canvas;Landroid/graphics/Paint;Ljava/util/List;Lorg/achartengine/renderer/SimpleSeriesRenderer;FILorg/achartengine/renderer/XYMultipleSeriesRenderer$Orientation;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F;
#pragma warning disable 0169
		static Delegate GetDrawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_FHandler ()
		{
			if (cb_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F == null)
				cb_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr, float>) n_DrawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F);
			return cb_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F;
		}

		static void n_DrawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, IntPtr native_p4, float p5)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DrawText (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawText' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.Paint'] and parameter[6][@type='float']]"
		[Register ("drawText", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;F)V", "GetDrawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_FHandler")]
		protected virtual unsafe void DrawText (global::Android.Graphics.Canvas p0, string p1, float p2, float p3, global::Android.Graphics.Paint p4, float p5)
		{
			if (id_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F == IntPtr.Zero)
				id_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F = JNIEnv.GetMethodID (class_ref, "drawText", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;F)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawText_Landroid_graphics_Canvas_Ljava_lang_String_FFLandroid_graphics_Paint_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawText", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD;
#pragma warning disable 0169
		static Delegate GetDrawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDDHandler ()
		{
			if (cb_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD == null)
				cb_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, double, double, double>) n_DrawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD);
			return cb_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD;
		}

		static void n_DrawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, int p6, double p7, double p8, double p9)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double[] p1 = (global::Java.Lang.Double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Double));
			global::Android.Graphics.Canvas p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DrawXLabels (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawXLabels' and count(parameter)=10 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;'] and parameter[2][@type='java.lang.Double[]'] and parameter[3][@type='android.graphics.Canvas'] and parameter[4][@type='android.graphics.Paint'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='double'] and parameter[9][@type='double'] and parameter[10][@type='double']]"
		[Register ("drawXLabels", "(Ljava/util/List;[Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIDDD)V", "GetDrawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDDHandler")]
		protected virtual unsafe void DrawXLabels (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0, global::Java.Lang.Double[] p1, global::Android.Graphics.Canvas p2, global::Android.Graphics.Paint p3, int p4, int p5, int p6, double p7, double p8, double p9)
		{
			if (id_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD == IntPtr.Zero)
				id_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD = JNIEnv.GetMethodID (class_ref, "drawXLabels", "(Ljava/util/List;[Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIDDD)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawXLabels_Ljava_util_List_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIDDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawXLabels", "(Ljava/util/List;[Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIDDD)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD;
#pragma warning disable 0169
		static Delegate GetDrawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDDHandler ()
		{
			if (cb_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD == null)
				cb_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, int, int, int, double, double, double>) n_DrawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD);
			return cb_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD;
		}

		static void n_DrawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, int p4, int p5, int p6, double p7, double p8, double p9)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double[] p0 = (global::Java.Lang.Double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Double));
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DrawXTextLabels (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawXTextLabels' and count(parameter)=10 and parameter[1][@type='java.lang.Double[]'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='android.graphics.Paint'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='double'] and parameter[9][@type='double'] and parameter[10][@type='double']]"
		[Register ("drawXTextLabels", "([Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;ZIIIDDD)V", "GetDrawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDDHandler")]
		protected virtual unsafe void DrawXTextLabels (global::Java.Lang.Double[] p0, global::Android.Graphics.Canvas p1, global::Android.Graphics.Paint p2, bool p3, int p4, int p5, int p6, double p7, double p8, double p9)
		{
			if (id_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD == IntPtr.Zero)
				id_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD = JNIEnv.GetMethodID (class_ref, "drawXTextLabels", "([Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;ZIIIDDD)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawXTextLabels_arrayLjava_lang_Double_Landroid_graphics_Canvas_Landroid_graphics_Paint_ZIIIDDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawXTextLabels", "([Ljava/lang/Double;Landroid/graphics/Canvas;Landroid/graphics/Paint;ZIIIDDD)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD;
#pragma warning disable 0169
		static Delegate GetDrawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayDHandler ()
		{
			if (cb_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD == null)
				cb_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr, IntPtr>) n_DrawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD);
			return cb_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD;
		}

		static void n_DrawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5, int p6, IntPtr native_p7, IntPtr native_p8)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p2, JniHandleOwnership.DoNotTransfer);
			double[] p7 = (double[]) JNIEnv.GetArray (native_p7, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p8 = (double[]) JNIEnv.GetArray (native_p8, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.DrawYLabels (p0, p1, p2, p3, p4, p5, p6, p7, p8);
			if (p7 != null)
				JNIEnv.CopyArray (p7, native_p7);
			if (p8 != null)
				JNIEnv.CopyArray (p8, native_p8);
		}
#pragma warning restore 0169

		static IntPtr id_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawYLabels' and count(parameter)=9 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.util.List&lt;java.lang.Double&gt;&gt;'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='android.graphics.Paint'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='double[]'] and parameter[9][@type='double[]']]"
		[Register ("drawYLabels", "(Ljava/util/Map;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIII[D[D)V", "GetDrawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayDHandler")]
		protected virtual unsafe void DrawYLabels (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>> p0, global::Android.Graphics.Canvas p1, global::Android.Graphics.Paint p2, int p3, int p4, int p5, int p6, double[] p7, double[] p8)
		{
			if (id_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD == IntPtr.Zero)
				id_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD = JNIEnv.GetMethodID (class_ref, "drawYLabels", "(Ljava/util/Map;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIII[D[D)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>>.ToLocalJniHandle (p0);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			IntPtr native_p8 = JNIEnv.NewArray (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawYLabels_Ljava_util_Map_Landroid_graphics_Canvas_Landroid_graphics_Paint_IIIIarrayDarrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawYLabels", "(Ljava/util/Map;Landroid/graphics/Canvas;Landroid/graphics/Paint;IIII[D[D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
				if (p8 != null) {
					JNIEnv.CopyArray (native_p8, p8);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}
		}

		static Delegate cb_getCalcRange_I;
#pragma warning disable 0169
		static Delegate GetGetCalcRange_IHandler ()
		{
			if (cb_getCalcRange_I == null)
				cb_getCalcRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetCalcRange_I);
			return cb_getCalcRange_I;
		}

		static IntPtr n_GetCalcRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCalcRange (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCalcRange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getCalcRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCalcRange", "(I)[D", "GetGetCalcRange_IHandler")]
		public virtual unsafe double[] GetCalcRange (int p0)
		{
			if (id_getCalcRange_I == IntPtr.Zero)
				id_getCalcRange_I = JNIEnv.GetMethodID (class_ref, "getCalcRange", "(I)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getCalcRange_I, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalcRange", "(I)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getLabel_D;
#pragma warning disable 0169
		static Delegate GetGetLabel_DHandler ()
		{
			if (cb_getLabel_D == null)
				cb_getLabel_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_GetLabel_D);
			return cb_getLabel_D;
		}

		static IntPtr n_GetLabel_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLabel (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getLabel_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getLabel' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("getLabel", "(D)Ljava/lang/String;", "GetGetLabel_DHandler")]
		protected virtual unsafe string GetLabel (double p0)
		{
			if (id_getLabel_D == IntPtr.Zero)
				id_getLabel_D = JNIEnv.GetMethodID (class_ref, "getLabel", "(D)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLabel_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "(D)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getXLabels_DDI;
#pragma warning disable 0169
		static Delegate GetGetXLabels_DDIHandler ()
		{
			if (cb_getXLabels_DDI == null)
				cb_getXLabels_DDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, int, IntPtr>) n_GetXLabels_DDI);
			return cb_getXLabels_DDI;
		}

		static IntPtr n_GetXLabels_DDI (IntPtr jnienv, IntPtr native__this, double p0, double p1, int p2)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (__this.GetXLabels (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_getXLabels_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getXLabels' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("getXLabels", "(DDI)Ljava/util/List;", "GetGetXLabels_DDIHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> GetXLabels (double p0, double p1, int p2)
		{
			if (id_getXLabels_DDI == IntPtr.Zero)
				id_getXLabels_DDI = JNIEnv.GetMethodID (class_ref, "getXLabels", "(DDI)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getXLabels_DDI, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXLabels", "(DDI)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getYLabels_arrayDarrayDI;
#pragma warning disable 0169
		static Delegate GetGetYLabels_arrayDarrayDIHandler ()
		{
			if (cb_getYLabels_arrayDarrayDI == null)
				cb_getYLabels_arrayDarrayDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetYLabels_arrayDarrayDI);
			return cb_getYLabels_arrayDarrayDI;
		}

		static IntPtr n_GetYLabels_arrayDarrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>>.ToLocalJniHandle (__this.GetYLabels (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getYLabels_arrayDarrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getYLabels' and count(parameter)=3 and parameter[1][@type='double[]'] and parameter[2][@type='double[]'] and parameter[3][@type='int']]"
		[Register ("getYLabels", "([D[DI)Ljava/util/Map;", "GetGetYLabels_arrayDarrayDIHandler")]
		protected virtual unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>> GetYLabels (double[] p0, double[] p1, int p2)
		{
			if (id_getYLabels_arrayDarrayDI == IntPtr.Zero)
				id_getYLabels_arrayDarrayDI = JNIEnv.GetMethodID (class_ref, "getYLabels", "([D[DI)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>> __ret;
				if (GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getYLabels_arrayDarrayDI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::System.Collections.Generic.IList<global::Java.Lang.Double>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYLabels", "([D[DI)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
#pragma warning disable 0169
		static Delegate GetIsRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler ()
		{
			if (cb_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == null)
				cb_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_);
			return cb_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		}

		static bool n_IsRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRenderPoints (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='isRenderPoints' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.SimpleSeriesRenderer']]"
		[Register ("isRenderPoints", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)Z", "GetIsRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler")]
		public virtual unsafe bool IsRenderPoints (global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0)
		{
			if (id_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == IntPtr.Zero)
				id_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "isRenderPoints", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isRenderPoints_Lorg_achartengine_renderer_SimpleSeriesRenderer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRenderPoints", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setCalcRange_arrayDI;
#pragma warning disable 0169
		static Delegate GetSetCalcRange_arrayDIHandler ()
		{
			if (cb_setCalcRange_arrayDI == null)
				cb_setCalcRange_arrayDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetCalcRange_arrayDI);
			return cb_setCalcRange_arrayDI;
		}

		static void n_SetCalcRange_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.SetCalcRange (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCalcRange_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='setCalcRange' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("setCalcRange", "([DI)V", "GetSetCalcRange_arrayDIHandler")]
		public virtual unsafe void SetCalcRange (double[] p0, int p1)
		{
			if (id_setCalcRange_arrayDI == IntPtr.Zero)
				id_setCalcRange_arrayDI = JNIEnv.GetMethodID (class_ref, "setCalcRange", "([DI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCalcRange_arrayDI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalcRange", "([DI)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
#pragma warning disable 0169
		static Delegate GetSetDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Handler ()
		{
			if (cb_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == null)
				cb_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_);
			return cb_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		}

		static void n_SetDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYMultipleSeriesDataset p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDatasetRenderer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='setDatasetRenderer' and count(parameter)=2 and parameter[1][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[2][@type='org.achartengine.renderer.XYMultipleSeriesRenderer']]"
		[Register ("setDatasetRenderer", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", "GetSetDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Handler")]
		protected virtual unsafe void SetDatasetRenderer (global::Org.Achartengine.Model.XYMultipleSeriesDataset p0, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1)
		{
			if (id_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "setDatasetRenderer", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDatasetRenderer_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDatasetRenderer", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toRealPoint_FF;
#pragma warning disable 0169
		static Delegate GetToRealPoint_FFHandler ()
		{
			if (cb_toRealPoint_FF == null)
				cb_toRealPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_ToRealPoint_FF);
			return cb_toRealPoint_FF;
		}

		static IntPtr n_ToRealPoint_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToRealPoint (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_toRealPoint_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='toRealPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("toRealPoint", "(FF)[D", "GetToRealPoint_FFHandler")]
		public virtual unsafe double[] ToRealPoint (float p0, float p1)
		{
			if (id_toRealPoint_FF == IntPtr.Zero)
				id_toRealPoint_FF = JNIEnv.GetMethodID (class_ref, "toRealPoint", "(FF)[D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toRealPoint_FF, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRealPoint", "(FF)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_toRealPoint_FFI;
#pragma warning disable 0169
		static Delegate GetToRealPoint_FFIHandler ()
		{
			if (cb_toRealPoint_FFI == null)
				cb_toRealPoint_FFI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int, IntPtr>) n_ToRealPoint_FFI);
			return cb_toRealPoint_FFI;
		}

		static IntPtr n_ToRealPoint_FFI (IntPtr jnienv, IntPtr native__this, float p0, float p1, int p2)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToRealPoint (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_toRealPoint_FFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='toRealPoint' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("toRealPoint", "(FFI)[D", "GetToRealPoint_FFIHandler")]
		public virtual unsafe double[] ToRealPoint (float p0, float p1, int p2)
		{
			if (id_toRealPoint_FFI == IntPtr.Zero)
				id_toRealPoint_FFI = JNIEnv.GetMethodID (class_ref, "toRealPoint", "(FFI)[D");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toRealPoint_FFI, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRealPoint", "(FFI)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_toScreenPoint_arrayD;
#pragma warning disable 0169
		static Delegate GetToScreenPoint_arrayDHandler ()
		{
			if (cb_toScreenPoint_arrayD == null)
				cb_toScreenPoint_arrayD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToScreenPoint_arrayD);
			return cb_toScreenPoint_arrayD;
		}

		static IntPtr n_ToScreenPoint_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.ToScreenPoint (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toScreenPoint_arrayD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='toScreenPoint' and count(parameter)=1 and parameter[1][@type='double[]']]"
		[Register ("toScreenPoint", "([D)[D", "GetToScreenPoint_arrayDHandler")]
		public virtual unsafe double[] ToScreenPoint (double[] p0)
		{
			if (id_toScreenPoint_arrayD == IntPtr.Zero)
				id_toScreenPoint_arrayD = JNIEnv.GetMethodID (class_ref, "toScreenPoint", "([D)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toScreenPoint_arrayD, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toScreenPoint", "([D)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_toScreenPoint_arrayDI;
#pragma warning disable 0169
		static Delegate GetToScreenPoint_arrayDIHandler ()
		{
			if (cb_toScreenPoint_arrayDI == null)
				cb_toScreenPoint_arrayDI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_ToScreenPoint_arrayDI);
			return cb_toScreenPoint_arrayDI;
		}

		static IntPtr n_ToScreenPoint_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Chart.XYChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.XYChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			IntPtr __ret = JNIEnv.NewArray (__this.ToScreenPoint (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toScreenPoint_arrayDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='toScreenPoint' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='int']]"
		[Register ("toScreenPoint", "([DI)[D", "GetToScreenPoint_arrayDIHandler")]
		public virtual unsafe double[] ToScreenPoint (double[] p0, int p1)
		{
			if (id_toScreenPoint_arrayDI == IntPtr.Zero)
				id_toScreenPoint_arrayDI = JNIEnv.GetMethodID (class_ref, "toScreenPoint", "([DI)[D");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				double[] __ret;
				if (GetType () == ThresholdType)
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toScreenPoint_arrayDI, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					__ret = (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toScreenPoint", "([DI)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/achartengine/chart/XYChart", DoNotGenerateAcw=true)]
	internal partial class XYChartInvoker : XYChart {

		public XYChartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYChartInvoker); }
		}

		static IntPtr id_getChartType;
		public override unsafe string ChartType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='getChartType' and count(parameter)=0]"
			[Register ("getChartType", "()Ljava/lang/String;", "GetGetChartTypeHandler")]
			get {
				if (id_getChartType == IntPtr.Zero)
					id_getChartType = JNIEnv.GetMethodID (class_ref, "getChartType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getChartType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clickableAreasForPoints_arrayFarrayDFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='clickableAreasForPoints' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='double[]'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("clickableAreasForPoints", "([F[DFII)[Lorg/achartengine/chart/ClickableArea;", "GetClickableAreasForPoints_arrayFarrayDFIIHandler")]
		protected override unsafe global::Org.Achartengine.Chart.ClickableArea[] ClickableAreasForPoints (float[] p0, double[] p1, float p2, int p3, int p4)
		{
			if (id_clickableAreasForPoints_arrayFarrayDFII == IntPtr.Zero)
				id_clickableAreasForPoints_arrayFarrayDFII = JNIEnv.GetMethodID (class_ref, "clickableAreasForPoints", "([F[DFII)[Lorg/achartengine/chart/ClickableArea;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Achartengine.Chart.ClickableArea[] __ret = (global::Org.Achartengine.Chart.ClickableArea[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_clickableAreasForPoints_arrayFarrayDFII, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Chart.ClickableArea));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='XYChart']/method[@name='drawSeries' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='float[]'] and parameter[4][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("drawSeries", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;[FLorg/achartengine/renderer/SimpleSeriesRenderer;FII)V", "GetDrawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FIIHandler")]
		public override unsafe void DrawSeries (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1, float[] p2, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p3, float p4, int p5, int p6)
		{
			if (id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII == IntPtr.Zero)
				id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII = JNIEnv.GetMethodID (class_ref, "drawSeries", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;[FLorg/achartengine/renderer/SimpleSeriesRenderer;FII)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallVoidMethod  (Handle, id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='drawLegendShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V", "GetDrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_Handler")]
		public override unsafe void DrawLegendShape (global::Android.Graphics.Canvas p0, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1, float p2, float p3, int p4, global::Android.Graphics.Paint p5)
		{
			if (id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod  (Handle, id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_, __args);
			} finally {
			}
		}

		static IntPtr id_getLegendShapeWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='getLegendShapeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLegendShapeWidth", "(I)I", "GetGetLegendShapeWidth_IHandler")]
		public override unsafe int GetLegendShapeWidth (int p0)
		{
			if (id_getLegendShapeWidth_I == IntPtr.Zero)
				id_getLegendShapeWidth_I = JNIEnv.GetMethodID (class_ref, "getLegendShapeWidth", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod  (Handle, id_getLegendShapeWidth_I, __args);
			} finally {
			}
		}

	}

}
