using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	[global::Android.Runtime.Register ("org/achartengine/renderer/DefaultRenderer", DoNotGenerateAcw=true)]
	public partial class DefaultRenderer : global::Java.Lang.Object, global::Java.IO.ISerializable {


		[Register ("NO_COLOR")]
		public const int NoColor = (int) 0;

		[Register ("TEXT_COLOR")]
		public const int TextColor = (int) -3355444;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/DefaultRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultRenderer); }
		}

		protected DefaultRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		[Register (".ctor", "()V", "")]
		public DefaultRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultRenderer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "()V"), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_isAntialiasing;
#pragma warning disable 0169
		static Delegate GetIsAntialiasingHandler ()
		{
			if (cb_isAntialiasing == null)
				cb_isAntialiasing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAntialiasing);
			return cb_isAntialiasing;
		}

		static bool n_IsAntialiasing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Antialiasing;
		}
#pragma warning restore 0169

		static Delegate cb_setAntialiasing_Z;
#pragma warning disable 0169
		static Delegate GetSetAntialiasing_ZHandler ()
		{
			if (cb_setAntialiasing_Z == null)
				cb_setAntialiasing_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAntialiasing_Z);
			return cb_setAntialiasing_Z;
		}

		static void n_SetAntialiasing_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Antialiasing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isAntialiasing;
		static IntPtr id_setAntialiasing_Z;
		public virtual bool Antialiasing {
			[Register ("isAntialiasing", "()Z", "GetIsAntialiasingHandler")]
			get {
				if (id_isAntialiasing == IntPtr.Zero)
					id_isAntialiasing = JNIEnv.GetMethodID (class_ref, "isAntialiasing", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAntialiasing);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isAntialiasing);
			}
			[Register ("setAntialiasing", "(Z)V", "GetSetAntialiasing_ZHandler")]
			set {
				if (id_setAntialiasing_Z == IntPtr.Zero)
					id_setAntialiasing_Z = JNIEnv.GetMethodID (class_ref, "setAntialiasing", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAntialiasing_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAntialiasing_Z, new JValue (value));
			}
		}

		static Delegate cb_isApplyBackgroundColor;
#pragma warning disable 0169
		static Delegate GetIsApplyBackgroundColorHandler ()
		{
			if (cb_isApplyBackgroundColor == null)
				cb_isApplyBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsApplyBackgroundColor);
			return cb_isApplyBackgroundColor;
		}

		static bool n_IsApplyBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyBackgroundColor;
		}
#pragma warning restore 0169

		static Delegate cb_setApplyBackgroundColor_Z;
#pragma warning disable 0169
		static Delegate GetSetApplyBackgroundColor_ZHandler ()
		{
			if (cb_setApplyBackgroundColor_Z == null)
				cb_setApplyBackgroundColor_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetApplyBackgroundColor_Z);
			return cb_setApplyBackgroundColor_Z;
		}

		static void n_SetApplyBackgroundColor_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyBackgroundColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isApplyBackgroundColor;
		static IntPtr id_setApplyBackgroundColor_Z;
		public virtual bool ApplyBackgroundColor {
			[Register ("isApplyBackgroundColor", "()Z", "GetIsApplyBackgroundColorHandler")]
			get {
				if (id_isApplyBackgroundColor == IntPtr.Zero)
					id_isApplyBackgroundColor = JNIEnv.GetMethodID (class_ref, "isApplyBackgroundColor", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isApplyBackgroundColor);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isApplyBackgroundColor);
			}
			[Register ("setApplyBackgroundColor", "(Z)V", "GetSetApplyBackgroundColor_ZHandler")]
			set {
				if (id_setApplyBackgroundColor_Z == IntPtr.Zero)
					id_setApplyBackgroundColor_Z = JNIEnv.GetMethodID (class_ref, "setApplyBackgroundColor", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setApplyBackgroundColor_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setApplyBackgroundColor_Z, new JValue (value));
			}
		}

		static Delegate cb_getAxesColor;
#pragma warning disable 0169
		static Delegate GetGetAxesColorHandler ()
		{
			if (cb_getAxesColor == null)
				cb_getAxesColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAxesColor);
			return cb_getAxesColor;
		}

		static int n_GetAxesColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxesColor;
		}
#pragma warning restore 0169

		static Delegate cb_setAxesColor_I;
#pragma warning disable 0169
		static Delegate GetSetAxesColor_IHandler ()
		{
			if (cb_setAxesColor_I == null)
				cb_setAxesColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAxesColor_I);
			return cb_setAxesColor_I;
		}

		static void n_SetAxesColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxesColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAxesColor;
		static IntPtr id_setAxesColor_I;
		public virtual int AxesColor {
			[Register ("getAxesColor", "()I", "GetGetAxesColorHandler")]
			get {
				if (id_getAxesColor == IntPtr.Zero)
					id_getAxesColor = JNIEnv.GetMethodID (class_ref, "getAxesColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAxesColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getAxesColor);
			}
			[Register ("setAxesColor", "(I)V", "GetSetAxesColor_IHandler")]
			set {
				if (id_setAxesColor_I == IntPtr.Zero)
					id_setAxesColor_I = JNIEnv.GetMethodID (class_ref, "setAxesColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAxesColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setAxesColor_I, new JValue (value));
			}
		}

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IHandler ()
		{
			if (cb_setBackgroundColor_I == null)
				cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundColor_I);
			return cb_setBackgroundColor_I;
		}

		static void n_SetBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundColor;
		static IntPtr id_setBackgroundColor_I;
		public virtual int BackgroundColor {
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getBackgroundColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getBackgroundColor);
			}
			[Register ("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler")]
			set {
				if (id_setBackgroundColor_I == IntPtr.Zero)
					id_setBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setBackgroundColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBackgroundColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setBackgroundColor_I, new JValue (value));
			}
		}

		static Delegate cb_getChartTitle;
