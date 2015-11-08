using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/TimeSeries", DoNotGenerateAcw=true)]
	public partial class TimeSeries : global::Org.Achartengine.Model.XYSeries {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/TimeSeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeSeries); }
		}

		protected TimeSeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public TimeSeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (TimeSeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_add_Ljava_util_Date_D;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_util_Date_DHandler ()
		{
			if (cb_add_Ljava_util_Date_D == null)
				cb_add_Ljava_util_Date_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Add_Ljava_util_Date_D);
			return cb_add_Ljava_util_Date_D;
		}

		static void n_Add_Ljava_util_Date_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Achartengine.Model.TimeSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.TimeSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_util_Date_D;
		[Register ("add", "(Ljava/util/Date;D)V", "GetAdd_Ljava_util_Date_DHandler")]
		public virtual void Add (global::Java.Util.Date p0, double p1)
		{
			if (id_add_Ljava_util_Date_D == IntPtr.Zero)
				id_add_Ljava_util_Date_D = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/util/Date;D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_util_Date_D, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_Ljava_util_Date_D, new JValue (p0), new JValue (p1));
		}

	}
}
