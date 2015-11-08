using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']"
	[global::Android.Runtime.Register ("org/achartengine/util/MathHelper", DoNotGenerateAcw=true)]
	public partial class MathHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']/field[@name='NULL_VALUE']"
		[Register ("NULL_VALUE")]
		public const double NullValue = (double) 1.7976931348623157E308;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/util/MathHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MathHelper); }
		}

		protected MathHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDoubles_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']/method[@name='getDoubles' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("getDoubles", "(Ljava/util/List;)[D", "")]
		public static unsafe double[] GetDoubles (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_getDoubles_Ljava_util_List_ == IntPtr.Zero)
				id_getDoubles_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getDoubles", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoubles_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFloats_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']/method[@name='getFloats' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Float&gt;']]"
		[Register ("getFloats", "(Ljava/util/List;)[F", "")]
		public static unsafe float[] GetFloats (global::System.Collections.Generic.IList<global::Java.Lang.Float> p0)
		{
			if (id_getFloats_Ljava_util_List_ == IntPtr.Zero)
				id_getFloats_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getFloats", "(Ljava/util/List;)[F");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFloats_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLabels_DDI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']/method[@name='getLabels' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int']]"
		[Register ("getLabels", "(DDI)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> GetLabels (double p0, double p1, int p2)
		{
			if (id_getLabels_DDI == IntPtr.Zero)
				id_getLabels_DDI = JNIEnv.GetStaticMethodID (class_ref, "getLabels", "(DDI)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLabels_DDI, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_minmax_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.util']/class[@name='MathHelper']/method[@name='minmax' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("minmax", "(Ljava/util/List;)[D", "")]
		public static unsafe double[] Minmax (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_minmax_Ljava_util_List_ == IntPtr.Zero)
				id_minmax_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "minmax", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_minmax_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (double));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