#pragma warning disable 0169
		static Delegate GetGetChartTitleHandler ()
		{
			if (cb_getChartTitle == null)
				cb_getChartTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartTitle);
			return cb_getChartTitle;
		}

		static IntPtr n_GetChartTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChartTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setChartTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChartTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setChartTitle_Ljava_lang_String_ == null)
				cb_setChartTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChartTitle_Ljava_lang_String_);
			return cb_setChartTitle_Ljava_lang_String_;
		}

		static void n_SetChartTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChartTitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartTitle;
		static IntPtr id_setChartTitle_Ljava_lang_String_;
		public virtual string ChartTitle {
			[Register ("getChartTitle", "()Ljava/lang/String;", "GetGetChartTitleHandler")]
			get {
				if (id_getChartTitle == IntPtr.Zero)
					id_getChartTitle = JNIEnv.GetMethodID (class_ref, "getChartTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getChartTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getChartTitle), JniHandleOwnership.TransferLocalRef);
			}
			[Register ("setChartTitle", "(Ljava/lang/String;)V", "GetSetChartTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setChartTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setChartTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChartTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setChartTitle_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getChartTitleTextSize;
#pragma warning disable 0169
		static Delegate GetGetChartTitleTextSizeHandler ()
		{
			if (cb_getChartTitleTextSize == null)
				cb_getChartTitleTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetChartTitleTextSize);
			return cb_getChartTitleTextSize;
		}

		static float n_GetChartTitleTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChartTitleTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setChartTitleTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetChartTitleTextSize_FHandler ()
		{
			if (cb_setChartTitleTextSize_F == null)
				cb_setChartTitleTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetChartTitleTextSize_F);
			return cb_setChartTitleTextSize_F;
		}

		static void n_SetChartTitleTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChartTitleTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChartTitleTextSize;
		static IntPtr id_setChartTitleTextSize_F;
		public virtual float ChartTitleTextSize {
			[Register ("getChartTitleTextSize", "()F", "GetGetChartTitleTextSizeHandler")]
			get {
				if (id_getChartTitleTextSize == IntPtr.Zero)
					id_getChartTitleTextSize = JNIEnv.GetMethodID (class_ref, "getChartTitleTextSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getChartTitleTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getChartTitleTextSize);
			}
			[Register ("setChartTitleTextSize", "(F)V", "GetSetChartTitleTextSize_FHandler")]
			set {
				if (id_setChartTitleTextSize_F == IntPtr.Zero)
					id_setChartTitleTextSize_F = JNIEnv.GetMethodID (class_ref, "setChartTitleTextSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setChartTitleTextSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setChartTitleTextSize_F, new JValue (value));
			}
		}

		static Delegate cb_isClickEnabled;
#pragma warning disable 0169
		static Delegate GetIsClickEnabledHandler ()
		{
			if (cb_isClickEnabled == null)
				cb_isClickEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClickEnabled);
			return cb_isClickEnabled;
		}

		static bool n_IsClickEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClickEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setClickEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetClickEnabled_ZHandler ()
		{
			if (cb_setClickEnabled_Z == null)
				cb_setClickEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetClickEnabled_Z);
			return cb_setClickEnabled_Z;
		}

		static void n_SetClickEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClickEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isClickEnabled;
		static IntPtr id_setClickEnabled_Z;
		public virtual bool ClickEnabled {
			[Register ("isClickEnabled", "()Z", "GetIsClickEnabledHandler")]
			get {
				if (id_isClickEnabled == IntPtr.Zero)
					id_isClickEnabled = JNIEnv.GetMethodID (class_ref, "isClickEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isClickEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isClickEnabled);
			}
			[Register ("setClickEnabled", "(Z)V", "GetSetClickEnabled_ZHandler")]
			set {
				if (id_setClickEnabled_Z == IntPtr.Zero)
					id_setClickEnabled_Z = JNIEnv.GetMethodID (class_ref, "setClickEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setClickEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setClickEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isExternalZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsExternalZoomEnabledHandler ()
		{
			if (cb_isExternalZoomEnabled == null)
				cb_isExternalZoomEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExternalZoomEnabled);
			return cb_isExternalZoomEnabled;
		}

		static bool n_IsExternalZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExternalZoomEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setExternalZoomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetExternalZoomEnabled_ZHandler ()
		{
			if (cb_setExternalZoomEnabled_Z == null)
				cb_setExternalZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExternalZoomEnabled_Z);
			return cb_setExternalZoomEnabled_Z;
		}

		static void n_SetExternalZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExternalZoomEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isExternalZoomEnabled;
		static IntPtr id_setExternalZoomEnabled_Z;
		public virtual bool ExternalZoomEnabled {
			[Register ("isExternalZoomEnabled", "()Z", "GetIsExternalZoomEnabledHandler")]
			get {
				if (id_isExternalZoomEnabled == IntPtr.Zero)
					id_isExternalZoomEnabled = JNIEnv.GetMethodID (class_ref, "isExternalZoomEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isExternalZoomEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isExternalZoomEnabled);
			}
			[Register ("setExternalZoomEnabled", "(Z)V", "GetSetExternalZoomEnabled_ZHandler")]
			set {
				if (id_setExternalZoomEnabled_Z == IntPtr.Zero)
					id_setExternalZoomEnabled_Z = JNIEnv.GetMethodID (class_ref, "setExternalZoomEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setExternalZoomEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setExternalZoomEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_isFitLegend;
#pragma warning disable 0169
		static Delegate GetIsFitLegendHandler ()
		{
			if (cb_isFitLegend == null)
				cb_isFitLegend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFitLegend);
			return cb_isFitLegend;
		}

		static bool n_IsFitLegend (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FitLegend;
		}
#pragma warning restore 0169

		static Delegate cb_setFitLegend_Z;
#pragma warning disable 0169
		static Delegate GetSetFitLegend_ZHandler ()
		{
			if (cb_setFitLegend_Z == null)
				cb_setFitLegend_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFitLegend_Z);
			return cb_setFitLegend_Z;
		}

		static void n_SetFitLegend_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.FitLegend = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFitLegend;
		static IntPtr id_setFitLegend_Z;
		public virtual bool FitLegend {
			[Register ("isFitLegend", "()Z", "GetIsFitLegendHandler")]
			get {
				if (id_isFitLegend == IntPtr.Zero)
					id_isFitLegend = JNIEnv.GetMethodID (class_ref, "isFitLegend", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFitLegend);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isFitLegend);
			}
			[Register ("setFitLegend", "(Z)V", "GetSetFitLegend_ZHandler")]
			set {
				if (id_setFitLegend_Z == IntPtr.Zero)
					id_setFitLegend_Z = JNIEnv.GetMethodID (class_ref, "setFitLegend", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFitLegend_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setFitLegend_Z, new JValue (value));
			}
		}

		static Delegate cb_isInScroll;
#pragma warning disable 0169
		static Delegate GetIsInScrollHandler ()
		{
			if (cb_isInScroll == null)
				cb_isInScroll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInScroll);
			return cb_isInScroll;
		}

		static bool n_IsInScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InScroll;
		}
#pragma warning restore 0169

		static Delegate cb_setInScroll_Z;
#pragma warning disable 0169
		static Delegate GetSetInScroll_ZHandler ()
		{
			if (cb_setInScroll_Z == null)
				cb_setInScroll_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInScroll_Z);
			return cb_setInScroll_Z;
		}

		static void n_SetInScroll_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.InScroll = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isInScroll;
		static IntPtr id_setInScroll_Z;
		public virtual bool InScroll {
			[Register ("isInScroll", "()Z", "GetIsInScrollHandler")]
			get {
				if (id_isInScroll == IntPtr.Zero)
					id_isInScroll = JNIEnv.GetMethodID (class_ref, "isInScroll", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInScroll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isInScroll);
			}
			[Register ("setInScroll", "(Z)V", "GetSetInScroll_ZHandler")]
			set {
				if (id_setInScroll_Z == IntPtr.Zero)
					id_setInScroll_Z = JNIEnv.GetMethodID (class_ref, "setInScroll", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setInScroll_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setInScroll_Z, new JValue (value));
			}
		}

		static Delegate cb_getLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetLabelsColorHandler ()
		{
			if (cb_getLabelsColor == null)
				cb_getLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLabelsColor);
			return cb_getLabelsColor;
		}

		static int n_GetLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetLabelsColor_IHandler ()
		{
			if (cb_setLabelsColor_I == null)
				cb_setLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLabelsColor_I);
			return cb_setLabelsColor_I;
		}

		static void n_SetLabelsColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LabelsColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabelsColor;
		static IntPtr id_setLabelsColor_I;
		public virtual int LabelsColor {
			[Register ("getLabelsColor", "()I", "GetGetLabelsColorHandler")]
			get {
				if (id_getLabelsColor == IntPtr.Zero)
					id_getLabelsColor = JNIEnv.GetMethodID (class_ref, "getLabelsColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLabelsColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getLabelsColor);
			}
			[Register ("setLabelsColor", "(I)V", "GetSetLabelsColor_IHandler")]
			set {
				if (id_setLabelsColor_I == IntPtr.Zero)
					id_setLabelsColor_I = JNIEnv.GetMethodID (class_ref, "setLabelsColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLabelsColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLabelsColor_I, new JValue (value));
			}
		}

		static Delegate cb_getLabelsTextSize;
#pragma warning disable 0169
		static Delegate GetGetLabelsTextSizeHandler ()
		{
			if (cb_getLabelsTextSize == null)
				cb_getLabelsTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLabelsTextSize);
			return cb_getLabelsTextSize;
		}

		static float n_GetLabelsTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LabelsTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setLabelsTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetLabelsTextSize_FHandler ()
		{
			if (cb_setLabelsTextSize_F == null)
				cb_setLabelsTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLabelsTextSize_F);
			return cb_setLabelsTextSize_F;
		}

		static void n_SetLabelsTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LabelsTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabelsTextSize;
		static IntPtr id_setLabelsTextSize_F;
		public virtual float LabelsTextSize {
			[Register ("getLabelsTextSize", "()F", "GetGetLabelsTextSizeHandler")]
			get {
				if (id_getLabelsTextSize == IntPtr.Zero)
					id_getLabelsTextSize = JNIEnv.GetMethodID (class_ref, "getLabelsTextSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLabelsTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getLabelsTextSize);
			}
			[Register ("setLabelsTextSize", "(F)V", "GetSetLabelsTextSize_FHandler")]
			set {
				if (id_setLabelsTextSize_F == IntPtr.Zero)
					id_setLabelsTextSize_F = JNIEnv.GetMethodID (class_ref, "setLabelsTextSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLabelsTextSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLabelsTextSize_F, new JValue (value));
			}
		}

		static Delegate cb_getLegendHeight;
#pragma warning disable 0169
		static Delegate GetGetLegendHeightHandler ()
		{
			if (cb_getLegendHeight == null)
				cb_getLegendHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLegendHeight);
			return cb_getLegendHeight;
		}

		static int n_GetLegendHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LegendHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setLegendHeight_I;
#pragma warning disable 0169
		static Delegate GetSetLegendHeight_IHandler ()
		{
			if (cb_setLegendHeight_I == null)
				cb_setLegendHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLegendHeight_I);
			return cb_setLegendHeight_I;
		}

		static void n_SetLegendHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LegendHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLegendHeight;
		static IntPtr id_setLegendHeight_I;
		public virtual int LegendHeight {
			[Register ("getLegendHeight", "()I", "GetGetLegendHeightHandler")]
			get {
				if (id_getLegendHeight == IntPtr.Zero)
					id_getLegendHeight = JNIEnv.GetMethodID (class_ref, "getLegendHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLegendHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getLegendHeight);
			}
			[Register ("setLegendHeight", "(I)V", "GetSetLegendHeight_IHandler")]
			set {
				if (id_setLegendHeight_I == IntPtr.Zero)
					id_setLegendHeight_I = JNIEnv.GetMethodID (class_ref, "setLegendHeight", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLegendHeight_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLegendHeight_I, new JValue (value));
			}
		}

		static Delegate cb_getLegendTextSize;
#pragma warning disable 0169
		static Delegate GetGetLegendTextSizeHandler ()
		{
			if (cb_getLegendTextSize == null)
				cb_getLegendTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLegendTextSize);
			return cb_getLegendTextSize;
		}

		static float n_GetLegendTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LegendTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setLegendTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetLegendTextSize_FHandler ()
		{
			if (cb_setLegendTextSize_F == null)
				cb_setLegendTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLegendTextSize_F);
			return cb_setLegendTextSize_F;
		}

		static void n_SetLegendTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.LegendTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLegendTextSize;
		static IntPtr id_setLegendTextSize_F;
		public virtual float LegendTextSize {
			[Register ("getLegendTextSize", "()F", "GetGetLegendTextSizeHandler")]
			get {
				if (id_getLegendTextSize == IntPtr.Zero)
					id_getLegendTextSize = JNIEnv.GetMethodID (class_ref, "getLegendTextSize", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLegendTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getLegendTextSize);
			}
			[Register ("setLegendTextSize", "(F)V", "GetSetLegendTextSize_FHandler")]
			set {
				if (id_setLegendTextSize_F == IntPtr.Zero)
					id_setLegendTextSize_F = JNIEnv.GetMethodID (class_ref, "setLegendTextSize", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLegendTextSize_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setLegendTextSize_F, new JValue (value));
			}
		}

		static Delegate cb_getOriginalScale;
