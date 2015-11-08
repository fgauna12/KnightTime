using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']"
	[global::Android.Runtime.Register ("org/achartengine/renderer/BasicStroke", DoNotGenerateAcw=true)]
	public partial class BasicStroke : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr DASHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/field[@name='DASHED']"
		[Register ("DASHED")]
		public static global::Org.Achartengine.Renderer.BasicStroke Dashed {
			get {
				if (DASHED_jfieldId == IntPtr.Zero)
					DASHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DASHED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DASHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOTTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/field[@name='DOTTED']"
		[Register ("DOTTED")]
		public static global::Org.Achartengine.Renderer.BasicStroke Dotted {
			get {
				if (DOTTED_jfieldId == IntPtr.Zero)
					DOTTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOTTED", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOTTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOLID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/field[@name='SOLID']"
		[Register ("SOLID")]
		public static global::Org.Achartengine.Renderer.BasicStroke Solid {
			get {
				if (SOLID_jfieldId == IntPtr.Zero)
					SOLID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOLID", "Lorg/achartengine/renderer/BasicStroke;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOLID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (__ret, JniHandleOwnership.TransferLocalRef);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/constructor[@name='BasicStroke' and count(parameter)=5 and parameter[1][@type='android.graphics.Paint.Cap'] and parameter[2][@type='android.graphics.Paint.Join'] and parameter[3][@type='float'] and parameter[4][@type='float[]'] and parameter[5][@type='float']]"
		[Register (".ctor", "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V", "")]
		public unsafe BasicStroke (global::Android.Graphics.Paint.Cap p0, global::Android.Graphics.Paint.Join p1, float p2, float[] p3, float p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (BasicStroke)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF == IntPtr.Zero)
					id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Paint$Cap;Landroid/graphics/Paint$Join;F[FF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Paint_Cap_Landroid_graphics_Paint_Join_FarrayFF, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
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
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cap);
		}
#pragma warning restore 0169

		static IntPtr id_getCap;
		public virtual unsafe global::Android.Graphics.Paint.Cap Cap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/method[@name='getCap' and count(parameter)=0]"
			[Register ("getCap", "()Landroid/graphics/Paint$Cap;", "GetGetCapHandler")]
			get {
				if (id_getCap == IntPtr.Zero)
					id_getCap = JNIEnv.GetMethodID (class_ref, "getCap", "()Landroid/graphics/Paint$Cap;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Cap> (JNIEnv.CallObjectMethod  (Handle, id_getCap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Cap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCap", "()Landroid/graphics/Paint$Cap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Join);
		}
#pragma warning restore 0169

		static IntPtr id_getJoin;
		public virtual unsafe global::Android.Graphics.Paint.Join Join {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/method[@name='getJoin' and count(parameter)=0]"
			[Register ("getJoin", "()Landroid/graphics/Paint$Join;", "GetGetJoinHandler")]
			get {
				if (id_getJoin == IntPtr.Zero)
					id_getJoin = JNIEnv.GetMethodID (class_ref, "getJoin", "()Landroid/graphics/Paint$Join;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Join> (JNIEnv.CallObjectMethod  (Handle, id_getJoin), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Join> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJoin", "()Landroid/graphics/Paint$Join;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Miter;
		}
#pragma warning restore 0169

		static IntPtr id_getMiter;
		public virtual unsafe float Miter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/method[@name='getMiter' and count(parameter)=0]"
			[Register ("getMiter", "()F", "GetGetMiterHandler")]
			get {
				if (id_getMiter == IntPtr.Zero)
					id_getMiter = JNIEnv.GetMethodID (class_ref, "getMiter", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMiter);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiter", "()F"));
				} finally {
				}
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
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Phase;
		}
#pragma warning restore 0169

		static IntPtr id_getPhase;
		public virtual unsafe float Phase {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/method[@name='getPhase' and count(parameter)=0]"
			[Register ("getPhase", "()F", "GetGetPhaseHandler")]
			get {
				if (id_getPhase == IntPtr.Zero)
					id_getPhase = JNIEnv.GetMethodID (class_ref, "getPhase", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getPhase);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhase", "()F"));
				} finally {
				}
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
			global::Org.Achartengine.Renderer.BasicStroke __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Renderer.BasicStroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIntervals ());
		}
#pragma warning restore 0169

		static IntPtr id_getIntervals;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.renderer']/class[@name='BasicStroke']/method[@name='getIntervals' and count(parameter)=0]"
		[Register ("getIntervals", "()[F", "GetGetIntervalsHandler")]
		public virtual unsafe float[] GetIntervals ()
		{
			if (id_getIntervals == IntPtr.Zero)
				id_getIntervals = JNIEnv.GetMethodID (class_ref, "getIntervals", "()[F");
			try {

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getIntervals), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntervals", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

	}
}
