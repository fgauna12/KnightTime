using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']"
	[global::Android.Runtime.Register ("org/achartengine/model/CategorySeries", DoNotGenerateAcw=true)]
	public partial class CategorySeries : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/CategorySeries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CategorySeries); }
		}

		protected CategorySeries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/constructor[@name='CategorySeries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CategorySeries (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (CategorySeries)) {
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

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public virtual unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_D;
#pragma warning disable 0169
		static Delegate GetAdd_DHandler ()
		{
			if (cb_add_D == null)
				cb_add_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Add_D);
			return cb_add_D;
		}

		static void n_Add_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='add' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("add", "(D)V", "GetAdd_DHandler")]
		public virtual unsafe void Add (double p0)
		{
			if (id_add_D == IntPtr.Zero)
				id_add_D = JNIEnv.GetMethodID (class_ref, "add", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_DHandler ()
		{
			if (cb_add_Ljava_lang_String_D == null)
				cb_add_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Add_Ljava_lang_String_D);
			return cb_add_Ljava_lang_String_D;
		}

		static void n_Add_Ljava_lang_String_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("add", "(Ljava/lang/String;D)V", "GetAdd_Ljava_lang_String_DHandler")]
		public virtual unsafe void Add (string p0, double p1)
		{
			if (id_add_Ljava_lang_String_D == IntPtr.Zero)
				id_add_Ljava_lang_String_D = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_Ljava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='clear' and count(parameter)=0]"
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
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetCategory (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getCategory_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='getCategory' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_set_ILjava_lang_String_D;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_lang_String_DHandler ()
		{
			if (cb_set_ILjava_lang_String_D == null)
				cb_set_ILjava_lang_String_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, double>) n_Set_ILjava_lang_String_D);
			return cb_set_ILjava_lang_String_D;
		}

		static void n_Set_ILjava_lang_String_D (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, double p2)
		{
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_set_ILjava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='set' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double']]"
		[Register ("set", "(ILjava/lang/String;D)V", "GetSet_ILjava_lang_String_DHandler")]
		public virtual unsafe void Set (int p0, string p1, double p2)
		{
			if (id_set_ILjava_lang_String_D == IntPtr.Zero)
				id_set_ILjava_lang_String_D = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/String;D)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_ILjava_lang_String_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILjava/lang/String;D)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Org.Achartengine.Model.CategorySeries __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.CategorySeries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToXYSeries ());
		}
#pragma warning restore 0169

		static IntPtr id_toXYSeries;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.model']/class[@name='CategorySeries']/method[@name='toXYSeries' and count(parameter)=0]"
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
