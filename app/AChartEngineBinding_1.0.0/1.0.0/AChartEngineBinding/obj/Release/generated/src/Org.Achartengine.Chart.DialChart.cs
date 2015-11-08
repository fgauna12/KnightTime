using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

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
		[Register (".ctor", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V", "")]
		public DialChart (global::Org.Achartengine.Model.CategorySeries p0, global::Org.Achartengine.Renderer.DialRenderer p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DialChart)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/CategorySeries;Lorg/achartengine/renderer/DialRenderer;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_model_CategorySeries_Lorg_achartengine_renderer_DialRenderer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Achartengine.Chart.DialChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.DialChart> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_;
		[Register ("draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V", "GetDraw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_Handler")]
		public override void Draw (global::Android.Graphics.Canvas p0, int p1, int p2, int p3, int p4, global::Android.Graphics.Paint p5)
		{
			if (id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;IIIILandroid/graphics/Paint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_draw_Landroid_graphics_Canvas_IIIILandroid_graphics_Paint_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
		}

	}
}
