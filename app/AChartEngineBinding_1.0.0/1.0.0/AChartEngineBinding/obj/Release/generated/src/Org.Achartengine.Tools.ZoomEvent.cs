using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	[global::Android.Runtime.Register ("org/achartengine/tools/ZoomEvent", DoNotGenerateAcw=true)]
	public partial class ZoomEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/tools/ZoomEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoomEvent); }
		}

		protected ZoomEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZF;
		[Register (".ctor", "(ZF)V", "")]
		public ZoomEvent (bool p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZoomEvent)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(ZF)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_ZF == IntPtr.Zero)
				id_ctor_ZF = JNIEnv.GetMethodID (class_ref, "<init>", "(ZF)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_ZF, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isZoomIn;
#pragma warning disable 0169
		static Delegate GetIsZoomInHandler ()
		{
			if (cb_isZoomIn == null)
				cb_isZoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomIn);
			return cb_isZoomIn;
		}

		static bool n_IsZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Tools.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.ZoomEvent> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZoomIn;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomIn;
		public virtual bool IsZoomIn {
			[Register ("isZoomIn", "()Z", "GetIsZoomInHandler")]
			get {
				if (id_isZoomIn == IntPtr.Zero)
					id_isZoomIn = JNIEnv.GetMethodID (class_ref, "isZoomIn", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZoomIn);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isZoomIn);
			}
		}

		static Delegate cb_getZoomRate;
#pragma warning disable 0169
		static Delegate GetGetZoomRateHandler ()
		{
			if (cb_getZoomRate == null)
				cb_getZoomRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomRate);
			return cb_getZoomRate;
		}

		static float n_GetZoomRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Tools.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.ZoomEvent> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomRate;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomRate;
		public virtual float ZoomRate {
			[Register ("getZoomRate", "()F", "GetGetZoomRateHandler")]
			get {
				if (id_getZoomRate == IntPtr.Zero)
					id_getZoomRate = JNIEnv.GetMethodID (class_ref, "getZoomRate", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZoomRate);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getZoomRate);
			}
		}

	}
}