#pragma warning disable 0169
		static Delegate GetGetOriginalScaleHandler ()
		{
			if (cb_getOriginalScale == null)
				cb_getOriginalScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOriginalScale);
			return cb_getOriginalScale;
		}

		static float n_GetOriginalScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OriginalScale;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalScale;
		public virtual float OriginalScale {
			[Register ("getOriginalScale", "()F", "GetGetOriginalScaleHandler")]
			get {
				if (id_getOriginalScale == IntPtr.Zero)
					id_getOriginalScale = JNIEnv.GetMethodID (class_ref, "getOriginalScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getOriginalScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getOriginalScale);
			}
		}

		static Delegate cb_isPanEnabled;
#pragma warning disable 0169
		static Delegate GetIsPanEnabledHandler ()
		{
			if (cb_isPanEnabled == null)
				cb_isPanEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPanEnabled);
			return cb_isPanEnabled;
		}

		static bool n_IsPanEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PanEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setPanEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetPanEnabled_ZHandler ()
		{
			if (cb_setPanEnabled_Z == null)
				cb_setPanEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPanEnabled_Z);
			return cb_setPanEnabled_Z;
		}

		static void n_SetPanEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.PanEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isPanEnabled;
		static IntPtr id_setPanEnabled_Z;
		public virtual bool PanEnabled {
			[Register ("isPanEnabled", "()Z", "GetIsPanEnabledHandler")]
			get {
				if (id_isPanEnabled == IntPtr.Zero)
					id_isPanEnabled = JNIEnv.GetMethodID (class_ref, "isPanEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPanEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isPanEnabled);
			}
			[Register ("setPanEnabled", "(Z)V", "GetSetPanEnabled_ZHandler")]
			set {
				if (id_setPanEnabled_Z == IntPtr.Zero)
					id_setPanEnabled_Z = JNIEnv.GetMethodID (class_ref, "setPanEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPanEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setPanEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		static IntPtr id_setScale_F;
		public virtual float Scale {
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getScale);
			}
			[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
			set {
				if (id_setScale_F == IntPtr.Zero)
					id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setScale_F, new JValue (value));
			}
		}

		static Delegate cb_getSelectableBuffer;
#pragma warning disable 0169
		static Delegate GetGetSelectableBufferHandler ()
		{
			if (cb_getSelectableBuffer == null)
				cb_getSelectableBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectableBuffer);
			return cb_getSelectableBuffer;
		}

		static int n_GetSelectableBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectableBuffer;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectableBuffer_I;
#pragma warning disable 0169
		static Delegate GetSetSelectableBuffer_IHandler ()
		{
			if (cb_setSelectableBuffer_I == null)
				cb_setSelectableBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectableBuffer_I);
			return cb_setSelectableBuffer_I;
		}

		static void n_SetSelectableBuffer_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectableBuffer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectableBuffer;
		static IntPtr id_setSelectableBuffer_I;
		public virtual int SelectableBuffer {
			[Register ("getSelectableBuffer", "()I", "GetGetSelectableBufferHandler")]
			get {
				if (id_getSelectableBuffer == IntPtr.Zero)
					id_getSelectableBuffer = JNIEnv.GetMethodID (class_ref, "getSelectableBuffer", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSelectableBuffer);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSelectableBuffer);
			}
			[Register ("setSelectableBuffer", "(I)V", "GetSetSelectableBuffer_IHandler")]
			set {
				if (id_setSelectableBuffer_I == IntPtr.Zero)
					id_setSelectableBuffer_I = JNIEnv.GetMethodID (class_ref, "setSelectableBuffer", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectableBuffer_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSelectableBuffer_I, new JValue (value));
			}
		}

		static Delegate cb_getSeriesRendererCount;
