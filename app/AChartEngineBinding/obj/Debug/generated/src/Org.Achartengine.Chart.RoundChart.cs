using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/RoundChart", DoNotGenerateAcw=true)]
	public abstract partial class RoundChart : global::Org.Achartengine.Chart.AbstractChart {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='NO_VALUE']"
		[Register ("NO_VALUE")]
		protected const int NoValue = (int) 2147483647;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='SHAPE_WIDTH']"
		[Register ("SHAPE_WIDTH")]
		protected const int ShapeWidth = (int) 10;

		static IntPtr mCenterX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='mCenterX']"
		[Register ("mCenterX")]
		protected int MCenterX {
			get {
				if (mCenterX_jfieldId == IntPtr.Zero)
					mCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterX", "I");
				return JNIEnv.GetIntField (Handle, mCenterX_jfieldId);
			}
			set {
				if (mCenterX_jfieldId == IntPtr.Zero)
					mCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterX", "I");
				try {
					JNIEnv.SetField (Handle, mCenterX_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCenterY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='mCenterY']"
		[Register ("mCenterY")]
		protected int MCenterY {
			get {
				if (mCenterY_jfieldId == IntPtr.Zero)
					mCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterY", "I");
				return JNIEnv.GetIntField (Handle, mCenterY_jfieldId);
			}
			set {
				if (mCenterY_jfieldId == IntPtr.Zero)
					mCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterY", "I");
				try {
					JNIEnv.SetField (Handle, mCenterY_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mDataset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='mDataset']"
		[Register ("mDataset")]
		protected global::Org.Achartengine.Model.CategorySeries MDataset {
			get {
				if (mDataset_jfieldId == IntPtr.Zero)
					mDataset_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataset", "Lorg/achartengine/model/CategorySeries;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDataset_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDataset_jfieldId == IntPtr.Zero)
					mDataset_jfieldId = JNIEnv.GetFieldID (class_ref, "mDataset", "Lorg/achartengine/model/CategorySeries;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mDataset_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRenderer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/field[@name='mRenderer']"
		[Register ("mRenderer")]
		protected global::Org.Achartengine.Renderer.DefaultRenderer MRenderer {
			get {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/DefaultRenderer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRenderer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/DefaultRenderer;");
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
				return JNIEnv.FindClass ("org/achartengine/chart/RoundChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoundChart); }
		}

		protected RoundChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/constructor[@name='RoundChart' and count(parameter)=2 and parameter[1][@type='org.achartengine.model.CategorySeries'] and parameter[2][@type='org.achartengine.renderer.DefaultRenderer']]"
		[Register (".ctor", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)V", "")]
		public unsafe RoundChart (global::Org.Achartengine.Model.CategorySeries p0, global::Org.Achartengine.Renderer.DefaultRenderer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RoundChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DefaultRenderer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DefaultRenderer_, __args);
			} finally {
			}
		}

		static Delegate cb_getCenterX;
#pragma warning disable 0169
		static Delegate GetGetCenterXHandler ()
		{
			if (cb_getCenterX == null)
				cb_getCenterX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCenterX);
			return cb_getCenterX;
		}

		static int n_GetCenterX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CenterX;
		}
#pragma warning restore 0169

		static Delegate cb_setCenterX_I;
#pragma warning disable 0169
		static Delegate GetSetCenterX_IHandler ()
		{
			if (cb_setCenterX_I == null)
				cb_setCenterX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCenterX_I);
			return cb_setCenterX_I;
		}

		static void n_SetCenterX_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CenterX = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCenterX;
		static IntPtr id_setCenterX_I;
		public virtual unsafe int CenterX {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='getCenterX' and count(parameter)=0]"
			[Register ("getCenterX", "()I", "GetGetCenterXHandler")]
			get {
				if (id_getCenterX == IntPtr.Zero)
					id_getCenterX = JNIEnv.GetMethodID (class_ref, "getCenterX", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCenterX);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterX", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='setCenterX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCenterX", "(I)V", "GetSetCenterX_IHandler")]
			set {
				if (id_setCenterX_I == IntPtr.Zero)
					id_setCenterX_I = JNIEnv.GetMethodID (class_ref, "setCenterX", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCenterX_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenterX", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterY;
#pragma warning disable 0169
		static Delegate GetGetCenterYHandler ()
		{
			if (cb_getCenterY == null)
				cb_getCenterY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCenterY);
			return cb_getCenterY;
		}

		static int n_GetCenterY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CenterY;
		}
#pragma warning restore 0169

		static Delegate cb_setCenterY_I;
#pragma warning disable 0169
		static Delegate GetSetCenterY_IHandler ()
		{
			if (cb_setCenterY_I == null)
				cb_setCenterY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCenterY_I);
			return cb_setCenterY_I;
		}

		static void n_SetCenterY_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CenterY = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCenterY;
		static IntPtr id_setCenterY_I;
		public virtual unsafe int CenterY {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='getCenterY' and count(parameter)=0]"
			[Register ("getCenterY", "()I", "GetGetCenterYHandler")]
			get {
				if (id_getCenterY == IntPtr.Zero)
					id_getCenterY = JNIEnv.GetMethodID (class_ref, "getCenterY", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCenterY);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterY", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='setCenterY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCenterY", "(I)V", "GetSetCenterY_IHandler")]
			set {
				if (id_setCenterY_I == IntPtr.Zero)
					id_setCenterY_I = JNIEnv.GetMethodID (class_ref, "setCenterY", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCenterY_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenterY", "(I)V"), __args);
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
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Renderer);
		}
#pragma warning restore 0169

		static IntPtr id_getRenderer;
		public virtual unsafe global::Org.Achartengine.Renderer.DefaultRenderer Renderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='getRenderer' and count(parameter)=0]"
			[Register ("getRenderer", "()Lorg/achartengine/renderer/DefaultRenderer;", "GetGetRendererHandler")]
			get {
				if (id_getRenderer == IntPtr.Zero)
					id_getRenderer = JNIEnv.GetMethodID (class_ref, "getRenderer", "()Lorg/achartengine/renderer/DefaultRenderer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (JNIEnv.CallObjectMethod  (Handle, id_getRenderer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderer", "()Lorg/achartengine/renderer/DefaultRenderer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.DrawLegendShape (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_drawLegendShape_Landroid_graphics_Canvas_Lorg_achartengine_renderer_SimpleSeriesRenderer_FFILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='drawLegendShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.achartengine.renderer.SimpleSeriesRenderer'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
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

		static Delegate cb_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_Handler ()
		{
			if (cb_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ == null)
				cb_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_DrawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_);
			return cb_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
		}

		static void n_DrawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.DrawTitle (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='drawTitle' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.Paint']]"
		[Register ("drawTitle", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V", "GetDrawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_Handler")]
		public virtual unsafe void DrawTitle (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, global::Android.Graphics.Paint p4)
		{
			if (id_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawTitle", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawTitle_Landroid_graphics_Canvas_IIILandroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawTitle", "(Landroid/graphics/Canvas;IIILandroid/graphics/Paint;)V"), __args);
			} finally {
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
			global::Org.Achartengine.Chart.RoundChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.RoundChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLegendShapeWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getLegendShapeWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RoundChart']/method[@name='getLegendShapeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
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

	[global::Android.Runtime.Register ("org/achartengine/chart/RoundChart", DoNotGenerateAcw=true)]
	internal partial class RoundChartInvoker : RoundChart {

		public RoundChartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoundChartInvoker); }
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='AbstractChart']/method[@name='draw' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
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
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_, __args);
			} finally {
			}
		}

	}

}
