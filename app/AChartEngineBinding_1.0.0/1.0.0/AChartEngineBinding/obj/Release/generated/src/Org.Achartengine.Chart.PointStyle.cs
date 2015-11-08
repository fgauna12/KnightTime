using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	[global::Android.Runtime.Register ("org/achartengine/chart/PointStyle", DoNotGenerateAcw=true)]
	public sealed partial class PointStyle : global::Java.Lang.Enum {


		static IntPtr CIRCLE_jfieldId;

		[Register ("CIRCLE")]
		public static global::Org.Achartengine.Chart.PointStyle Circle {
			get {
				if (CIRCLE_jfieldId == IntPtr.Zero)
					CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CIRCLE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CIRCLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CIRCLE_jfieldId == IntPtr.Zero)
					CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CIRCLE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CIRCLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DIAMOND_jfieldId;

		[Register ("DIAMOND")]
		public static global::Org.Achartengine.Chart.PointStyle Diamond {
			get {
				if (DIAMOND_jfieldId == IntPtr.Zero)
					DIAMOND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIAMOND", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIAMOND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIAMOND_jfieldId == IntPtr.Zero)
					DIAMOND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIAMOND", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DIAMOND_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr POINT_jfieldId;

		[Register ("POINT")]
		public static global::Org.Achartengine.Chart.PointStyle Point {
			get {
				if (POINT_jfieldId == IntPtr.Zero)
					POINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POINT", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POINT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POINT_jfieldId == IntPtr.Zero)
					POINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POINT", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, POINT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SQUARE_jfieldId;

		[Register ("SQUARE")]
		public static global::Org.Achartengine.Chart.PointStyle Square {
			get {
				if (SQUARE_jfieldId == IntPtr.Zero)
					SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUARE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SQUARE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SQUARE_jfieldId == IntPtr.Zero)
					SQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SQUARE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SQUARE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr TRIANGLE_jfieldId;

		[Register ("TRIANGLE")]
		public static global::Org.Achartengine.Chart.PointStyle Triangle {
			get {
				if (TRIANGLE_jfieldId == IntPtr.Zero)
					TRIANGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRIANGLE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRIANGLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TRIANGLE_jfieldId == IntPtr.Zero)
					TRIANGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRIANGLE", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, TRIANGLE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr X_jfieldId;

		[Register ("X")]
		public static global::Org.Achartengine.Chart.PointStyle X {
			get {
				if (X_jfieldId == IntPtr.Zero)
					X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "X", "Lorg/achartengine/chart/PointStyle;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, X_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (X_jfieldId == IntPtr.Zero)
					X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "X", "Lorg/achartengine/chart/PointStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, X_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/PointStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PointStyle); }
		}

		internal PointStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getName;
		public string Name {
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getIndexForName_Ljava_lang_String_;
		[Register ("getIndexForName", "(Ljava/lang/String;)I", "")]
		public static int GetIndexForName (string p0)
		{
			if (id_getIndexForName_Ljava_lang_String_ == IntPtr.Zero)
				id_getIndexForName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getIndexForName", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getIndexForName_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getPointStyleForName_Ljava_lang_String_;
		[Register ("getPointStyleForName", "(Ljava/lang/String;)Lorg/achartengine/chart/PointStyle;", "")]
		public static global::Org.Achartengine.Chart.PointStyle GetPointStyleForName (string p0)
		{
			if (id_getPointStyleForName_Ljava_lang_String_ == IntPtr.Zero)
				id_getPointStyleForName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPointStyleForName", "(Ljava/lang/String;)Lorg/achartengine/chart/PointStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Achartengine.Chart.PointStyle __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPointStyleForName_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/achartengine/chart/PointStyle;", "")]
		public static global::Org.Achartengine.Chart.PointStyle ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/achartengine/chart/PointStyle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Org.Achartengine.Chart.PointStyle __ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PointStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		[Register ("values", "()[Lorg/achartengine/chart/PointStyle;", "")]
		public static global::Org.Achartengine.Chart.PointStyle[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/achartengine/chart/PointStyle;");
			return (global::Org.Achartengine.Chart.PointStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Achartengine.Chart.PointStyle));
		}

	}
}
