using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	[global::Android.Runtime.Register ("org/achartengine/tools/AbstractTool", DoNotGenerateAcw=true)]
	public abstract partial class AbstractTool : global::Java.Lang.Object {


		static IntPtr mChart_jfieldId;

		[Register ("mChart")]
		protected global::Org.Achartengine.Chart.AbstractChart MChart {
			get {
				if (mChart_jfieldId == IntPtr.Zero)
					mChart_jfieldId = JNIEnv.GetFieldID (class_ref, "mChart", "Lorg/achartengine/chart/AbstractChart;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mChart_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.AbstractChart> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mChart_jfieldId == IntPtr.Zero)
					mChart_jfieldId = JNIEnv.GetFieldID (class_ref, "mChart", "Lorg/achartengine/chart/AbstractChart;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mChart_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mRenderer_jfieldId;

		[Register ("mRenderer")]
		protected global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer MRenderer {
			get {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRenderer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRenderer_jfieldId == IntPtr.Zero)
					mRenderer_jfieldId = JNIEnv.GetFieldID (class_ref, "mRenderer", "Lorg/achartengine/renderer/XYMultipleSeriesRenderer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mRenderer_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/tools/AbstractTool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractTool); }
		}

		protected AbstractTool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_chart_AbstractChart_;
		[Register (".ctor", "(Lorg/achartengine/chart/AbstractChart;)V", "")]
		public AbstractTool (global::Org.Achartengine.Chart.AbstractChart p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AbstractTool)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/chart/AbstractChart;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/chart/AbstractChart;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_checkRange_arrayDI;
#pragma warning disable 0169
		static Delegate GetCheckRange_arrayDIHandler ()
		{
			if (cb_checkRange_arrayDI == null)
				cb_checkRange_arrayDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_CheckRange_arrayDI);
			return cb_checkRange_arrayDI;
		}

		static void n_CheckRange_arrayDI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Tools.AbstractTool __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.AbstractTool> (native__this, JniHandleOwnership.DoNotTransfer);
			double[] p0 = (double[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (double));
			__this.CheckRange (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_checkRange_arrayDI;
		[Register ("checkRange", "([DI)V", "GetCheckRange_arrayDIHandler")]
		public virtual void CheckRange (double[] p0, int p1)
		{
			if (id_checkRange_arrayDI == IntPtr.Zero)
				id_checkRange_arrayDI = JNIEnv.GetMethodID (class_ref, "checkRange", "([DI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_checkRange_arrayDI, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_checkRange_arrayDI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getRange_I;
#pragma warning disable 0169
		static Delegate GetGetRange_IHandler ()
		{
			if (cb_getRange_I == null)
				cb_getRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRange_I);
			return cb_getRange_I;
		}

		static IntPtr n_GetRange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Tools.AbstractTool __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.AbstractTool> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRange (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getRange_I;
		[Register ("getRange", "(I)[D", "GetGetRange_IHandler")]
		public virtual double[] GetRange (int p0)
		{
			if (id_getRange_I == IntPtr.Zero)
				id_getRange_I = JNIEnv.GetMethodID (class_ref, "getRange", "(I)[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getRange_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getRange_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_setXRange_DDI;
#pragma warning disable 0169
		static Delegate GetSetXRange_DDIHandler ()
		{
			if (cb_setXRange_DDI == null)
				cb_setXRange_DDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, int>) n_SetXRange_DDI);
			return cb_setXRange_DDI;
		}

		static void n_SetXRange_DDI (IntPtr jnienv, IntPtr native__this, double p0, double p1, int p2)
		{
			global::Org.Achartengine.Tools.AbstractTool __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.AbstractTool> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetXRange (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setXRange_DDI;
		[Register ("setXRange", "(DDI)V", "GetSetXRange_DDIHandler")]
		protected virtual void SetXRange (double p0, double p1, int p2)
		{
			if (id_setXRange_DDI == IntPtr.Zero)
				id_setXRange_DDI = JNIEnv.GetMethodID (class_ref, "setXRange", "(DDI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setXRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_setYRange_DDI;
#pragma warning disable 0169
		static Delegate GetSetYRange_DDIHandler ()
		{
			if (cb_setYRange_DDI == null)
				cb_setYRange_DDI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, int>) n_SetYRange_DDI);
			return cb_setYRange_DDI;
		}

		static void n_SetYRange_DDI (IntPtr jnienv, IntPtr native__this, double p0, double p1, int p2)
		{
			global::Org.Achartengine.Tools.AbstractTool __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.AbstractTool> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYRange (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setYRange_DDI;
		[Register ("setYRange", "(DDI)V", "GetSetYRange_DDIHandler")]
		protected virtual void SetYRange (double p0, double p1, int p2)
		{
			if (id_setYRange_DDI == IntPtr.Zero)
				id_setYRange_DDI = JNIEnv.GetMethodID (class_ref, "setYRange", "(DDI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setYRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setYRange_DDI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	[global::Android.Runtime.Register ("org/achartengine/tools/AbstractTool", DoNotGenerateAcw=true)]
	internal partial class AbstractToolInvoker : AbstractTool {

		public AbstractToolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractToolInvoker); }
		}

	}

}
