using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	[global::Android.Runtime.Register ("org/achartengine/chart/ClickableArea", DoNotGenerateAcw=true)]
	public partial class ClickableArea : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/ClickableArea", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClickableArea); }
		}

		protected ClickableArea (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_RectF_DD;
		[Register (".ctor", "(Landroid/graphics/RectF;DD)V", "")]
		public ClickableArea (global::Android.Graphics.RectF p0, double p1, double p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ClickableArea)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/graphics/RectF;DD)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_graphics_RectF_DD == IntPtr.Zero)
				id_ctor_Landroid_graphics_RectF_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/RectF;DD)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_graphics_RectF_DD, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getRect;
#pragma warning disable 0169
		static Delegate GetGetRectHandler ()
		{
			if (cb_getRect == null)
				cb_getRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRect);
			return cb_getRect;
		}

		static IntPtr n_GetRect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rect);
		}
#pragma warning restore 0169

		static IntPtr id_getRect;
		public virtual global::Android.Graphics.RectF Rect {
			[Register ("getRect", "()Landroid/graphics/RectF;", "GetGetRectHandler")]
			get {
				if (id_getRect == IntPtr.Zero)
					id_getRect = JNIEnv.GetMethodID (class_ref, "getRect", "()Landroid/graphics/RectF;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRect), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetX);
			return cb_getX;
		}

		static double n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		[Register ("getX", "()D", "GetGetXHandler")]
		public virtual double GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getX);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getX);
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetY);
			return cb_getY;
		}

		static double n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		[Register ("getY", "()D", "GetGetYHandler")]
		public virtual double GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getY);
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getY);
		}

	}
}
