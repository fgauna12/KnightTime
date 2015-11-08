using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Util {

	[global::Android.Runtime.Register ("org/achartengine/util/MathHelper", DoNotGenerateAcw=true)]
	public partial class MathHelper : global::Java.Lang.Object {


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
		[Register ("getDoubles", "(Ljava/util/List;)[D", "")]
		public static double[] GetDoubles (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_getDoubles_Ljava_util_List_ == IntPtr.Zero)
				id_getDoubles_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getDoubles", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDoubles_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getFloats_Ljava_util_List_;
		[Register ("getFloats", "(Ljava/util/List;)[F", "")]
		public static float[] GetFloats (global::System.Collections.Generic.IList<global::Java.Lang.Float> p0)
		{
			if (id_getFloats_Ljava_util_List_ == IntPtr.Zero)
				id_getFloats_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getFloats", "(Ljava/util/List;)[F");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (p0);
			float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFloats_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (float));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getLabels_DDI;
		[Register ("getLabels", "(DDI)Ljava/util/List;", "")]
		public static global::System.Collections.Generic.IList<global::Java.Lang.Double> GetLabels (double p0, double p1, int p2)
		{
			if (id_getLabels_DDI == IntPtr.Zero)
				id_getLabels_DDI = JNIEnv.GetStaticMethodID (class_ref, "getLabels", "(DDI)Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLabels_DDI, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_minmax_Ljava_util_List_;
		[Register ("minmax", "(Ljava/util/List;)[D", "")]
		public static double[] Minmax (global::System.Collections.Generic.IList<global::Java.Lang.Double> p0)
		{
			if (id_minmax_Ljava_util_List_ == IntPtr.Zero)
				id_minmax_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "minmax", "(Ljava/util/List;)[D");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (p0);
			double[] __ret = (double[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_minmax_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
