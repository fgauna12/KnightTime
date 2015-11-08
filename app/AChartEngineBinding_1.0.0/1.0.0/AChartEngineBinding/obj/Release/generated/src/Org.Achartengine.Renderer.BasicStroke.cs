using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	[global::Android.Runtime.Register ("org/achartengine/renderer/BasicStroke", DoNotGenerateAcw=true)]
	public partial class BasicStroke : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr DASHED_jfieldId;

		[Register ("DASHED")]
		public static global::Org.Achartengine.Renderer.BasicStroke Dashed {
			get {
				if (DASHED_jfieldId == IntPtr.Zero)
					DASHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DASHED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DASHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DASHED_jfieldId == IntPtr.Zero)
					DASHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DASHED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DASHED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DOTTED_jfieldId;

		[Register ("DOTTED")]
		public static global::Org.Achartengine.Renderer.BasicStroke Dotted {
			get {
				if (DOTTED_jfieldId == IntPtr.Zero)
					DOTTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOTTED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOTTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DOTTED_jfieldId == IntPtr.Zero)
					DOTTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOTTED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DOTTED_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr SOLID_jfieldId;

		[Register ("SOLID")]
		public static global::Org.Achartengine.Renderer.BasicStroke Solid {
			get {
				if (SOLID_jfieldId == IntPtr.Zero)
					SOLID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOLID", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOLID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SOLID_jfieldId == IntPtr.Zero)
					SOLID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOLID", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, SOLID_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/renderer/BasicStroke", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicStroke); }
		}

		protected BasicStroke (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF;
		[Register (".ctor", "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V", "")]
		public BasicStroke (global::Android.Graphics.Paint.Cap p0, global::Android.Graphics.Paint.Join p1, float p2, float[] p3, float p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);;
			if (GetType () != typeof (BasicStroke)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				return;
			}

			if (id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF == IntPtr.Zero)
				id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (native_p3), new JValue (p4)), JniHandleOwnership.TransferLocalRef);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getCap;
#pragma warning disable 0169
		static Delegate GetGetCapHandler ()
		{
			if (cb_getCap == null)
				cb_getCap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCap);
			return cb_getCap;
		}

		static IntPtr n_GetCap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cap);
		}
#pragma warning restore 0169

		static IntPtr id_getCap;
		public virtual global::Android.Graphics.Paint.Cap Cap {
			[Register ("getCap", "()Landroid/graphics/Paint$Cap;", "GetGetCapHandler")]
			get {
				if (id_getCap == IntPtr.Zero)
					id_getCap = JNIEnv.GetMethodID (class_ref, "getCap", "()Landroid/graphics/Paint$Cap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Cap> (JNIEnv.CallObjectMethod  (Handle, id_getCap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Cap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCap), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getJoin;
#pragma warning disable 0169
		static Delegate GetGetJoinHandler ()
		{
			if (cb_getJoin == null)
				cb_getJoin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJoin);
			return cb_getJoin;
		}

		static IntPtr n_GetJoin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Join);
		}
#pragma warning restore 0169

		static IntPtr id_getJoin;
		public virtual global::Android.Graphics.Paint.Join Join {
			[Register ("getJoin", "()Landroid/graphics/Paint$Join;", "GetGetJoinHandler")]
			get {
				if (id_getJoin == IntPtr.Zero)
					id_getJoin = JNIEnv.GetMethodID (class_ref, "getJoin", "()Landroid/graphics/Paint$Join;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Join> (JNIEnv.CallObjectMethod  (Handle, id_getJoin), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Join> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getJoin), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMiter;
#pragma warning disable 0169
		static Delegate GetGetMiterHandler ()
		{
			if (cb_getMiter == null)
				cb_getMiter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMiter);
			return cb_getMiter;
		}

		static float n_GetMiter (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Miter;
		}
#pragma warning restore 0169

		static IntPtr id_getMiter;
		public virtual float Miter {
			[Register ("getMiter", "()F", "GetGetMiterHandler")]
			get {
				if (id_getMiter == IntPtr.Zero)
					id_getMiter = JNIEnv.GetMethodID (class_ref, "getMiter", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMiter);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getMiter);
			}
		}

		static Delegate cb_getPhase;
#pragma warning disable 0169
		static Delegate GetGetPhaseHandler ()
		{
			if (cb_getPhase == null)
				cb_getPhase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPhase);
			return cb_getPhase;
		}

		static float n_GetPhase (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Phase;
		}
#pragma warning restore 0169

		static IntPtr id_getPhase;
		public virtual float Phase {
			[Register ("getPhase", "()F", "GetGetPhaseHandler")]
			get {
				if (id_getPhase == IntPtr.Zero)
					id_getPhase = JNIEnv.GetMethodID (class_ref, "getPhase", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getPhase);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, id_getPhase);
			}
		}

		static Delegate cb_getIntervals;
#pragma warning disable 0169
		static Delegate GetGetIntervalsHandler ()
		{
			if (cb_getIntervals == null)
				cb_getIntervals = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntervals);
			return cb_getIntervals;
		}

		static IntPtr n_GetIntervals (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIntervals ());
		}
#pragma warning restore 0169

		static IntPtr id_getIntervals;
		[Register ("getIntervals", "()[F", "GetGetIntervalsHandler")]
		public virtual float[] GetIntervals ()
		{
			if (id_getIntervals == IntPtr.Zero)
				id_getIntervals = JNIEnv.GetMethodID (class_ref, "getIntervals", "()[F");

			if (GetType () == ThresholdType)
				return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getIntervals), JniHandleOwnership.TransferLocalRef, typeof (float));
			else
				return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getIntervals), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

	}
}
