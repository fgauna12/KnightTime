using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/MultipleCategorySeries", DoNotGenerateAcw=true)]
	public partial class MultipleCategorySeries : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/MultipleCategorySeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultipleCategorySeries); }
		}

		protected MultipleCategorySeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public MultipleCategorySeries (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (MultipleCategorySeries)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getCategoriesCount;
#pragma warning disable 0169
		static Delegate GetGetCategoriesCountHandler ()
		{
			if (cb_getCategoriesCount == null)
				cb_getCategoriesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCategoriesCount);
			return cb_getCategoriesCount;
		}

		static int n_GetCategoriesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CategoriesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoriesCount;
		public virtual int CategoriesCount {
			[Register ("getCategoriesCount", "()I", "GetGetCategoriesCountHandler")]
			get {
				if (id_getCategoriesCount == IntPtr.Zero)
					id_getCategoriesCount = JNIEnv.GetMethodID (class_ref, "getCategoriesCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCategoriesCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getCategoriesCount);
			}
		}

		static Delegate cb_add_Ljava_lang_String_arrayLjava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_arrayLjava_lang_String_arrayDHandler ()
		{
			if (cb_add_Ljava_lang_String_arrayLjava_lang_String_arrayD == null)
				cb_add_Ljava_lang_String_arrayLjava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_arrayLjava_lang_String_arrayD);
			return cb_add_Ljava_lang_String_arrayLjava_lang_String_arrayD;
		}

		static void n_Add_Ljava_lang_String_arrayLjava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			double[] p2 = (double[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Add (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD;
		[Register ("add", "(Ljava/lang/String;[Ljava/lang/String;[D)V", "GetAdd_Ljava_lang_String_arrayLjava_lang_String_arrayDHandler")]
		public virtual void Add (string p0, string[] p1, double[] p2)
		{
			if (id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD == IntPtr.Zero)
				id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;[Ljava/lang/String;[D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_add_arrayLjava_lang_String_arrayD;
#pragma warning disable 0169
		static Delegate GetAdd_arrayLjava_lang_String_arrayDHandler ()
		{
			if (cb_add_arrayLjava_lang_String_arrayD == null)
				cb_add_arrayLjava_lang_String_arrayD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_arrayLjava_lang_String_arrayD);
			return cb_add_arrayLjava_lang_String_arrayD;
		}

		static void n_Add_arrayLjava_lang_String_arrayD (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			double[] p1 = (double[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.Add (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayLjava_lang_String_arrayD;
		[Register ("add", "([Ljava/lang/String;[D)V", "GetAdd_arrayLjava_lang_String_arrayDHandler")]
		public virtual void Add (string[] p0, double[] p1)
		{
			if (id_add_arrayLjava_lang_String_arrayD == IntPtr.Zero)
				id_add_arrayLjava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "add", "([Ljava/lang/String;[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_arrayLjava_lang_String_arrayD, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_add_arrayLjava_lang_String_arrayD, new JValue (native_p0), new JValue (native_p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_clear);
		}

		static Delegate cb_getCategory_I;
#pragma warning disable 0169
		static Delegate GetGetCategory_IHandler ()
		{
			if (cb_getCategory_I == null)
				cb_getCategory_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetCategory_I);
			return cb_getCategory_I;
		}

		static IntPtr n_GetCategory_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCategory (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCategory_I;
		[Register ("getCategory", "(I)Ljava/lang/String;", "GetGetCategory_IHandler")]
		public virtual string GetCategory (int p0)
		{
			if (id_getCategory_I == IntPtr.Zero)
				id_getCategory_I = JNIEnv.GetMethodID (class_ref, "getCategory", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCategory_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCategory_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItemCount_I;
#pragma warning disable 0169
		static Delegate GetGetItemCount_IHandler ()
		{
			if (cb_getItemCount_I == null)
				cb_getItemCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetItemCount_I);
			return cb_getItemCount_I;
		}

		static int n_GetItemCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount_I;
		[Register ("getItemCount", "(I)I", "GetGetItemCount_IHandler")]
		public virtual int GetItemCount (int p0)
		{
			if (id_getItemCount_I == IntPtr.Zero)
				id_getItemCount_I = JNIEnv.GetMethodID (class_ref, "getItemCount", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getItemCount_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getItemCount_I, new JValue (p0));
		}

		static Delegate cb_getTitles_I;
#pragma warning disable 0169
		static Delegate GetGetTitles_IHandler ()
		{
			if (cb_getTitles_I == null)
				cb_getTitles_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitles_I);
			return cb_getTitles_I;
		}

		static IntPtr n_GetTitles_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTitles (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTitles_I;
		[Register ("getTitles", "(I)[Ljava/lang/String;", "GetGetTitles_IHandler")]
		public virtual string[] GetTitles (int p0)
		{
			if (id_getTitles_I == IntPtr.Zero)
				id_getTitles_I = JNIEnv.GetMethodID (class_ref, "getTitles", "(I)[Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTitles_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
			else
				return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTitles_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getValues_I;
#pragma warning disable 0169
		static Delegate GetGetValues_IHandler ()
		{
			if (cb_getValues_I == null)
				cb_getValues_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetValues_I);
			return cb_getValues_I;
		}

		static IntPtr n_GetValues_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getValues_I;
		[Register ("getValues", "(I)[D", "GetGetValues_IHandler")]
		public virtual double[] GetValues (int p0)
		{
			if (id_getValues_I == IntPtr.Zero)
				id_getValues_I = JNIEnv.GetMethodID (class_ref, "getValues", "(I)[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getValues_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_remove_I, new JValue (p0));
		}

		static Delegate cb_toXYSeries;
#pragma warning disable 0169
		static Delegate GetToXYSeriesHandler ()
		{
			if (cb_toXYSeries == null)
				cb_toXYSeries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToXYSeries);
			return cb_toXYSeries;
		}

		static IntPtr n_ToXYSeries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToXYSeries ());
		}
#pragma warning restore 0169

		static IntPtr id_toXYSeries;
		[Register ("toXYSeries", "()Lorg/achartengine/model/XYSeries;", "GetToXYSeriesHandler")]
		public virtual global::Org.Achartengine.Model.XYSeries ToXYSeries ()
		{
			if (id_toXYSeries == IntPtr.Zero)
				id_toXYSeries = JNIEnv.GetMethodID (class_ref, "toXYSeries", "()Lorg/achartengine/model/XYSeries;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallObjectMethod  (Handle, id_toXYSeries), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toXYSeries), JniHandleOwnership.TransferLocalRef);
		}

	}
}
