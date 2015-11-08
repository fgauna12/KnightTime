using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	[global::Android.Runtime.Register ("org/achartengine/tools/FitZoom", DoNotGenerateAcw=true)]
	public partial class FitZoom : global::Org.Achartengine.Tools.AbstractTool {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/tools/FitZoom", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FitZoom); }
		}

		protected FitZoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_chart_AbstractChart_;
		[Register (".ctor", "(Lorg/achartengine/chart/AbstractChart;)V", "")]
		public FitZoom (global::Org.Achartengine.Chart.AbstractChart p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FitZoom)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/chart/AbstractChart;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/chart/AbstractChart;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_apply;
#pragma warning disable 0169
		static Delegate GetApplyHandler ()
		{
			if (cb_apply == null)
				cb_apply = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Apply);
			return cb_apply;
		}

		static void n_Apply (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Tools.FitZoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.FitZoom> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Apply ();
		}
#pragma warning restore 0169

		static IntPtr id_apply;
		[Register ("apply", "()V", "GetApplyHandler")]
		public virtual void Apply ()
		{
			if (id_apply == IntPtr.Zero)
				id_apply = JNIEnv.GetMethodID (class_ref, "apply", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_apply);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_apply);
		}

	}
}