#pragma warning disable 0169
		static Delegate GetGetSeriesRendererCountHandler ()
		{
			if (cb_getSeriesRendererCount == null)
				cb_getSeriesRendererCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeriesRendererCount);
			return cb_getSeriesRendererCount;
		}

		static int n_GetSeriesRendererCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeriesRendererCount;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesRendererCount;
		public virtual int SeriesRendererCount {
			[Register ("getSeriesRendererCount", "()I", "GetGetSeriesRendererCountHandler")]
			get {
				if (id_getSeriesRendererCount == IntPtr.Zero)
					id_getSeriesRendererCount = JNIEnv.GetMethodID (class_ref, "getSeriesRendererCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSeriesRendererCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getSeriesRendererCount);
			}
		}

		static Delegate cb_isShowAxes;
#pragma warning disable 0169
		static Delegate GetIsShowAxesHandler ()
		{
			if (cb_isShowAxes == null)
				cb_isShowAxes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowAxes);
			return cb_isShowAxes;
		}

		static bool n_IsShowAxes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowAxes;
		}
#pragma warning restore 0169

		static Delegate cb_setShowAxes_Z;
#pragma warning disable 0169
		static Delegate GetSetShowAxes_ZHandler ()
		{
			if (cb_setShowAxes_Z == null)
				cb_setShowAxes_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowAxes_Z);
			return cb_setShowAxes_Z;
		}

		static void n_SetShowAxes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAxes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowAxes;
		static IntPtr id_setShowAxes_Z;
		public virtual bool ShowAxes {
			[Register ("isShowAxes", "()Z", "GetIsShowAxesHandler")]
			get {
				if (id_isShowAxes == IntPtr.Zero)
					id_isShowAxes = JNIEnv.GetMethodID (class_ref, "isShowAxes", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowAxes);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowAxes);
			}
			[Register ("setShowAxes", "(Z)V", "GetSetShowAxes_ZHandler")]
			set {
				if (id_setShowAxes_Z == IntPtr.Zero)
					id_setShowAxes_Z = JNIEnv.GetMethodID (class_ref, "setShowAxes", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowAxes_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowAxes_Z, new JValue (value));
			}
		}

		static Delegate cb_isShowCustomTextGrid;
