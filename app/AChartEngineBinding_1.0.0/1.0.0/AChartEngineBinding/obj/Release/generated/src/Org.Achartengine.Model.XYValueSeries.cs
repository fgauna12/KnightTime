using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/XYValueSeries", DoNotGenerateAcw=true)]
	public partial class XYValueSeries : global::Org.Achartengine.Model.XYSeries {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/XYValueSeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYValueSeries); }
		}

		protected XYValueSeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public XYValueSeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (XYValueSeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getMaxValue;
#pragma warning disable 0169
		static Delegate GetGetMaxValueHandler ()
		{
			if (cb_getMaxValue == null)
				cb_getMaxValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxValue);
			return cb_getMaxValue;
		}

		static double n_GetMaxValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxValue;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxValue;
		public virtual double MaxValue {
			[Register ("getMaxValue", "()D", "GetGetMaxValueHandler")]
			get {
				if (id_getMaxValue == IntPtr.Zero)
					id_getMaxValue = JNIEnv.GetMethodID (class_ref, "getMaxValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaxValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMaxValue);
			}
		}

		static Delegate cb_getMinValue;
#pragma warning disable 0169
		static Delegate GetGetMinValueHandler ()
		{
			if (cb_getMinValue == null)
				cb_getMinValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinValue);
			return cb_getMinValue;
		}

		static double n_GetMinValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinValue;
		}
#pragma warning restore 0169

		static IntPtr id_getMinValue;
		public virtual double MinValue {
			[Register ("getMinValue", "()D", "GetGetMinValueHandler")]
			get {
				if (id_getMinValue == IntPtr.Zero)
					id_getMinValue = JNIEnv.GetMethodID (class_ref, "getMinValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMinValue);
			}
		}

		static Delegate cb_add_DDD;
#pragma warning disable 0169
		static Delegate GetAdd_DDDHandler ()
		{
			if (cb_add_DDD == null)
				cb_add_DDD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, double>) n_Add_DDD);
			return cb_add_DDD;
		}

		static void n_Add_DDD (IntPtr jnienv, IntPtr native__this, double p0, double p1, double p2)
		{
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_DDD;
		[Register ("add", "(DDD)V", "GetAdd_DDDHandler")]
		public virtual void Add (double p0, double p1, double p2)
		{
			if (id_add_DDD == IntPtr.Zero)
				id_add_DDD = JNIEnv.GetMethodID (class_ref, "add", "(DDD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getValue_I;
#pragma warning disable 0169
		static Delegate GetGetValue_IHandler ()
		{
			if (cb_getValue_I == null)
				cb_getValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetValue_I);
			return cb_getValue_I;
		}

		static double n_GetValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getValue_I;
		[Register ("getValue", "(I)D", "GetGetValue_IHandler")]
		public virtual double GetValue (int p0)
		{
			if (id_getValue_I == IntPtr.Zero)
				id_getValue_I = JNIEnv.GetMethodID (class_ref, "getValue", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getValue_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getValue_I, new JValue (p0));
		}

	}
}
