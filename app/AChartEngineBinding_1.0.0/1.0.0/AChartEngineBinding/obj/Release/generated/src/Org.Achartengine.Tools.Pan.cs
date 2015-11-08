using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	[global::Android.Runtime.Register ("org/achartengine/tools/Pan", DoNotGenerateAcw=true)]
	public partial class Pan : global::Org.Achartengine.Tools.AbstractTool {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/tools/Pan", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pan); }
		}

		protected Pan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_chart_AbstractChart_;
		[Register (".ctor", "(Lorg/achartengine/chart/AbstractChart;)V", "")]
		public Pan (global::Org.Achartengine.Chart.AbstractChart p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Pan)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/chart/AbstractChart;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/chart/AbstractChart;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_addPanListener_Lorg_achartengine_tools_PanListener_;
#pragma warning disable 0169
		static Delegate GetAddPanListener_Lorg_achartengine_tools_PanListener_Handler ()
		{
			if (cb_addPanListener_Lorg_achartengine_tools_PanListener_ == null)
				cb_addPanListener_Lorg_achartengine_tools_PanListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPanListener_Lorg_achartengine_tools_PanListener_);
			return cb_addPanListener_Lorg_achartengine_tools_PanListener_;
		}

		static void n_AddPanListener_Lorg_achartengine_tools_PanListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Tools.Pan __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Pan> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IPanListener p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IPanListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPanListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPanListener_Lorg_achartengine_tools_PanListener_;
		[Register ("addPanListener", "(Lorg/achartengine/tools/PanListener;)V", "GetAddPanListener_Lorg_achartengine_tools_PanListener_Handler")]
		public virtual void AddPanListener (global::Org.Achartengine.Tools.IPanListener p0)
		{
			if (id_addPanListener_Lorg_achartengine_tools_PanListener_ == IntPtr.Zero)
				id_addPanListener_Lorg_achartengine_tools_PanListener_ = JNIEnv.GetMethodID (class_ref, "addPanListener", "(Lorg/achartengine/tools/PanListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPanListener_Lorg_achartengine_tools_PanListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addPanListener_Lorg_achartengine_tools_PanListener_, new JValue (p0));
		}

		static Delegate cb_apply_FFFF;
#pragma warning disable 0169
		static Delegate GetApply_FFFFHandler ()
		{
			if (cb_apply_FFFF == null)
				cb_apply_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_Apply_FFFF);
			return cb_apply_FFFF;
		}

		static void n_Apply_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Org.Achartengine.Tools.Pan __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Pan> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_apply_FFFF;
		[Register ("apply", "(FFFF)V", "GetApply_FFFFHandler")]
		public virtual void Apply (float p0, float p1, float p2, float p3)
		{
			if (id_apply_FFFF == IntPtr.Zero)
				id_apply_FFFF = JNIEnv.GetMethodID (class_ref, "apply", "(FFFF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_apply_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_apply_FFFF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_removePanListener_Lorg_achartengine_tools_PanListener_;
#pragma warning disable 0169
		static Delegate GetRemovePanListener_Lorg_achartengine_tools_PanListener_Handler ()
		{
			if (cb_removePanListener_Lorg_achartengine_tools_PanListener_ == null)
				cb_removePanListener_Lorg_achartengine_tools_PanListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePanListener_Lorg_achartengine_tools_PanListener_);
			return cb_removePanListener_Lorg_achartengine_tools_PanListener_;
		}

		static void n_RemovePanListener_Lorg_achartengine_tools_PanListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Tools.Pan __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Pan> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IPanListener p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IPanListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePanListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePanListener_Lorg_achartengine_tools_PanListener_;
		[Register ("removePanListener", "(Lorg/achartengine/tools/PanListener;)V", "GetRemovePanListener_Lorg_achartengine_tools_PanListener_Handler")]
		public virtual void RemovePanListener (global::Org.Achartengine.Tools.IPanListener p0)
		{
			if (id_removePanListener_Lorg_achartengine_tools_PanListener_ == IntPtr.Zero)
				id_removePanListener_Lorg_achartengine_tools_PanListener_ = JNIEnv.GetMethodID (class_ref, "removePanListener", "(Lorg/achartengine/tools/PanListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removePanListener_Lorg_achartengine_tools_PanListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removePanListener_Lorg_achartengine_tools_PanListener_, new JValue (p0));
		}

#region "Event implementation for Org.Achartengine.Tools.IPanListener"
		public event EventHandler Panned {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Org.Achartengine.Tools.IPanListener, global::Org.Achartengine.Tools.IPanListenerImplementor>(
						ref weak_implementor_AddPanListener,
						__CreateIPanListenerImplementor,
						AddPanListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Org.Achartengine.Tools.IPanListener, global::Org.Achartengine.Tools.IPanListenerImplementor>(
						ref weak_implementor_AddPanListener,
						global::Org.Achartengine.Tools.IPanListenerImplementor.__IsEmpty,
						AddPanListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddPanListener;

		global::Org.Achartengine.Tools.IPanListenerImplementor __CreateIPanListenerImplementor ()
		{
			return new global::Org.Achartengine.Tools.IPanListenerImplementor (this);
		}
#endregion
	}
}