#pragma warning disable 0169
		static Delegate GetIsShowCustomTextGridHandler ()
		{
			if (cb_isShowCustomTextGrid == null)
				cb_isShowCustomTextGrid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowCustomTextGrid);
			return cb_isShowCustomTextGrid;
		}

		static bool n_IsShowCustomTextGrid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowCustomTextGrid;
		}
#pragma warning restore 0169

		static Delegate cb_setShowCustomTextGrid_Z;
#pragma warning disable 0169
		static Delegate GetSetShowCustomTextGrid_ZHandler ()
		{
			if (cb_setShowCustomTextGrid_Z == null)
				cb_setShowCustomTextGrid_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowCustomTextGrid_Z);
			return cb_setShowCustomTextGrid_Z;
		}

		static void n_SetShowCustomTextGrid_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCustomTextGrid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowCustomTextGrid;
		static IntPtr id_setShowCustomTextGrid_Z;
		public virtual bool ShowCustomTextGrid {
			[Register ("isShowCustomTextGrid", "()Z", "GetIsShowCustomTextGridHandler")]
			get {
				if (id_isShowCustomTextGrid == IntPtr.Zero)
					id_isShowCustomTextGrid = JNIEnv.GetMethodID (class_ref, "isShowCustomTextGrid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowCustomTextGrid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowCustomTextGrid);
			}
			[Register ("setShowCustomTextGrid", "(Z)V", "GetSetShowCustomTextGrid_ZHandler")]
			set {
				if (id_setShowCustomTextGrid_Z == IntPtr.Zero)
					id_setShowCustomTextGrid_Z = JNIEnv.GetMethodID (class_ref, "setShowCustomTextGrid", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowCustomTextGrid_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowCustomTextGrid_Z, new JValue (value));
			}
		}

		static Delegate cb_isShowGridX;
#pragma warning disable 0169
		static Delegate GetIsShowGridXHandler ()
		{
			if (cb_isShowGridX == null)
				cb_isShowGridX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowGridX);
			return cb_isShowGridX;
		}

		static bool n_IsShowGridX (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowGridX;
		}
#pragma warning restore 0169

		static Delegate cb_setShowGridX_Z;
#pragma warning disable 0169
		static Delegate GetSetShowGridX_ZHandler ()
		{
			if (cb_setShowGridX_Z == null)
				cb_setShowGridX_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowGridX_Z);
			return cb_setShowGridX_Z;
		}

		static void n_SetShowGridX_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowGridX = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowGridX;
		static IntPtr id_setShowGridX_Z;
		public virtual bool ShowGridX {
			[Register ("isShowGridX", "()Z", "GetIsShowGridXHandler")]
			get {
				if (id_isShowGridX == IntPtr.Zero)
					id_isShowGridX = JNIEnv.GetMethodID (class_ref, "isShowGridX", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowGridX);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowGridX);
			}
			[Register ("setShowGridX", "(Z)V", "GetSetShowGridX_ZHandler")]
			set {
				if (id_setShowGridX_Z == IntPtr.Zero)
					id_setShowGridX_Z = JNIEnv.GetMethodID (class_ref, "setShowGridX", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowGridX_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowGridX_Z, new JValue (value));
			}
		}

		static Delegate cb_isShowGridY;
#pragma warning disable 0169
		static Delegate GetIsShowGridYHandler ()
		{
			if (cb_isShowGridY == null)
				cb_isShowGridY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowGridY);
			return cb_isShowGridY;
		}

		static bool n_IsShowGridY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowGridY;
		}
#pragma warning restore 0169

		static Delegate cb_setShowGridY_Z;
#pragma warning disable 0169
		static Delegate GetSetShowGridY_ZHandler ()
		{
			if (cb_setShowGridY_Z == null)
				cb_setShowGridY_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowGridY_Z);
			return cb_setShowGridY_Z;
		}

		static void n_SetShowGridY_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowGridY = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowGridY;
		static IntPtr id_setShowGridY_Z;
		public virtual bool ShowGridY {
			[Register ("isShowGridY", "()Z", "GetIsShowGridYHandler")]
			get {
				if (id_isShowGridY == IntPtr.Zero)
					id_isShowGridY = JNIEnv.GetMethodID (class_ref, "isShowGridY", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowGridY);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowGridY);
			}
			[Register ("setShowGridY", "(Z)V", "GetSetShowGridY_ZHandler")]
			set {
				if (id_setShowGridY_Z == IntPtr.Zero)
					id_setShowGridY_Z = JNIEnv.GetMethodID (class_ref, "setShowGridY", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowGridY_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowGridY_Z, new JValue (value));
			}
		}

		static Delegate cb_isShowLabels;
