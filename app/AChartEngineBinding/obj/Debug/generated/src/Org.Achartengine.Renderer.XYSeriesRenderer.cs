using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/XYSeriesRenderer", DoNotGenerateAcw=true)]
	public partial class XYSeriesRenderer : global::Org.Achartengine.Renderer.SimpleSeriesRenderer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/XYSeriesRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XYSeriesRenderer); }
		}

		protected XYSeriesRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/constructor[@name='XYSeriesRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XYSeriesRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (XYSeriesRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_isFillBelowLine;
#pragma warning disable 0169
		static Delegate GetIsFillBelowLineHandler ()
		{
			if (cb_isFillBelowLine == null)
				cb_isFillBelowLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillBelowLine);
			return cb_isFillBelowLine;
		}

		static bool n_IsFillBelowLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillBelowLine;
		}
#pragma warning restore 0169

		static Delegate cb_setFillBelowLine_Z;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLine_ZHandler ()
		{
			if (cb_setFillBelowLine_Z == null)
				cb_setFillBelowLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillBelowLine_Z);
			return cb_setFillBelowLine_Z;
		}

		static void n_SetFillBelowLine_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillBelowLine = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillBelowLine;
		static IntPtr id_setFillBelowLine_Z;
		public virtual unsafe bool FillBelowLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillBelowLine' and count(parameter)=0]"
			[Register ("isFillBelowLine", "()Z", "GetIsFillBelowLineHandler")]
			get {
				if (id_isFillBelowLine == IntPtr.Zero)
					id_isFillBelowLine = JNIEnv.GetMethodID (class_ref, "isFillBelowLine", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFillBelowLine);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFillBelowLine", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillBelowLine", "(Z)V", "GetSetFillBelowLine_ZHandler")]
			set {
				if (id_setFillBelowLine_Z == IntPtr.Zero)
					id_setFillBelowLine_Z = JNIEnv.GetMethodID (class_ref, "setFillBelowLine", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLine_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillBelowLine", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillBelowLineColor;
#pragma warning disable 0169
		static Delegate GetGetFillBelowLineColorHandler ()
		{
			if (cb_getFillBelowLineColor == null)
				cb_getFillBelowLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillBelowLineColor);
			return cb_getFillBelowLineColor;
		}

		static int n_GetFillBelowLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillBelowLineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillBelowLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillBelowLineColor_IHandler ()
		{
			if (cb_setFillBelowLineColor_I == null)
				cb_setFillBelowLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillBelowLineColor_I);
			return cb_setFillBelowLineColor_I;
		}

		static void n_SetFillBelowLineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillBelowLineColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFillBelowLineColor;
		static IntPtr id_setFillBelowLineColor_I;
		public virtual unsafe int FillBelowLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getFillBelowLineColor' and count(parameter)=0]"
			[Register ("getFillBelowLineColor", "()I", "GetGetFillBelowLineColorHandler")]
			get {
				if (id_getFillBelowLineColor == IntPtr.Zero)
					id_getFillBelowLineColor = JNIEnv.GetMethodID (class_ref, "getFillBelowLineColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getFillBelowLineColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillBelowLineColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillBelowLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillBelowLineColor", "(I)V", "GetSetFillBelowLineColor_IHandler")]
			set {
				if (id_setFillBelowLineColor_I == IntPtr.Zero)
					id_setFillBelowLineColor_I = JNIEnv.GetMethodID (class_ref, "setFillBelowLineColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFillBelowLineColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillBelowLineColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFillPoints;
#pragma warning disable 0169
		static Delegate GetIsFillPointsHandler ()
		{
			if (cb_isFillPoints == null)
				cb_isFillPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFillPoints);
			return cb_isFillPoints;
		}

		static bool n_IsFillPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillPoints;
		}
#pragma warning restore 0169

		static Delegate cb_setFillPoints_Z;
#pragma warning disable 0169
		static Delegate GetSetFillPoints_ZHandler ()
		{
			if (cb_setFillPoints_Z == null)
				cb_setFillPoints_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFillPoints_Z);
			return cb_setFillPoints_Z;
		}

		static void n_SetFillPoints_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillPoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFillPoints;
		static IntPtr id_setFillPoints_Z;
		public virtual unsafe bool FillPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='isFillPoints' and count(parameter)=0]"
			[Register ("isFillPoints", "()Z", "GetIsFillPointsHandler")]
			get {
				if (id_isFillPoints == IntPtr.Zero)
					id_isFillPoints = JNIEnv.GetMethodID (class_ref, "isFillPoints", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFillPoints);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFillPoints", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setFillPoints' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFillPoints", "(Z)V", "GetSetFillPoints_ZHandler")]
			set {
				if (id_setFillPoints_Z == IntPtr.Zero)
					id_setFillPoints_Z = JNIEnv.GetMethodID (class_ref, "setFillPoints", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setFillPoints_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillPoints", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLineWidth;
		static IntPtr id_setLineWidth_F;
		public virtual unsafe float LineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getLineWidth' and count(parameter)=0]"
			[Register ("getLineWidth", "()F", "GetGetLineWidthHandler")]
			get {
				if (id_getLineWidth == IntPtr.Zero)
					id_getLineWidth = JNIEnv.GetMethodID (class_ref, "getLineWidth", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getLineWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineWidth", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
			set {
				if (id_setLineWidth_F == IntPtr.Zero)
					id_setLineWidth_F = JNIEnv.GetMethodID (class_ref, "setLineWidth", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setLineWidth_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineWidth", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPointStyle;
#pragma warning disable 0169
		static Delegate GetGetPointStyleHandler ()
		{
			if (cb_getPointStyle == null)
				cb_getPointStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointStyle);
			return cb_getPointStyle;
		}

		static IntPtr n_GetPointStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PointStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
#pragma warning disable 0169
		static Delegate GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler ()
		{
			if (cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ == null)
				cb_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPointStyle_Lorg_achartengine_chart_PointStyle_);
			return cb_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		}

		static void n_SetPointStyle_Lorg_achartengine_chart_PointStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.XYSeriesRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.XYSeriesRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Chart.PointStyle p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PointStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPointStyle;
		static IntPtr id_setPointStyle_Lorg_achartengine_chart_PointStyle_;
		public virtual unsafe global::Org.Achartengine.Chart.PointStyle PointStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='getPointStyle' and count(parameter)=0]"
			[Register ("getPointStyle", "()Lorg/achartengine/chart/PointStyle;", "GetGetPointStyleHandler")]
			get {
				if (id_getPointStyle == IntPtr.Zero)
					id_getPointStyle = JNIEnv.GetMethodID (class_ref, "getPointStyle", "()Lorg/achartengine/chart/PointStyle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallObjectMethod  (Handle, id_getPointStyle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointStyle", "()Lorg/achartengine/chart/PointStyle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer']/method[@name='setPointStyle' and count(parameter)=1 and parameter[1][@type='org.achartengine.chart.PointStyle']]"
			[Register ("setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V", "GetSetPointStyle_Lorg_achartengine_chart_PointStyle_Handler")]
			set {
				if (id_setPointStyle_Lorg_achartengine_chart_PointStyle_ == IntPtr.Zero)
					id_setPointStyle_Lorg_achartengine_chart_PointStyle_ = JNIEnv.GetMethodID (class_ref, "setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPointStyle_Lorg_achartengine_chart_PointStyle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPointStyle", "(Lorg/achartengine/chart/PointStyle;)V"), __args);
				} finally {
				}
			}
		}

	}
}
