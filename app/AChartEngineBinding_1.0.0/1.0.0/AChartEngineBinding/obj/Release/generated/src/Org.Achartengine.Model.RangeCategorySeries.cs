using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

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
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public RangeCategorySeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (RangeCategorySeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_DD;
		[Register ("add", "(DD)V", "GetAdd_DDHandler")]
		public virtual void Add (double p0, double p1)
		{
			if (id_add_DD == IntPtr.Zero)
				id_add_DD = JNIEnv.GetMethodID (class_ref, "add", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_DD, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_DD, new JValue (p0), new JValue (p1));
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
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_DD;
		[Register ("add", "(Ljava/lang/String;DD)V", "GetAdd_Ljava_lang_String_DDHandler")]
		public virtual void Add (string p0, double p1, double p2)
		{
			if (id_add_Ljava_lang_String_DD == IntPtr.Zero)
				id_add_Ljava_lang_String_DD = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;DD)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_DD, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_Ljava_lang_String_DD, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMaximumValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumValue_I;
		[Register ("getMaximumValue", "(I)D", "GetGetMaximumValue_IHandler")]
		public virtual double GetMaximumValue (int p0)
		{
			if (id_getMaximumValue_I == IntPtr.Zero)
				id_getMaximumValue_I = JNIEnv.GetMethodID (class_ref, "getMaximumValue", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getMaximumValue_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMaximumValue_I, new JValue (p0));
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
			global::Org.Achartengine.Model.RangeCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.RangeCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMinimumValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumValue_I;
		[Register ("getMinimumValue", "(I)D", "GetGetMinimumValue_IHandler")]
		public virtual double GetMinimumValue (int p0)
		{
			if (id_getMinimumValue_I == IntPtr.Zero)
				id_getMinimumValue_I = JNIEnv.GetMethodID (class_ref, "getMinimumValue", "(I)D");

			if (GetType () == ThresholdType)
				return JNIEnv.CallDoubleMethod  (Handle, id_getMinimumValue_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getMinimumValue_I, new JValue (p0));
		}

	}
}
