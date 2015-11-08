using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']"
	[global::Android.Runtime.Register ("org/achartengine/model/RangeCategorySeries", DoNotGenerateAcw=true)]
	public partial class RangeCategorySeries : global::Org.Achartengine.Model.CategorySeries {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/RangeCategorySeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RangeCategorySeries); }
		}

		protected RangeCategorySeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']/constructor[@name='RangeCategorySeries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RangeCategorySeries (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (RangeCategorySeries)) {
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

		static Delegate cb_add_DD;
#pragma warning disable 0169
		static Delegate GetAdd_DDHandler ()
		{
			if (cb_add_DD == null)
				cb_add_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_Add_DD);
			return cb_add_DD;
		}

		static void n_Add_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']/method[@name='add' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("add", "(DD)V", "GetAdd_DDHandler")]
		public virtual unsafe void Add (double p0, double p1)
		{
			if (id_add_DD == IntPtr.Zero)
				id_add_DD = JNIEnv.GetMethodID (class_ref, "add", "(DD)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(DD)V"), __args);
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_String_DD;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_DDHandler ()
		{
			if (cb_add_Ljava_lang_String_DD == null)
				cb_add_Ljava_lang_String_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double, double>) n_Add_Ljava_lang_String_DD);
			return cb_add_Ljava_lang_String_DD;
		}

		static void n_Add_Ljava_lang_String_DD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, double p2)
		{
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']/method[@name='add' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("add", "(Ljava/lang/String;DD)V", "GetAdd_Ljava_lang_String_DDHandler")]
		public virtual unsafe void Add (string p0, double p1, double p2)
		{
			if (id_add_Ljava_lang_String_DD == IntPtr.Zero)
				id_add_Ljava_lang_String_DD = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;DD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_DD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;DD)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMaximumValue_I;
#pragma warning disable 0169
		static Delegate GetGetMaximumValue_IHandler ()
		{
			if (cb_getMaximumValue_I == null)
				cb_getMaximumValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetMaximumValue_I);
			return cb_getMaximumValue_I;
		}

		static double n_GetMaximumValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMaximumValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']/method[@name='getMaximumValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMaximumValue", "(I)D", "GetGetMaximumValue_IHandler")]
		public virtual unsafe double GetMaximumValue (int p0)
		{
			if (id_getMaximumValue_I == IntPtr.Zero)
				id_getMaximumValue_I = JNIEnv.GetMethodID (class_ref, "getMaximumValue", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMaximumValue_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumValue", "(I)D"), __args);
			} finally {
			}
		}

		static Delegate cb_getMinimumValue_I;
#pragma warning disable 0169
		static Delegate GetGetMinimumValue_IHandler ()
		{
			if (cb_getMinimumValue_I == null)
				cb_getMinimumValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_GetMinimumValue_I);
			return cb_getMinimumValue_I;
		}

		static double n_GetMinimumValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMinimumValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='RangeCategorySeries']/method[@name='getMinimumValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMinimumValue", "(I)D", "GetGetMinimumValue_IHandler")]
		public virtual unsafe double GetMinimumValue (int p0)
		{
			if (id_getMinimumValue_I == IntPtr.Zero)
				id_getMinimumValue_I = JNIEnv.GetMethodID (class_ref, "getMinimumValue", "(I)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getMinimumValue_I, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumValue", "(I)D"), __args);
			} finally {
			}
		}

	}
}
