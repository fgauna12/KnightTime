using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.tools']/class[@name='ZoomEvent']"
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.tools']/class[@name='ZoomEvent']/constructor[@name='ZoomEvent' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='float']]"
		[Register (".ctor", "(ZF)V", "")]
		public unsafe ZoomEvent (bool p0, float p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ZoomEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZF)V", __args);
					return;
				}

				if (id_ctor_ZF == IntPtr.Zero)
					id_ctor_ZF = JNIEnv.GetMethodID (class_ref, "<init>", "(ZF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZF, __args);
			} finally {
			}
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
			global::Org.Achartengine.Tools.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.ZoomEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZoomIn;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomIn;
		public virtual unsafe bool IsZoomIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.tools']/class[@name='ZoomEvent']/method[@name='isZoomIn' and count(parameter)=0]"
			[Register ("isZoomIn", "()Z", "GetIsZoomInHandler")]
			get {
				if (id_isZoomIn == IntPtr.Zero)
					id_isZoomIn = JNIEnv.GetMethodID (class_ref, "isZoomIn", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isZoomIn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isZoomIn", "()Z"));
				} finally {
				}
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
			global::Org.Achartengine.Tools.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.ZoomEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomRate;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomRate;
		public virtual unsafe float ZoomRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.tools']/class[@name='ZoomEvent']/method[@name='getZoomRate' and count(parameter)=0]"
			[Register ("getZoomRate", "()F", "GetGetZoomRateHandler")]
			get {
				if (id_getZoomRate == IntPtr.Zero)
					id_getZoomRate = JNIEnv.GetMethodID (class_ref, "getZoomRate", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getZoomRate);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomRate", "()F"));
				} finally {
				}
			}
		}

	}
}
