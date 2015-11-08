using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	[global::Android.Runtime.Register ("org/achartengine/chart/TimeChart", DoNotGenerateAcw=true)]
	public partial class TimeChart : global::Org.Achartengine.Chart.LineChart {


		[Register ("DAY")]
		public const long Day = (long) 86400000L;

		[Register ("TYPE")]
		public const string Type = (string) "Time";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/TimeChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeChart); }
		}

		protected TimeChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_;
		[Register (".ctor", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", "")]
		public TimeChart (global::Org.Achartengine.Model.XYMultipleSeriesDataset p0, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TimeChart)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getDateFormat;
#pragma warning disable 0169
		static Delegate GetGetDateFormatHandler ()
		{
			if (cb_getDateFormat == null)
				cb_getDateFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDateFormat);
			return cb_getDateFormat;
		}

		static IntPtr n_GetDateFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.TimeChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.TimeChart> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DateFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setDateFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDateFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setDateFormat_Ljava_lang_String_ == null)
				cb_setDateFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDateFormat_Ljava_lang_String_);
			return cb_setDateFormat_Ljava_lang_String_;
		}

		static void n_SetDateFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.TimeChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.TimeChart> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DateFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDateFormat;
		static IntPtr id_setDateFormat_Ljava_lang_String_;
		public virtual string DateFormat {
			[Register ("getDateFormat", "()Ljava/lang/String;", "GetGetDateFormatHandler")]
			get {
				if (id_getDateFormat == IntPtr.Zero)
					id_getDateFormat = JNIEnv.GetMethodID (class_ref, "getDateFormat", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDateFormat), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getDateFormat), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setDateFormat", "(Ljava/lang/String;)V", "GetSetDateFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setDateFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setDateFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDateFormat_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDateFormat_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isXAxisSmart;
#pragma warning disable 0169
		static Delegate GetIsXAxisSmartHandler ()
		{
			if (cb_isXAxisSmart == null)
				cb_isXAxisSmart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsXAxisSmart);
			return cb_isXAxisSmart;
		}

		static bool n_IsXAxisSmart (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.TimeChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.TimeChart> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XAxisSmart;
		}
#pragma warning restore 0169

		static Delegate cb_setXAxisSmart_Z;
#pragma warning disable 0169
		static Delegate GetSetXAxisSmart_ZHandler ()
		{
			if (cb_setXAxisSmart_Z == null)
				cb_setXAxisSmart_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetXAxisSmart_Z);
			return cb_setXAxisSmart_Z;
		}

		static void n_SetXAxisSmart_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Chart.TimeChart __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.TimeChart> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.XAxisSmart = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isXAxisSmart;
		static IntPtr id_setXAxisSmart_Z;
		public virtual bool XAxisSmart {
			[Register ("isXAxisSmart", "()Z", "GetIsXAxisSmartHandler")]
			get {
				if (id_isXAxisSmart == IntPtr.Zero)
					id_isXAxisSmart = JNIEnv.GetMethodID (class_ref, "isXAxisSmart", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isXAxisSmart);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isXAxisSmart);
			}
			[Register ("setXAxisSmart", "(Z)V", "GetSetXAxisSmart_ZHandler")]
			set {
				if (id_setXAxisSmart_Z == IntPtr.Zero)
					id_setXAxisSmart_Z = JNIEnv.GetMethodID (class_ref, "setXAxisSmart", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setXAxisSmart_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setXAxisSmart_Z, new JValue (value));
			}
		}

	}
}
