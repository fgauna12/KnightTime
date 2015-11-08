using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/XYMultipleSeriesDataset", DoNotGenerateAcw=true)]
	public partial class XYMultipleSeriesDataset : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/XYMultipleSeriesDataset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYMultipleSeriesDataset); }
		}

		protected XYMultipleSeriesDataset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public XYMultipleSeriesDataset () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (XYMultipleSeriesDataset)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSeriesCount;
#pragma warning disable 0169
		static Delegate GetGetSeriesCountHandler ()
		{
			if (cb_getSeriesCount == null)
				cb_getSeriesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeriesCount);
			return cb_getSeriesCount;
		}

		static int n_GetSeriesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeriesCount;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesCount;
		public virtual int SeriesCount {
			[Register ("getSeriesCount", "()I", "GetGetSeriesCountHandler")]
			get {
				if (id_getSeriesCount == IntPtr.Zero)
					id_getSeriesCount = JNIEnv.GetMethodID (class_ref, "getSeriesCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSeriesCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSeriesCount);
			}
		}

		static Delegate cb_addSeries_ILorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetAddSeries_ILorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_addSeries_ILorg_achartengine_model_XYSeries_ == null)
				cb_addSeries_ILorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddSeries_ILorg_achartengine_model_XYSeries_);
			return cb_addSeries_ILorg_achartengine_model_XYSeries_;
		}

		static void n_AddSeries_ILorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSeries (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSeries_ILorg_achartengine_model_XYSeries_;
		[Register ("addSeries", "(ILorg/achartengine/model/XYSeries;)V", "GetAddSeries_ILorg_achartengine_model_XYSeries_Handler")]
		public virtual void AddSeries (int p0, global::Org.Achartengine.Model.XYSeries p1)
		{
			if (id_addSeries_ILorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_addSeries_ILorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "addSeries", "(ILorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeries_ILorg_achartengine_model_XYSeries_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addSeries_ILorg_achartengine_model_XYSeries_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addSeries_Lorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetAddSeries_Lorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_addSeries_Lorg_achartengine_model_XYSeries_ == null)
				cb_addSeries_Lorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSeries_Lorg_achartengine_model_XYSeries_);
			return cb_addSeries_Lorg_achartengine_model_XYSeries_;
		}

		static void n_AddSeries_Lorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSeries_Lorg_achartengine_model_XYSeries_;
		[Register ("addSeries", "(Lorg/achartengine/model/XYSeries;)V", "GetAddSeries_Lorg_achartengine_model_XYSeries_Handler")]
		public virtual void AddSeries (global::Org.Achartengine.Model.XYSeries p0)
		{
			if (id_addSeries_Lorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_addSeries_Lorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "addSeries", "(Lorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
		}

		static Delegate cb_getSeries;
#pragma warning disable 0169
		static Delegate GetGetSeriesHandler ()
		{
			if (cb_getSeries == null)
				cb_getSeries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeries);
			return cb_getSeries;
		}

		static IntPtr n_GetSeries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSeries ());
		}
#pragma warning restore 0169

		static IntPtr id_getSeries;
		[Register ("getSeries", "()[Lorg/achartengine/model/XYSeries;", "GetGetSeriesHandler")]
		public virtual global::Org.Achartengine.Model.XYSeries[] GetSeries ()
		{
			if (id_getSeries == IntPtr.Zero)
				id_getSeries = JNIEnv.GetMethodID (class_ref, "getSeries", "()[Lorg/achartengine/model/XYSeries;");

			if (GetType () == ThresholdType)
				return (global::Org.Achartengine.Model.XYSeries[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSeries), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Model.XYSeries));
			else
				return (global::Org.Achartengine.Model.XYSeries[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSeries), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Model.XYSeries));
		}

		static Delegate cb_getSeriesAt_I;
#pragma warning disable 0169
		static Delegate GetGetSeriesAt_IHandler ()
		{
			if (cb_getSeriesAt_I == null)
				cb_getSeriesAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSeriesAt_I);
			return cb_getSeriesAt_I;
		}

		static IntPtr n_GetSeriesAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeriesAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesAt_I;
		[Register ("getSeriesAt", "(I)Lorg/achartengine/model/XYSeries;", "GetGetSeriesAt_IHandler")]
		public virtual global::Org.Achartengine.Model.XYSeries GetSeriesAt (int p0)
		{
			if (id_getSeriesAt_I == IntPtr.Zero)
				id_getSeriesAt_I = JNIEnv.GetMethodID (class_ref, "getSeriesAt", "(I)Lorg/achartengine/model/XYSeries;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallObjectMethod  (Handle, id_getSeriesAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSeriesAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_removeSeries_I;
#pragma warning disable 0169
		static Delegate GetRemoveSeries_IHandler ()
		{
			if (cb_removeSeries_I == null)
				cb_removeSeries_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveSeries_I);
			return cb_removeSeries_I;
		}

		static void n_RemoveSeries_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSeries_I;
		[Register ("removeSeries", "(I)V", "GetRemoveSeries_IHandler")]
		public virtual void RemoveSeries (int p0)
		{
			if (id_removeSeries_I == IntPtr.Zero)
				id_removeSeries_I = JNIEnv.GetMethodID (class_ref, "removeSeries", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSeries_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeSeries_I, new JValue (p0));
		}

		static Delegate cb_removeSeries_Lorg_achartengine_model_XYSeries_;
#pragma warning disable 0169
		static Delegate GetRemoveSeries_Lorg_achartengine_model_XYSeries_Handler ()
		{
			if (cb_removeSeries_Lorg_achartengine_model_XYSeries_ == null)
				cb_removeSeries_Lorg_achartengine_model_XYSeries_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSeries_Lorg_achartengine_model_XYSeries_);
			return cb_removeSeries_Lorg_achartengine_model_XYSeries_;
		}

		static void n_RemoveSeries_Lorg_achartengine_model_XYSeries_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Model.XYMultipleSeriesDataset __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYMultipleSeriesDataset> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.XYSeries p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.XYSeries> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSeries (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSeries_Lorg_achartengine_model_XYSeries_;
		[Register ("removeSeries", "(Lorg/achartengine/model/XYSeries;)V", "GetRemoveSeries_Lorg_achartengine_model_XYSeries_Handler")]
		public virtual void RemoveSeries (global::Org.Achartengine.Model.XYSeries p0)
		{
			if (id_removeSeries_Lorg_achartengine_model_XYSeries_ == IntPtr.Zero)
				id_removeSeries_Lorg_achartengine_model_XYSeries_ = JNIEnv.GetMethodID (class_ref, "removeSeries", "(Lorg/achartengine/model/XYSeries;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeSeries_Lorg_achartengine_model_XYSeries_, new JValue (p0));
		}

	}
}
