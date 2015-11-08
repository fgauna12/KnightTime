using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']"
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/constructor[@name='MultipleCategorySeries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MultipleCategorySeries (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (MultipleCategorySeries)) {
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CategoriesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoriesCount;
		public virtual unsafe int CategoriesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='getCategoriesCount' and count(parameter)=0]"
			[Register ("getCategoriesCount", "()I", "GetGetCategoriesCountHandler")]
			get {
				if (id_getCategoriesCount == IntPtr.Zero)
					id_getCategoriesCount = JNIEnv.GetMethodID (class_ref, "getCategoriesCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCategoriesCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoriesCount", "()I"));
				} finally {
				}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='add' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='double[]']]"
		[Register ("add", "(Ljava/lang/String;[Ljava/lang/String;[D)V", "GetAdd_Ljava_lang_String_arrayLjava_lang_String_arrayDHandler")]
		public virtual unsafe void Add (string p0, string[] p1, double[] p2)
		{
			if (id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD == IntPtr.Zero)
				id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;[Ljava/lang/String;[D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_arrayLjava_lang_String_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;[Ljava/lang/String;[D)V"), __args);
			} finally {
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='double[]']]"
		[Register ("add", "([Ljava/lang/String;[D)V", "GetAdd_arrayLjava_lang_String_arrayDHandler")]
		public virtual unsafe void Add (string[] p0, double[] p1)
		{
			if (id_add_arrayLjava_lang_String_arrayD == IntPtr.Zero)
				id_add_arrayLjava_lang_String_arrayD = JNIEnv.GetMethodID (class_ref, "add", "([Ljava/lang/String;[D)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_arrayLjava_lang_String_arrayD, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([Ljava/lang/String;[D)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCategory (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCategory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='getCategory' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCategory", "(I)Ljava/lang/String;", "GetGetCategory_IHandler")]
		public virtual unsafe string GetCategory (int p0)
		{
			if (id_getCategory_I == IntPtr.Zero)
				id_getCategory_I = JNIEnv.GetMethodID (class_ref, "getCategory", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCategory_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategory", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='getItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemCount", "(I)I", "GetGetItemCount_IHandler")]
		public virtual unsafe int GetItemCount (int p0)
		{
			if (id_getItemCount_I == IntPtr.Zero)
				id_getItemCount_I = JNIEnv.GetMethodID (class_ref, "getItemCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getItemCount_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "(I)I"), __args);
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTitles (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTitles_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='getTitles' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitles", "(I)[Ljava/lang/String;", "GetGetTitles_IHandler")]
		public virtual unsafe string[] GetTitles (int p0)
		{
			if (id_getTitles_I == IntPtr.Zero)
				id_getTitles_I = JNIEnv.GetMethodID (class_ref, "getTitles", "(I)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTitles_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitles", "(I)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getValues_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='getValues' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValues", "(I)[D", "GetGetValues_IHandler")]
		public virtual unsafe double[] GetValues (int p0)
		{
			if (id_getValues_I == IntPtr.Zero)
				id_getValues_I = JNIEnv.GetMethodID (class_ref, "getValues", "(I)[D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getValues_I, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				else
					return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValues", "(I)[D"), __args), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual unsafe void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_remove_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), __args);
			} finally {
			}
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
			global::Org.Achartengine.Model.MultipleCategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.MultipleCategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToXYSeries ());
		}
#pragma warning restore 0169

		static IntPtr id_toXYSeries;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='MultipleCategorySeries']/method[@name='toXYSeries' and count(parameter)=0]"
		[Register ("toXYSeries", "()Lorg/achartengine/model/XYSeries;", "GetToXYSeriesHandler")]
		public virtual unsafe global::Org.Achartengine.Model.XYSeries ToXYSeries ()
		{
			if (id_toXYSeries == IntPtr.Zero)
				id_toXYSeries = JNIEnv.GetMethodID (class_ref, "toXYSeries", "()Lorg/achartengine/model/XYSeries;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallObjectMethod  (Handle, id_toXYSeries), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toXYSeries", "()Lorg/achartengine/model/XYSeries;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
