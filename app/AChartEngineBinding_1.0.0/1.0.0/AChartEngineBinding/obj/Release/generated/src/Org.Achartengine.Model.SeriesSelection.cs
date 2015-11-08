using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Model {

	[global::Android.Runtime.Register ("org/achartengine/model/SeriesSelection", DoNotGenerateAcw=true)]
	public partial class SeriesSelection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/model/SeriesSelection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeriesSelection); }
		}

		protected SeriesSelection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIDD;
		[Register (".ctor", "(IIDD)V", "")]
		public SeriesSelection (int p0, int p1, double p2, double p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SeriesSelection)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(IIDD)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_IIDD == IntPtr.Zero)
				id_ctor_IIDD = JNIEnv.GetMethodID (class_ref, "<init>", "(IIDD)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_IIDD, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getPointIndex;
#pragma warning disable 0169
		static Delegate GetGetPointIndexHandler ()
		{
			if (cb_getPointIndex == null)
				cb_getPointIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPointIndex);
			return cb_getPointIndex;
		}

		static int n_GetPointIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.SeriesSelection __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PointIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getPointIndex;
		public virtual int PointIndex {
			[Register ("getPointIndex", "()I", "GetGetPointIndexHandler")]
			get {
				if (id_getPointIndex == IntPtr.Zero)
					id_getPointIndex = JNIEnv.GetMethodID (class_ref, "getPointIndex", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPointIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getPointIndex);
			}
		}

		static Delegate cb_getSeriesIndex;
#pragma warning disable 0169
		static Delegate GetGetSeriesIndexHandler ()
		{
			if (cb_getSeriesIndex == null)
				cb_getSeriesIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeriesIndex);
			return cb_getSeriesIndex;
		}

		static int n_GetSeriesIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.SeriesSelection __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeriesIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesIndex;
		public virtual int SeriesIndex {
			[Register ("getSeriesIndex", "()I", "GetGetSeriesIndexHandler")]
			get {
				if (id_getSeriesIndex == IntPtr.Zero)
					id_getSeriesIndex = JNIEnv.GetMethodID (class_ref, "getSeriesIndex", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSeriesIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSeriesIndex);
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetValue);
			return cb_getValue;
		}

		static double n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.SeriesSelection __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual double Value {
			[Register ("getValue", "()D", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getValue);
			}
		}

		static Delegate cb_getXValue;
#pragma warning disable 0169
		static Delegate GetGetXValueHandler ()
		{
			if (cb_getXValue == null)
				cb_getXValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetXValue);
			return cb_getXValue;
		}

		static double n_GetXValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Model.SeriesSelection __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XValue;
		}
#pragma warning restore 0169

		static IntPtr id_getXValue;
		public virtual double XValue {
			[Register ("getXValue", "()D", "GetGetXValueHandler")]
			get {
				if (id_getXValue == IntPtr.Zero)
					id_getXValue = JNIEnv.GetMethodID (class_ref, "getXValue", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getXValue);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, id_getXValue);
			}
		}

	}
}
