using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='ClickableArea']"
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='ClickableArea']/constructor[@name='ClickableArea' and count(parameter)=3 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(Landroid/graphics/RectF;DD)V", "")]
		public unsafe ClickableArea (global::Android.Graphics.RectF p0, double p1, double p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ClickableArea)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/RectF;DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/RectF;DD)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_RectF_DD == IntPtr.Zero)
					id_ctor_Landroid_graphics_RectF_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/RectF;DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_RectF_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_RectF_DD, __args);
			} finally {
			}
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
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rect);
		}
#pragma warning restore 0169

		static IntPtr id_getRect;
		public virtual unsafe global::Android.Graphics.RectF Rect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='ClickableArea']/method[@name='getRect' and count(parameter)=0]"
			[Register ("getRect", "()Landroid/graphics/RectF;", "GetGetRectHandler")]
			get {
				if (id_getRect == IntPtr.Zero)
					id_getRect = JNIEnv.GetMethodID (class_ref, "getRect", "()Landroid/graphics/RectF;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getRect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRect", "()Landroid/graphics/RectF;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='ClickableArea']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()D", "GetGetXHandler")]
		public virtual unsafe double GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()D"));
			} finally {
			}
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
			global::Org.Achartengine.Chart.ClickableArea __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.ClickableArea> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='ClickableArea']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()D", "GetGetYHandler")]
		public virtual unsafe double GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getY);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()D"));
			} finally {
			}
		}

	}
}
