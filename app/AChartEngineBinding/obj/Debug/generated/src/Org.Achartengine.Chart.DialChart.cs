using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='DialChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/DialChart", DoNotGenerateAcw=true)]
	public partial class DialChart : global::Org.Achartengine.Chart.RoundChart {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/DialChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DialChart); }
		}

		protected DialChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='DialChart']/constructor[@name='DialChart' and count(parameter)=2 and parameter[1][@type='org.achartengine.model.CategorySeries'] and parameter[2][@type='org.achartengine.renderer.DialRenderer']]"
		[Register (".ctor", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V", "")]
		public unsafe DialChart (global::Org.Achartengine.Model.CategorySeries p0, global::Org.Achartengine.Renderer.DialRenderer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DialChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_, __args);
			} finally {
			}
		}

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
			global::Org.Achartengine.Chart.DialChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.DialChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='DialChart']/method[@name='draw' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Paint']]"
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

	}
}
