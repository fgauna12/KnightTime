using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']"
	[global::Android.Runtime.Register ("org/achartengine/chart/PieMapper", DoNotGenerateAcw=true)]
	public partial class PieMapper : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/PieMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PieMapper); }
		}

		protected PieMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/constructor[@name='PieMapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PieMapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PieMapper)) {
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

		static Delegate cb_addPieSegment_IFFF;
#pragma warning disable 0169
		static Delegate GetAddPieSegment_IFFFHandler ()
		{
			if (cb_addPieSegment_IFFF == null)
				cb_addPieSegment_IFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, float, float>) n_AddPieSegment_IFFF);
			return cb_addPieSegment_IFFF;
		}

		static void n_AddPieSegment_IFFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2, float p3)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPieSegment (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_addPieSegment_IFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='addPieSegment' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("addPieSegment", "(IFFF)V", "GetAddPieSegment_IFFFHandler")]
		public virtual unsafe void AddPieSegment (int p0, float p1, float p2, float p3)
		{
			if (id_addPieSegment_IFFF == IntPtr.Zero)
				id_addPieSegment_IFFF = JNIEnv.GetMethodID (class_ref, "addPieSegment", "(IFFF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addPieSegment_IFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPieSegment", "(IFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_areAllSegmentPresent_I;
#pragma warning disable 0169
		static Delegate GetAreAllSegmentPresent_IHandler ()
		{
			if (cb_areAllSegmentPresent_I == null)
				cb_areAllSegmentPresent_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_AreAllSegmentPresent_I);
			return cb_areAllSegmentPresent_I;
		}

		static bool n_AreAllSegmentPresent_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreAllSegmentPresent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_areAllSegmentPresent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='areAllSegmentPresent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("areAllSegmentPresent", "(I)Z", "GetAreAllSegmentPresent_IHandler")]
		public virtual unsafe bool AreAllSegmentPresent (int p0)
		{
			if (id_areAllSegmentPresent_I == IntPtr.Zero)
				id_areAllSegmentPresent_I = JNIEnv.GetMethodID (class_ref, "areAllSegmentPresent", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_areAllSegmentPresent_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "areAllSegmentPresent", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_clearPieSegments;
#pragma warning disable 0169
		static Delegate GetClearPieSegmentsHandler ()
		{
			if (cb_clearPieSegments == null)
				cb_clearPieSegments = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPieSegments);
			return cb_clearPieSegments;
		}

		static void n_ClearPieSegments (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPieSegments ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPieSegments;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='clearPieSegments' and count(parameter)=0]"
		[Register ("clearPieSegments", "()V", "GetClearPieSegmentsHandler")]
		public virtual unsafe void ClearPieSegments ()
		{
			if (id_clearPieSegments == IntPtr.Zero)
				id_clearPieSegments = JNIEnv.GetMethodID (class_ref, "clearPieSegments", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearPieSegments);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPieSegments", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAngle_Lorg_achartengine_model_Point_;
#pragma warning disable 0169
		static Delegate GetGetAngle_Lorg_achartengine_model_Point_Handler ()
		{
			if (cb_getAngle_Lorg_achartengine_model_Point_ == null)
				cb_getAngle_Lorg_achartengine_model_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_GetAngle_Lorg_achartengine_model_Point_);
			return cb_getAngle_Lorg_achartengine_model_Point_;
		}

		static double n_GetAngle_Lorg_achartengine_model_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.Point p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetAngle (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAngle_Lorg_achartengine_model_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='getAngle' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.Point']]"
		[Register ("getAngle", "(Lorg/achartengine/model/Point;)D", "GetGetAngle_Lorg_achartengine_model_Point_Handler")]
		public virtual unsafe double GetAngle (global::Org.Achartengine.Model.Point p0)
		{
			if (id_getAngle_Lorg_achartengine_model_Point_ == IntPtr.Zero)
				id_getAngle_Lorg_achartengine_model_Point_ = JNIEnv.GetMethodID (class_ref, "getAngle", "(Lorg/achartengine/model/Point;)D");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_getAngle_Lorg_achartengine_model_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAngle", "(Lorg/achartengine/model/Point;)D"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
#pragma warning disable 0169
		static Delegate GetGetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_Handler ()
		{
			if (cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ == null)
				cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_);
			return cb_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
		}

		static IntPtr n_GetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.Point p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSeriesAndPointForScreenCoordinate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='getSeriesAndPointForScreenCoordinate' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.Point']]"
		[Register ("getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;", "GetGetSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_Handler")]
		public virtual unsafe global::Org.Achartengine.Model.SeriesSelection GetSeriesAndPointForScreenCoordinate (global::Org.Achartengine.Model.Point p0)
		{
			if (id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ == IntPtr.Zero)
				id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_ = JNIEnv.GetMethodID (class_ref, "getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Achartengine.Model.SeriesSelection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallObjectMethod  (Handle, id_getSeriesAndPointForScreenCoordinate_Lorg_achartengine_model_Point_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeriesAndPointForScreenCoordinate", "(Lorg/achartengine/model/Point;)Lorg/achartengine/model/SeriesSelection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isOnPieChart_Lorg_achartengine_model_Point_;
#pragma warning disable 0169
		static Delegate GetIsOnPieChart_Lorg_achartengine_model_Point_Handler ()
		{
			if (cb_isOnPieChart_Lorg_achartengine_model_Point_ == null)
				cb_isOnPieChart_Lorg_achartengine_model_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsOnPieChart_Lorg_achartengine_model_Point_);
			return cb_isOnPieChart_Lorg_achartengine_model_Point_;
		}

		static bool n_IsOnPieChart_Lorg_achartengine_model_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Model.Point p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsOnPieChart (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isOnPieChart_Lorg_achartengine_model_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='isOnPieChart' and count(parameter)=1 and parameter[1][@type='org.achartengine.model.Point']]"
		[Register ("isOnPieChart", "(Lorg/achartengine/model/Point;)Z", "GetIsOnPieChart_Lorg_achartengine_model_Point_Handler")]
		public virtual unsafe bool IsOnPieChart (global::Org.Achartengine.Model.Point p0)
		{
			if (id_isOnPieChart_Lorg_achartengine_model_Point_ == IntPtr.Zero)
				id_isOnPieChart_Lorg_achartengine_model_Point_ = JNIEnv.GetMethodID (class_ref, "isOnPieChart", "(Lorg/achartengine/model/Point;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_isOnPieChart_Lorg_achartengine_model_Point_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnPieChart", "(Lorg/achartengine/model/Point;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDimensions_III;
#pragma warning disable 0169
		static Delegate GetSetDimensions_IIIHandler ()
		{
			if (cb_setDimensions_III == null)
				cb_setDimensions_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetDimensions_III);
			return cb_setDimensions_III;
		}

		static void n_SetDimensions_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Achartengine.Chart.PieMapper __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Chart.PieMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setDimensions_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.chart']/class[@name='PieMapper']/method[@name='setDimensions' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setDimensions", "(III)V", "GetSetDimensions_IIIHandler")]
		public virtual unsafe void SetDimensions (int p0, int p1, int p2)
		{
			if (id_setDimensions_III == IntPtr.Zero)
				id_setDimensions_III = JNIEnv.GetMethodID (class_ref, "setDimensions", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDimensions_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDimensions", "(III)V"), __args);
			} finally {
			}
		}

	}
}
