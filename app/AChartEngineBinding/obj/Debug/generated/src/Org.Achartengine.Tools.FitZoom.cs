using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.tools']/class[@name='FitZoom']"
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.tools']/class[@name='FitZoom']/constructor[@name='FitZoom' and count(parameter)=1 and parameter[1][@type='org.achartengine.chart.AbstractChart']]"
		[Register (".ctor", "(Lorg/achartengine/chart/AbstractChart;)V", "")]
		public unsafe FitZoom (global::Org.Achartengine.Chart.AbstractChart p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FitZoom)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/chart/AbstractChart;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/chart/AbstractChart;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/chart/AbstractChart;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_, __args);
			} finally {
			}
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
			global::Org.Achartengine.Tools.FitZoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.FitZoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Apply ();
		}
#pragma warning restore 0169

		static IntPtr id_apply;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.tools']/class[@name='FitZoom']/method[@name='apply' and count(parameter)=0]"
		[Register ("apply", "()V", "GetApplyHandler")]
		public virtual unsafe void Apply ()
		{
			if (id_apply == IntPtr.Zero)
				id_apply = JNIEnv.GetMethodID (class_ref, "apply", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_apply);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "()V"));
			} finally {
			}
		}

	}
}
