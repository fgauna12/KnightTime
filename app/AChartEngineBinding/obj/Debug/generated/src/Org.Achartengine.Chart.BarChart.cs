using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/BarChart", DoNotGenerateAcw=true)]
	public partial class BarChart : global::Org.Achartengine.Chart.XYChart {


		static IntPtr mType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/field[@name='mType']"
		[Register ("mType")]
		protected global::Org.Achartengine.Chart.BarChart.Type MType {
			get {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lorg/achartengine/chart/BarChart$Type;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart.Type> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Lorg/achartengine/chart/BarChart$Type;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart.Type']"
		[global::Android.Runtime.Register ("org/achartengine/chart/BarChart$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart.Type']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Org.Achartengine.Chart.BarChart.Type Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lorg/achartengine/chart/BarChart$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STACKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart.Type']/field[@name='STACKED']"
			[Register ("STACKED")]
			public static global::Org.Achartengine.Chart.BarChart.Type Stacked {
				get {
					if (STACKED_jfieldId == IntPtr.Zero)
						STACKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STACKED", "Lorg/achartengine/chart/BarChart$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STACKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/achartengine/chart/BarChart$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/chart/BarChart$Type;", "")]
			public static unsafe global::Org.Achartengine.Chart.BarChart.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/chart/BarChart$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Achartengine.Chart.BarChart.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/achartengine/chart/BarChart$Type;", "")]
			public static unsafe global::Org.Achartengine.Chart.BarChart.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/chart/BarChart$Type;");
				try {
					return (global::Org.Achartengine.Chart.BarChart.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Chart.BarChart.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/BarChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BarChart); }
		}

		protected BarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/constructor[@name='BarChart' and count(parameter)=3 and parameter[1][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[2][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[3][@type='org.achartengine.chart.BarChart.Type']]"
		[Register (".ctor", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", "")]
		public unsafe BarChart (global::Org.Achartengine.Model.XYMultipleSeriesDataset p0, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1, global::Org.Achartengine.Chart.BarChart.Type p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BarChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args);
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
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChartType);
		}
#pragma warning restore 0169

		static IntPtr id_getChartType;
		public override unsafe string ChartType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='getChartType' and count(parameter)=0]"
			[Register ("getChartType", "()Ljava/lang/String;", "GetGetChartTypeHandler")]
			get {
				if (id_getChartType == IntPtr.Zero)
					id_getChartType = JNIEnv.GetMethodID (class_ref, "getChartType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getChartType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChartType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCoeficient;
#pragma warning disable 0169
		static Delegate GetGetCoeficientHandler ()
		{
			if (cb_getCoeficient == null)
				cb_getCoeficient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCoeficient);
			return cb_getCoeficient;
		}

		static float n_GetCoeficient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Coeficient;
		}
#pragma warning restore 0169

		static IntPtr id_getCoeficient;
		protected virtual unsafe float Coeficient {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='getCoeficient' and count(parameter)=0]"
			[Register ("getCoeficient", "()F", "GetGetCoeficientHandler")]
			get {
				if (id_getCoeficient == IntPtr.Zero)
					id_getCoeficient = JNIEnv.GetMethodID (class_ref, "getCoeficient", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getCoeficient);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCoeficient", "()F"));
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
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static IntPtr id_clickableAreasForPoints_arrayFarrayDFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='clickableAreasForPoints' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='double[]'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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

				global::Org.Achartengine.Chart.ClickableArea[] __ret;
				if (GetType () == ThresholdType)
					__ret = (global::Org.Achartengine.Chart.ClickableArea[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_clickableAreasForPoints_arrayFarrayDFII, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Chart.ClickableArea));
				else
					__ret = (global::Org.Achartengine.Chart.ClickableArea[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clickableAreasForPoints", "([F[DFII)[Lorg/achartengine/chart/ClickableArea;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Chart.ClickableArea));
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

		static Delegate cb_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_Handler ()
		{
			if (cb_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_ == null)
				cb_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, float, float, float, int, int, IntPtr>) n_DrawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_);
			return cb_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_;
		}

		static void n_DrawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2, float p3, float p4, float p5, int p6, int p7, IntPtr native_p8)
		{
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p8 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.DrawBar (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		static IntPtr id_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='drawBar' and count(parameter)=9 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='android.graphics.Paint']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;FFFFFIILandroid/graphics/Paint;)V", "GetDrawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_Handler")]
		protected virtual unsafe void DrawBar (global::Android.Graphics.Canvas p0, float p1, float p2, float p3, float p4, float p5, int p6, int p7, global::Android.Graphics.Paint p8)
		{
			if (id_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawBar", "(Landroid/graphics/Canvas;FFFFFIILandroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawBar_Landroid_graphics_Canvas_FFFFFIILandroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawBar", "(Landroid/graphics/Canvas;FFFFFIILandroid/graphics/Paint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_Handler ()
		{
			if (cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ == null)
				cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, int, IntPtr>) n_DrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_);
			return cb_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		}

		static void n_DrawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, int p4, IntPtr native_p5)
		{
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.DrawLegendShape (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='drawLegendShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawLegendShape", "(Landroid/graphics/Canvas;Lorg/achartengine/renderer/SimpleSeriesRenderer;FFILandroid/graphics/Paint;)V"), __args);
			} finally {
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
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p3 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DrawSeries (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='drawSeries' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint'] and parameter[3][@type='float[]'] and parameter[4][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawSeries_Landroid_graphics_Canvas_Landroid_graphics_Paint_arrayFLorg_achartengine_renderer_SimpleSeriesRenderer_FII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawSeries", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;[FLorg/achartengine/renderer/SimpleSeriesRenderer;FII)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getHalfDiffX_arrayFII;
#pragma warning disable 0169
		static Delegate GetGetHalfDiffX_arrayFIIHandler ()
		{
			if (cb_getHalfDiffX_arrayFII == null)
				cb_getHalfDiffX_arrayFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, float>) n_GetHalfDiffX_arrayFII);
			return cb_getHalfDiffX_arrayFII;
		}

		static float n_GetHalfDiffX_arrayFII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			float __ret = __this.GetHalfDiffX (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHalfDiffX_arrayFII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='getHalfDiffX' and count(parameter)=3 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getHalfDiffX", "([FII)F", "GetGetHalfDiffX_arrayFIIHandler")]
		protected virtual unsafe float GetHalfDiffX (float[] p0, int p1, int p2)
		{
			if (id_getHalfDiffX_arrayFII == IntPtr.Zero)
				id_getHalfDiffX_arrayFII = JNIEnv.GetMethodID (class_ref, "getHalfDiffX", "([FII)F");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				float __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod  (Handle, id_getHalfDiffX_arrayFII, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHalfDiffX", "([FII)F"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getLegendShapeWidth_I;
#pragma warning disable 0169
		static Delegate GetGetLegendShapeWidth_IHandler ()
		{
			if (cb_getLegendShapeWidth_I == null)
				cb_getLegendShapeWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetLegendShapeWidth_I);
			return cb_getLegendShapeWidth_I;
		}

		static int n_GetLegendShapeWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.BarChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLegendShapeWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getLegendShapeWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='BarChart']/method[@name='getLegendShapeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLegendShapeWidth", "(I)I", "GetGetLegendShapeWidth_IHandler")]
		public override unsafe int GetLegendShapeWidth (int p0)
		{
			if (id_getLegendShapeWidth_I == IntPtr.Zero)
				id_getLegendShapeWidth_I = JNIEnv.GetMethodID (class_ref, "getLegendShapeWidth", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLegendShapeWidth_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLegendShapeWidth", "(I)I"), __args);
			} finally {
			}
		}

	}
}
