using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']"
	[global::Android.Runtime.Register ("org/achartengine/chart/PieSegment", DoNotGenerateAcw=true)]
	public partial class PieSegment : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/PieSegment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PieSegment); }
		}

		protected PieSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/constructor[@name='PieSegment' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(IFFF)V", "")]
		public unsafe PieSegment (int p0, float p1, float p2, float p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (PieSegment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IFFF)V", __args);
					return;
				}

				if (id_ctor_IFFF == IntPtr.Zero)
					id_ctor_IFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(IFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IFFF, __args);
			} finally {
			}
		}

		static Delegate cb_getDataIndex;
#pragma warning disable 0169
		static Delegate GetGetDataIndexHandler ()
		{
			if (cb_getDataIndex == null)
				cb_getDataIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataIndex);
			return cb_getDataIndex;
		}

		static int n_GetDataIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.PieSegment __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getDataIndex;
		protected virtual unsafe int DataIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/method[@name='getDataIndex' and count(parameter)=0]"
			[Register ("getDataIndex", "()I", "GetGetDataIndexHandler")]
			get {
				if (id_getDataIndex == IntPtr.Zero)
					id_getDataIndex = JNIEnv.GetMethodID (class_ref, "getDataIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDataIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEndAngle;
#pragma warning disable 0169
		static Delegate GetGetEndAngleHandler ()
		{
			if (cb_getEndAngle == null)
				cb_getEndAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetEndAngle);
			return cb_getEndAngle;
		}

		static float n_GetEndAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.PieSegment __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndAngle;
		}
#pragma warning restore 0169

		static IntPtr id_getEndAngle;
		protected virtual unsafe float EndAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/method[@name='getEndAngle' and count(parameter)=0]"
			[Register ("getEndAngle", "()F", "GetGetEndAngleHandler")]
			get {
				if (id_getEndAngle == IntPtr.Zero)
					id_getEndAngle = JNIEnv.GetMethodID (class_ref, "getEndAngle", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getEndAngle);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndAngle", "()F"));
				} finally {
				}
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
			global::Org.Achartengine.Chart.PieSegment __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartAngle;
		}
#pragma warning restore 0169

		static IntPtr id_getStartAngle;
		protected virtual unsafe float StartAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/method[@name='getStartAngle' and count(parameter)=0]"
			[Register ("getStartAngle", "()F", "GetGetStartAngleHandler")]
			get {
				if (id_getStartAngle == IntPtr.Zero)
					id_getStartAngle = JNIEnv.GetMethodID (class_ref, "getStartAngle", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getStartAngle);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartAngle", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValue);
			return cb_getValue;
		}

		static float n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.PieSegment __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		protected virtual unsafe float Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()F", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getValue);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_isInSegment_D;
#pragma warning disable 0169
		static Delegate GetIsInSegment_DHandler ()
		{
			if (cb_isInSegment_D == null)
				cb_isInSegment_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool>) n_IsInSegment_D);
			return cb_isInSegment_D;
		}

		static bool n_IsInSegment_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Achartengine.Chart.PieSegment __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInSegment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isInSegment_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieSegment']/method[@name='isInSegment' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("isInSegment", "(D)Z", "GetIsInSegment_DHandler")]
		public virtual unsafe bool IsInSegment (double p0)
		{
			if (id_isInSegment_D == IntPtr.Zero)
				id_isInSegment_D = JNIEnv.GetMethodID (class_ref, "isInSegment", "(D)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInSegment_D, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInSegment", "(D)Z"), __args);
			} finally {
			}
		}

	}
}