#pragma warning disable 0169
		static Delegate GetIsShowLabelsHandler ()
		{
			if (cb_isShowLabels == null)
				cb_isShowLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowLabels);
			return cb_isShowLabels;
		}

		static bool n_IsShowLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowLabels;
		}
#pragma warning restore 0169

		static Delegate cb_setShowLabels_Z;
#pragma warning disable 0169
		static Delegate GetSetShowLabels_ZHandler ()
		{
			if (cb_setShowLabels_Z == null)
				cb_setShowLabels_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowLabels_Z);
			return cb_setShowLabels_Z;
		}

		static void n_SetShowLabels_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLabels = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowLabels;
		static IntPtr id_setShowLabels_Z;
		public virtual bool ShowLabels {
			[Register ("isShowLabels", "()Z", "GetIsShowLabelsHandler")]
			get {
				if (id_isShowLabels == IntPtr.Zero)
					id_isShowLabels = JNIEnv.GetMethodID (class_ref, "isShowLabels", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowLabels);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowLabels);
			}
			[Register ("setShowLabels", "(Z)V", "GetSetShowLabels_ZHandler")]
			set {
				if (id_setShowLabels_Z == IntPtr.Zero)
					id_setShowLabels_Z = JNIEnv.GetMethodID (class_ref, "setShowLabels", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowLabels_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowLabels_Z, new JValue (value));
			}
		}

		static Delegate cb_isShowLegend;
#pragma warning disable 0169
		static Delegate GetIsShowLegendHandler ()
		{
			if (cb_isShowLegend == null)
				cb_isShowLegend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowLegend);
			return cb_isShowLegend;
		}

		static bool n_IsShowLegend (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowLegend;
		}
#pragma warning restore 0169

		static Delegate cb_setShowLegend_Z;
#pragma warning disable 0169
		static Delegate GetSetShowLegend_ZHandler ()
		{
			if (cb_setShowLegend_Z == null)
				cb_setShowLegend_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowLegend_Z);
			return cb_setShowLegend_Z;
		}

		static void n_SetShowLegend_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowLegend = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShowLegend;
		static IntPtr id_setShowLegend_Z;
		public virtual bool ShowLegend {
			[Register ("isShowLegend", "()Z", "GetIsShowLegendHandler")]
			get {
				if (id_isShowLegend == IntPtr.Zero)
					id_isShowLegend = JNIEnv.GetMethodID (class_ref, "isShowLegend", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowLegend);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isShowLegend);
			}
			[Register ("setShowLegend", "(Z)V", "GetSetShowLegend_ZHandler")]
			set {
				if (id_setShowLegend_Z == IntPtr.Zero)
					id_setShowLegend_Z = JNIEnv.GetMethodID (class_ref, "setShowLegend", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowLegend_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowLegend_Z, new JValue (value));
			}
		}

		static Delegate cb_getStartAngle;
#pragma warning disable 0169
		static Delegate GetGetStartAngleHandler ()
		{
			if (cb_getStartAngle == null)
				cb_getStartAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStartAngle);
			return cb_getStartAngle;
		}

		static float n_GetStartAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setStartAngle_F;
#pragma warning disable 0169
		static Delegate GetSetStartAngle_FHandler ()
		{
			if (cb_setStartAngle_F == null)
				cb_setStartAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStartAngle_F);
			return cb_setStartAngle_F;
		}

		static void n_SetStartAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAngle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartAngle;
		static IntPtr id_setStartAngle_F;
		public virtual float StartAngle {
			[Register ("getStartAngle", "()F", "GetGetStartAngleHandler")]
			get {
				if (id_getStartAngle == IntPtr.Zero)
					id_getStartAngle = JNIEnv.GetMethodID (class_ref, "getStartAngle", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getStartAngle);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getStartAngle);
			}
			[Register ("setStartAngle", "(F)V", "GetSetStartAngle_FHandler")]
			set {
				if (id_setStartAngle_F == IntPtr.Zero)
					id_setStartAngle_F = JNIEnv.GetMethodID (class_ref, "setStartAngle", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStartAngle_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setStartAngle_F, new JValue (value));
			}
		}

		static Delegate cb_getTextTypefaceName;
#pragma warning disable 0169
		static Delegate GetGetTextTypefaceNameHandler ()
		{
			if (cb_getTextTypefaceName == null)
				cb_getTextTypefaceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTypefaceName);
			return cb_getTextTypefaceName;
		}

		static IntPtr n_GetTextTypefaceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TextTypefaceName);
		}
#pragma warning restore 0169

		static IntPtr id_getTextTypefaceName;
		public virtual string TextTypefaceName {
			[Register ("getTextTypefaceName", "()Ljava/lang/String;", "GetGetTextTypefaceNameHandler")]
			get {
				if (id_getTextTypefaceName == IntPtr.Zero)
					id_getTextTypefaceName = JNIEnv.GetMethodID (class_ref, "getTextTypefaceName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTextTypefaceName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getTextTypefaceName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTextTypefaceStyle;
#pragma warning disable 0169
		static Delegate GetGetTextTypefaceStyleHandler ()
		{
			if (cb_getTextTypefaceStyle == null)
				cb_getTextTypefaceStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextTypefaceStyle);
			return cb_getTextTypefaceStyle;
		}

		static int n_GetTextTypefaceStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextTypefaceStyle;
		}
#pragma warning restore 0169

		static IntPtr id_getTextTypefaceStyle;
		public virtual int TextTypefaceStyle {
			[Register ("getTextTypefaceStyle", "()I", "GetGetTextTypefaceStyleHandler")]
			get {
				if (id_getTextTypefaceStyle == IntPtr.Zero)
					id_getTextTypefaceStyle = JNIEnv.GetMethodID (class_ref, "getTextTypefaceStyle", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTextTypefaceStyle);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_getTextTypefaceStyle);
			}
		}

		static Delegate cb_isZoomButtonsVisible;
