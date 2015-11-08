using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']"
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']/constructor[@name='XYValueSeries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe XYValueSeries (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (XYValueSeries)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxValue;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxValue;
		public virtual unsafe double MaxValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']/method[@name='getMaxValue' and count(parameter)=0]"
			[Register ("getMaxValue", "()D", "GetGetMaxValueHandler")]
			get {
				if (id_getMaxValue == IntPtr.Zero)
					id_getMaxValue = JNIEnv.GetMethodID (class_ref, "getMaxValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxValue", "()D"));
				} finally {
				}
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
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinValue;
		}
#pragma warning restore 0169

		static IntPtr id_getMinValue;
		public virtual unsafe double MinValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']/method[@name='getMinValue' and count(parameter)=0]"
			[Register ("getMinValue", "()D", "GetGetMinValueHandler")]
			get {
				if (id_getMinValue == IntPtr.Zero)
					id_getMinValue = JNIEnv.GetMethodID (class_ref, "getMinValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinValue", "()D"));
				} finally {
				}
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
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_DDD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']/method[@name='add' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("add", "(DDD)V", "GetAdd_DDDHandler")]
		public virtual unsafe void Add (double p0, double p1, double p2)
		{
			if (id_add_DDD == IntPtr.Zero)
				id_add_DDD = JNIEnv.GetMethodID (class_ref, "add", "(DDD)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_DDD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(DDD)V"), __args);
			} finally {
			}
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
			global::Org.Achartengine.Model.XYValueSeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYValueSeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='XYValueSeries']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)D", "GetGetValue_IHandler")]
		public virtual unsafe double GetValue (int p0)
		{
			if (id_getValue_I == IntPtr.Zero)
				id_getValue_I = JNIEnv.GetMethodID (class_ref, "getValue", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getValue_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(I)D"), __args);
			} finally {
			}
		}

	}
}
