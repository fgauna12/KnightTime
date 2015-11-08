using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/DialRenderer", DoNotGenerateAcw=true)]
	public partial class DialRenderer : global::Org.Achartengine.Renderer.DefaultRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer.Type']"
		[global::Android.Runtime.Register ("org/achartengine/renderer/DialRenderer$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr ARROW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer.Type']/field[@name='ARROW']"
			[Register ("ARROW")]
			public static global::Org.Achartengine.Renderer.DialRenderer.Type Arrow {
				get {
					if (ARROW_jfieldId == IntPtr.Zero)
						ARROW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARROW", "Lorg/achartengine/renderer/DialRenderer$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARROW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEEDLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer.Type']/field[@name='NEEDLE']"
			[Register ("NEEDLE")]
			public static global::Org.Achartengine.Renderer.DialRenderer.Type Needle {
				get {
					if (NEEDLE_jfieldId == IntPtr.Zero)
						NEEDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEEDLE", "Lorg/achartengine/renderer/DialRenderer$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEEDLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/achartengine/renderer/DialRenderer$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/DialRenderer$Type;", "")]
			public static unsafe global::Org.Achartengine.Renderer.DialRenderer.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/renderer/DialRenderer$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Achartengine.Renderer.DialRenderer.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/achartengine/renderer/DialRenderer$Type;", "")]
			public static unsafe global::Org.Achartengine.Renderer.DialRenderer.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/renderer/DialRenderer$Type;");
				try {
					return (global::Org.Achartengine.Renderer.DialRenderer.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Renderer.DialRenderer.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/DialRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DialRenderer); }
		}

		protected DialRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/constructor[@name='DialRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DialRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DialRenderer)) {
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

		static Delegate cb_getAngleMax;
#pragma warning disable 0169
		static Delegate GetGetAngleMaxHandler ()
		{
			if (cb_getAngleMax == null)
				cb_getAngleMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAngleMax);
			return cb_getAngleMax;
		}

		static double n_GetAngleMax (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AngleMax;
		}
#pragma warning restore 0169

		static Delegate cb_setAngleMax_D;
#pragma warning disable 0169
		static Delegate GetSetAngleMax_DHandler ()
		{
			if (cb_setAngleMax_D == null)
				cb_setAngleMax_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetAngleMax_D);
			return cb_setAngleMax_D;
		}

		static void n_SetAngleMax_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AngleMax = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAngleMax;
		static IntPtr id_setAngleMax_D;
		public virtual unsafe double AngleMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getAngleMax' and count(parameter)=0]"
			[Register ("getAngleMax", "()D", "GetGetAngleMaxHandler")]
			get {
				if (id_getAngleMax == IntPtr.Zero)
					id_getAngleMax = JNIEnv.GetMethodID (class_ref, "getAngleMax", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getAngleMax);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAngleMax", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setAngleMax' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAngleMax", "(D)V", "GetSetAngleMax_DHandler")]
			set {
				if (id_setAngleMax_D == IntPtr.Zero)
					id_setAngleMax_D = JNIEnv.GetMethodID (class_ref, "setAngleMax", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAngleMax_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAngleMax", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAngleMin;
#pragma warning disable 0169
		static Delegate GetGetAngleMinHandler ()
		{
			if (cb_getAngleMin == null)
				cb_getAngleMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAngleMin);
			return cb_getAngleMin;
		}

		static double n_GetAngleMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AngleMin;
		}
#pragma warning restore 0169

		static Delegate cb_setAngleMin_D;
#pragma warning disable 0169
		static Delegate GetSetAngleMin_DHandler ()
		{
			if (cb_setAngleMin_D == null)
				cb_setAngleMin_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetAngleMin_D);
			return cb_setAngleMin_D;
		}

		static void n_SetAngleMin_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AngleMin = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAngleMin;
		static IntPtr id_setAngleMin_D;
		public virtual unsafe double AngleMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getAngleMin' and count(parameter)=0]"
			[Register ("getAngleMin", "()D", "GetGetAngleMinHandler")]
			get {
				if (id_getAngleMin == IntPtr.Zero)
					id_getAngleMin = JNIEnv.GetMethodID (class_ref, "getAngleMin", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getAngleMin);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAngleMin", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setAngleMin' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAngleMin", "(D)V", "GetSetAngleMin_DHandler")]
			set {
				if (id_setAngleMin_D == IntPtr.Zero)
					id_setAngleMin_D = JNIEnv.GetMethodID (class_ref, "setAngleMin", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAngleMin_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAngleMin", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMaxValueSet;
#pragma warning disable 0169
		static Delegate GetIsMaxValueSetHandler ()
		{
			if (cb_isMaxValueSet == null)
				cb_isMaxValueSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMaxValueSet);
			return cb_isMaxValueSet;
		}

		static bool n_IsMaxValueSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMaxValueSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMaxValueSet;
		public virtual unsafe bool IsMaxValueSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='isMaxValueSet' and count(parameter)=0]"
			[Register ("isMaxValueSet", "()Z", "GetIsMaxValueSetHandler")]
			get {
				if (id_isMaxValueSet == IntPtr.Zero)
					id_isMaxValueSet = JNIEnv.GetMethodID (class_ref, "isMaxValueSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMaxValueSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMaxValueSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMinValueSet;
#pragma warning disable 0169
		static Delegate GetIsMinValueSetHandler ()
		{
			if (cb_isMinValueSet == null)
				cb_isMinValueSet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMinValueSet);
			return cb_isMinValueSet;
		}

		static bool n_IsMinValueSet (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMinValueSet;
		}
#pragma warning restore 0169

		static IntPtr id_isMinValueSet;
		public virtual unsafe bool IsMinValueSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='isMinValueSet' and count(parameter)=0]"
			[Register ("isMinValueSet", "()Z", "GetIsMinValueSetHandler")]
			get {
				if (id_isMinValueSet == IntPtr.Zero)
					id_isMinValueSet = JNIEnv.GetMethodID (class_ref, "isMinValueSet", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMinValueSet);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMinValueSet", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMajorTicksSpacing;
#pragma warning disable 0169
		static Delegate GetGetMajorTicksSpacingHandler ()
		{
			if (cb_getMajorTicksSpacing == null)
				cb_getMajorTicksSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMajorTicksSpacing);
			return cb_getMajorTicksSpacing;
		}

		static double n_GetMajorTicksSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MajorTicksSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setMajorTicksSpacing_D;
#pragma warning disable 0169
		static Delegate GetSetMajorTicksSpacing_DHandler ()
		{
			if (cb_setMajorTicksSpacing_D == null)
				cb_setMajorTicksSpacing_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMajorTicksSpacing_D);
			return cb_setMajorTicksSpacing_D;
		}

		static void n_SetMajorTicksSpacing_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MajorTicksSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMajorTicksSpacing;
		static IntPtr id_setMajorTicksSpacing_D;
		public virtual unsafe double MajorTicksSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getMajorTicksSpacing' and count(parameter)=0]"
			[Register ("getMajorTicksSpacing", "()D", "GetGetMajorTicksSpacingHandler")]
			get {
				if (id_getMajorTicksSpacing == IntPtr.Zero)
					id_getMajorTicksSpacing = JNIEnv.GetMethodID (class_ref, "getMajorTicksSpacing", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMajorTicksSpacing);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMajorTicksSpacing", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setMajorTicksSpacing' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMajorTicksSpacing", "(D)V", "GetSetMajorTicksSpacing_DHandler")]
			set {
				if (id_setMajorTicksSpacing_D == IntPtr.Zero)
					id_setMajorTicksSpacing_D = JNIEnv.GetMethodID (class_ref, "setMajorTicksSpacing", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMajorTicksSpacing_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMajorTicksSpacing", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxValue;
#pragma warning disable 0169
		static Delegate GetGetMaxValueHandler ()
		{
			if (cb_getMaxValue == null)
				cb_getMaxValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxValue);
			return cb_getMaxValue;
		}

		static double n_GetMaxValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxValue;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxValue_D;
#pragma warning disable 0169
		static Delegate GetSetMaxValue_DHandler ()
		{
			if (cb_setMaxValue_D == null)
				cb_setMaxValue_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxValue_D);
			return cb_setMaxValue_D;
		}

		static void n_SetMaxValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxValue;
		static IntPtr id_setMaxValue_D;
		public virtual unsafe double MaxValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getMaxValue' and count(parameter)=0]"
			[Register ("getMaxValue", "()D", "GetGetMaxValueHandler")]
			get {
				if (id_getMaxValue == IntPtr.Zero)
					id_getMaxValue = JNIEnv.GetMethodID (class_ref, "getMaxValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMaxValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxValue", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setMaxValue' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxValue", "(D)V", "GetSetMaxValue_DHandler")]
			set {
				if (id_setMaxValue_D == IntPtr.Zero)
					id_setMaxValue_D = JNIEnv.GetMethodID (class_ref, "setMaxValue", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMaxValue_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxValue", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinValue;
#pragma warning disable 0169
		static Delegate GetGetMinValueHandler ()
		{
			if (cb_getMinValue == null)
				cb_getMinValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinValue);
			return cb_getMinValue;
		}

		static double n_GetMinValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinValue;
		}
#pragma warning restore 0169

		static Delegate cb_setMinValue_D;
#pragma warning disable 0169
		static Delegate GetSetMinValue_DHandler ()
		{
			if (cb_setMinValue_D == null)
				cb_setMinValue_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinValue_D);
			return cb_setMinValue_D;
		}

		static void n_SetMinValue_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinValue;
		static IntPtr id_setMinValue_D;
		public virtual unsafe double MinValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getMinValue' and count(parameter)=0]"
			[Register ("getMinValue", "()D", "GetGetMinValueHandler")]
			get {
				if (id_getMinValue == IntPtr.Zero)
					id_getMinValue = JNIEnv.GetMethodID (class_ref, "getMinValue", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinValue);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinValue", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setMinValue' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinValue", "(D)V", "GetSetMinValue_DHandler")]
			set {
				if (id_setMinValue_D == IntPtr.Zero)
					id_setMinValue_D = JNIEnv.GetMethodID (class_ref, "setMinValue", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinValue_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinValue", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinorTicksSpacing;
#pragma warning disable 0169
		static Delegate GetGetMinorTicksSpacingHandler ()
		{
			if (cb_getMinorTicksSpacing == null)
				cb_getMinorTicksSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinorTicksSpacing);
			return cb_getMinorTicksSpacing;
		}

		static double n_GetMinorTicksSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinorTicksSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setMinorTicksSpacing_D;
#pragma warning disable 0169
		static Delegate GetSetMinorTicksSpacing_DHandler ()
		{
			if (cb_setMinorTicksSpacing_D == null)
				cb_setMinorTicksSpacing_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinorTicksSpacing_D);
			return cb_setMinorTicksSpacing_D;
		}

		static void n_SetMinorTicksSpacing_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinorTicksSpacing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinorTicksSpacing;
		static IntPtr id_setMinorTicksSpacing_D;
		public virtual unsafe double MinorTicksSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getMinorTicksSpacing' and count(parameter)=0]"
			[Register ("getMinorTicksSpacing", "()D", "GetGetMinorTicksSpacingHandler")]
			get {
				if (id_getMinorTicksSpacing == IntPtr.Zero)
					id_getMinorTicksSpacing = JNIEnv.GetMethodID (class_ref, "getMinorTicksSpacing", "()D");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod  (Handle, id_getMinorTicksSpacing);
					else
						return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinorTicksSpacing", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setMinorTicksSpacing' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinorTicksSpacing", "(D)V", "GetSetMinorTicksSpacing_DHandler")]
			set {
				if (id_setMinorTicksSpacing_D == IntPtr.Zero)
					id_setMinorTicksSpacing_D = JNIEnv.GetMethodID (class_ref, "setMinorTicksSpacing", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMinorTicksSpacing_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinorTicksSpacing", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisualTypeForIndex_I;
#pragma warning disable 0169
		static Delegate GetGetVisualTypeForIndex_IHandler ()
		{
			if (cb_getVisualTypeForIndex_I == null)
				cb_getVisualTypeForIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetVisualTypeForIndex_I);
			return cb_getVisualTypeForIndex_I;
		}

		static IntPtr n_GetVisualTypeForIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVisualTypeForIndex (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getVisualTypeForIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='getVisualTypeForIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVisualTypeForIndex", "(I)Lorg/achartengine/renderer/DialRenderer$Type;", "GetGetVisualTypeForIndex_IHandler")]
		public virtual unsafe global::Org.Achartengine.Renderer.DialRenderer.Type GetVisualTypeForIndex (int p0)
		{
			if (id_getVisualTypeForIndex_I == IntPtr.Zero)
				id_getVisualTypeForIndex_I = JNIEnv.GetMethodID (class_ref, "getVisualTypeForIndex", "(I)Lorg/achartengine/renderer/DialRenderer$Type;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer.Type> (JNIEnv.CallObjectMethod  (Handle, id_getVisualTypeForIndex_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer.Type> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisualTypeForIndex", "(I)Lorg/achartengine/renderer/DialRenderer$Type;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_;
#pragma warning disable 0169
		static Delegate GetSetVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_Handler ()
		{
			if (cb_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_ == null)
				cb_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_);
			return cb_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_;
		}

		static void n_SetVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Renderer.DialRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.DialRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Renderer.DialRenderer.Type[] p0 = (global::Org.Achartengine.Renderer.DialRenderer.Type[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Achartengine.Renderer.DialRenderer.Type));
			__this.SetVisualTypes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='DialRenderer']/method[@name='setVisualTypes' and count(parameter)=1 and parameter[1][@type='org.achartengine.renderer.DialRenderer.Type[]']]"
		[Register ("setVisualTypes", "([Lorg/achartengine/renderer/DialRenderer$Type;)V", "GetSetVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_Handler")]
		public virtual unsafe void SetVisualTypes (global::Org.Achartengine.Renderer.DialRenderer.Type[] p0)
		{
			if (id_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_ == IntPtr.Zero)
				id_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_ = JNIEnv.GetMethodID (class_ref, "setVisualTypes", "([Lorg/achartengine/renderer/DialRenderer$Type;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVisualTypes_arrayLorg_achartengine_renderer_DialRenderer_Type_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisualTypes", "([Lorg/achartengine/renderer/DialRenderer$Type;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