#pragma warning disable 0169
		static Delegate GetIsZoomButtonsVisibleHandler ()
		{
			if (cb_isZoomButtonsVisible == null)
				cb_isZoomButtonsVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomButtonsVisible);
			return cb_isZoomButtonsVisible;
		}

		static bool n_IsZoomButtonsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomButtonsVisible;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomButtonsVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomButtonsVisible_ZHandler ()
		{
			if (cb_setZoomButtonsVisible_Z == null)
				cb_setZoomButtonsVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomButtonsVisible_Z);
			return cb_setZoomButtonsVisible_Z;
		}

		static void n_SetZoomButtonsVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomButtonsVisible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomButtonsVisible;
		static IntPtr id_setZoomButtonsVisible_Z;
		public virtual bool ZoomButtonsVisible {
			[Register ("isZoomButtonsVisible", "()Z", "GetIsZoomButtonsVisibleHandler")]
			get {
				if (id_isZoomButtonsVisible == IntPtr.Zero)
					id_isZoomButtonsVisible = JNIEnv.GetMethodID (class_ref, "isZoomButtonsVisible", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZoomButtonsVisible);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isZoomButtonsVisible);
			}
			[Register ("setZoomButtonsVisible", "(Z)V", "GetSetZoomButtonsVisible_ZHandler")]
			set {
				if (id_setZoomButtonsVisible_Z == IntPtr.Zero)
					id_setZoomButtonsVisible_Z = JNIEnv.GetMethodID (class_ref, "setZoomButtonsVisible", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomButtonsVisible_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomButtonsVisible_Z, new JValue (value));
			}
		}

		static Delegate cb_isZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsZoomEnabledHandler ()
		{
			if (cb_isZoomEnabled == null)
				cb_isZoomEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomEnabled);
			return cb_isZoomEnabled;
		}

		static bool n_IsZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomEnabled_ZHandler ()
		{
			if (cb_setZoomEnabled_Z == null)
				cb_setZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomEnabled_Z);
			return cb_setZoomEnabled_Z;
		}

		static void n_SetZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomEnabled;
		static IntPtr id_setZoomEnabled_Z;
		public virtual bool ZoomEnabled {
			[Register ("isZoomEnabled", "()Z", "GetIsZoomEnabledHandler")]
			get {
				if (id_isZoomEnabled == IntPtr.Zero)
					id_isZoomEnabled = JNIEnv.GetMethodID (class_ref, "isZoomEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isZoomEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isZoomEnabled);
			}
			[Register ("setZoomEnabled", "(Z)V", "GetSetZoomEnabled_ZHandler")]
			set {
				if (id_setZoomEnabled_Z == IntPtr.Zero)
					id_setZoomEnabled_Z = JNIEnv.GetMethodID (class_ref, "setZoomEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomEnabled_Z, new JValue (value));
			}
		}

		static Delegate cb_getZoomRate;
#pragma warning disable 0169
		static Delegate GetGetZoomRateHandler ()
		{
			if (cb_getZoomRate == null)
				cb_getZoomRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomRate);
			return cb_getZoomRate;
		}

		static float n_GetZoomRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomRate;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomRate_F;
#pragma warning disable 0169
		static Delegate GetSetZoomRate_FHandler ()
		{
			if (cb_setZoomRate_F == null)
				cb_setZoomRate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoomRate_F);
			return cb_setZoomRate_F;
		}

		static void n_SetZoomRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomRate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomRate;
		static IntPtr id_setZoomRate_F;
		public virtual float ZoomRate {
			[Register ("getZoomRate", "()F", "GetGetZoomRateHandler")]
			get {
				if (id_getZoomRate == IntPtr.Zero)
					id_getZoomRate = JNIEnv.GetMethodID (class_ref, "getZoomRate", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZoomRate);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getZoomRate);
			}
			[Register ("setZoomRate", "(F)V", "GetSetZoomRate_FHandler")]
			set {
				if (id_setZoomRate_F == IntPtr.Zero)
					id_setZoomRate_F = JNIEnv.GetMethodID (class_ref, "setZoomRate", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomRate_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomRate_F, new JValue (value));
			}
		}

		static Delegate cb_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_;
#pragma warning disable 0169
		static Delegate GetAddSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_Handler ()
		{
			if (cb_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_ == null)
				cb_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_);
			return cb_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_;
		}

		static void n_AddSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSeriesRenderer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_;
		[Register ("addSeriesRenderer", "(ILorg/achartengine/renderer/SimpleSeriesRenderer;)V", "GetAddSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_Handler")]
		public virtual void AddSeriesRenderer (int p0, global::Org.Achartengine.Renderer.SimpleSeriesRenderer p1)
		{
			if (id_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_ == IntPtr.Zero)
				id_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "addSeriesRenderer", "(ILorg/achartengine/renderer/SimpleSeriesRenderer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addSeriesRenderer_ILorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
#pragma warning disable 0169
		static Delegate GetAddSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler ()
		{
			if (cb_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == null)
				cb_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_);
			return cb_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		}

		static void n_AddSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSeriesRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		[Register ("addSeriesRenderer", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)V", "GetAddSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler")]
		public virtual void AddSeriesRenderer (global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0)
		{
			if (id_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == IntPtr.Zero)
				id_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "addSeriesRenderer", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0));
		}

		static Delegate cb_getMargins;
#pragma warning disable 0169
		static Delegate GetGetMarginsHandler ()
		{
			if (cb_getMargins == null)
				cb_getMargins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMargins);
			return cb_getMargins;
		}

		static IntPtr n_GetMargins (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMargins ());
		}
#pragma warning restore 0169

		static IntPtr id_getMargins;
		[Register ("getMargins", "()[I", "GetGetMarginsHandler")]
		public virtual int[] GetMargins ()
		{
			if (id_getMargins == IntPtr.Zero)
				id_getMargins = JNIEnv.GetMethodID (class_ref, "getMargins", "()[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getMargins), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getMargins), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_getSeriesRendererAt_I;
#pragma warning disable 0169
		static Delegate GetGetSeriesRendererAt_IHandler ()
		{
			if (cb_getSeriesRendererAt_I == null)
				cb_getSeriesRendererAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSeriesRendererAt_I);
			return cb_getSeriesRendererAt_I;
		}

		static IntPtr n_GetSeriesRendererAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSeriesRendererAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesRendererAt_I;
		[Register ("getSeriesRendererAt", "(I)Lorg/achartengine/renderer/SimpleSeriesRenderer;", "GetGetSeriesRendererAt_IHandler")]
		public virtual global::Org.Achartengine.Renderer.SimpleSeriesRenderer GetSeriesRendererAt (int p0)
		{
			if (id_getSeriesRendererAt_I == IntPtr.Zero)
				id_getSeriesRendererAt_I = JNIEnv.GetMethodID (class_ref, "getSeriesRendererAt", "(I)Lorg/achartengine/renderer/SimpleSeriesRenderer;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (JNIEnv.CallObjectMethod  (Handle, id_getSeriesRendererAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSeriesRendererAt_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSeriesRenderers;
#pragma warning disable 0169
		static Delegate GetGetSeriesRenderersHandler ()
		{
			if (cb_getSeriesRenderers == null)
				cb_getSeriesRenderers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeriesRenderers);
			return cb_getSeriesRenderers;
		}

		static IntPtr n_GetSeriesRenderers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSeriesRenderers ());
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesRenderers;
		[Register ("getSeriesRenderers", "()[Lorg/achartengine/renderer/SimpleSeriesRenderer;", "GetGetSeriesRenderersHandler")]
		public virtual global::Org.Achartengine.Renderer.SimpleSeriesRenderer[] GetSeriesRenderers ()
		{
			if (id_getSeriesRenderers == IntPtr.Zero)
				id_getSeriesRenderers = JNIEnv.GetMethodID (class_ref, "getSeriesRenderers", "()[Lorg/achartengine/renderer/SimpleSeriesRenderer;");

			if (GetType () == ThresholdType)
				return (global::Org.Achartengine.Renderer.SimpleSeriesRenderer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSeriesRenderers), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.SimpleSeriesRenderer));
			else
				return (global::Org.Achartengine.Renderer.SimpleSeriesRenderer[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getSeriesRenderers), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.SimpleSeriesRenderer));
		}

		static Delegate cb_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler ()
		{
			if (cb_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == null)
				cb_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_);
			return cb_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		}

		static void n_RemoveSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.SimpleSeriesRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSeriesRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_;
		[Register ("removeSeriesRenderer", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)V", "GetRemoveSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_Handler")]
		public virtual void RemoveSeriesRenderer (global::Org.Achartengine.Renderer.SimpleSeriesRenderer p0)
		{
			if (id_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ == IntPtr.Zero)
				id_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_ = JNIEnv.GetMethodID (class_ref, "removeSeriesRenderer", "(Lorg/achartengine/renderer/SimpleSeriesRenderer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeSeriesRenderer_Lorg_achartengine_renderer_SimpleSeriesRenderer_, new JValue (p0));
		}

		static Delegate cb_setMargins_arrayI;
#pragma warning disable 0169
		static Delegate GetSetMargins_arrayIHandler ()
		{
			if (cb_setMargins_arrayI == null)
				cb_setMargins_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMargins_arrayI);
			return cb_setMargins_arrayI;
		}

		static void n_SetMargins_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetMargins (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMargins_arrayI;
		[Register ("setMargins", "([I)V", "GetSetMargins_arrayIHandler")]
		public virtual void SetMargins (int[] p0)
		{
			if (id_setMargins_arrayI == IntPtr.Zero)
				id_setMargins_arrayI = JNIEnv.GetMethodID (class_ref, "setMargins", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMargins_arrayI, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setMargins_arrayI, new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setShowGrid_Z;
#pragma warning disable 0169
		static Delegate GetSetShowGrid_ZHandler ()
		{
			if (cb_setShowGrid_Z == null)
				cb_setShowGrid_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowGrid_Z);
			return cb_setShowGrid_Z;
		}

		static void n_SetShowGrid_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowGrid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowGrid_Z;
		[Register ("setShowGrid", "(Z)V", "GetSetShowGrid_ZHandler")]
		public virtual void SetShowGrid (bool p0)
		{
			if (id_setShowGrid_Z == IntPtr.Zero)
				id_setShowGrid_Z = JNIEnv.GetMethodID (class_ref, "setShowGrid", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowGrid_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setShowGrid_Z, new JValue (p0));
		}

		static Delegate cb_setTextTypeface_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetTextTypeface_Ljava_lang_String_IHandler ()
		{
			if (cb_setTextTypeface_Ljava_lang_String_I == null)
				cb_setTextTypeface_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetTextTypeface_Ljava_lang_String_I);
			return cb_setTextTypeface_Ljava_lang_String_I;
		}

		static void n_SetTextTypeface_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Achartengine.Renderer.DefaultRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DefaultRenderer> (native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTextTypeface (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setTextTypeface_Ljava_lang_String_I;
		[Register ("setTextTypeface", "(Ljava/lang/String;I)V", "GetSetTextTypeface_Ljava_lang_String_IHandler")]
		public virtual void SetTextTypeface (string p0, int p1)
		{
			if (id_setTextTypeface_Ljava_lang_String_I == IntPtr.Zero)
				id_setTextTypeface_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setTextTypeface", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTextTypeface_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setTextTypeface_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
