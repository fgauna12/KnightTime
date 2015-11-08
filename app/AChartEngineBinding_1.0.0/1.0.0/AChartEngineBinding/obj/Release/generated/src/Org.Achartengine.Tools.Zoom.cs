using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	[global::Android.Runtime.Register ("org/achartengine/tools/Zoom", DoNotGenerateAcw=true)]
	public partial class Zoom : global::Org.Achartengine.Tools.AbstractTool {


		[Register ("ZOOM_AXIS_X")]
		public const int ZoomAxisX = (int) 1;

		[Register ("ZOOM_AXIS_XY")]
		public const int ZoomAxisXy = (int) 0;

		[Register ("ZOOM_AXIS_Y")]
		public const int ZoomAxisY = (int) 2;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/tools/Zoom", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Zoom); }
		}

		protected Zoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_chart_AbstractChart_ZF;
		[Register (".ctor", "(Lorg/achartengine/chart/AbstractChart;ZF)V", "")]
		public Zoom (global::Org.Achartengine.Chart.AbstractChart p0, bool p1, float p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Zoom)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/chart/AbstractChart;ZF)V", new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_chart_AbstractChart_ZF == IntPtr.Zero)
				id_ctor_Lorg_achartengine_chart_AbstractChart_ZF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/chart/AbstractChart;ZF)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_chart_AbstractChart_ZF, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_;
#pragma warning disable 0169
		static Delegate GetAddZoomListener_Lorg_achartengine_tools_ZoomListener_Handler ()
		{
			if (cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ == null)
				cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddZoomListener_Lorg_achartengine_tools_ZoomListener_);
			return cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_;
		}

		static void n_AddZoomListener_Lorg_achartengine_tools_ZoomListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Tools.Zoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Zoom> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IZoomListener p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddZoomListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addZoomListener_Lorg_achartengine_tools_ZoomListener_;
		[Register ("addZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V", "GetAddZoomListener_Lorg_achartengine_tools_ZoomListener_Handler")]
		public virtual void AddZoomListener (global::Org.Achartengine.Tools.IZoomListener p0)
		{
			if (id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ == IntPtr.Zero)
				id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNIEnv.GetMethodID (class_ref, "addZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addZoomListener_Lorg_achartengine_tools_ZoomListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addZoomListener_Lorg_achartengine_tools_ZoomListener_, new JValue (p0));
		}

		static Delegate cb_apply_I;
#pragma warning disable 0169
		static Delegate GetApply_IHandler ()
		{
			if (cb_apply_I == null)
				cb_apply_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Apply_I);
			return cb_apply_I;
		}

		static void n_Apply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.Tools.Zoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Zoom> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_apply_I;
		[Register ("apply", "(I)V", "GetApply_IHandler")]
		public virtual void Apply (int p0)
		{
			if (id_apply_I == IntPtr.Zero)
				id_apply_I = JNIEnv.GetMethodID (class_ref, "apply", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_apply_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_apply_I, new JValue (p0));
		}

		static Delegate cb_notifyZoomResetListeners;
#pragma warning disable 0169
		static Delegate GetNotifyZoomResetListenersHandler ()
		{
			if (cb_notifyZoomResetListeners == null)
				cb_notifyZoomResetListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyZoomResetListeners);
			return cb_notifyZoomResetListeners;
		}

		static void n_NotifyZoomResetListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Tools.Zoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Zoom> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyZoomResetListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyZoomResetListeners;
		[Register ("notifyZoomResetListeners", "()V", "GetNotifyZoomResetListenersHandler")]
		public virtual void NotifyZoomResetListeners ()
		{
			if (id_notifyZoomResetListeners == IntPtr.Zero)
				id_notifyZoomResetListeners = JNIEnv.GetMethodID (class_ref, "notifyZoomResetListeners", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyZoomResetListeners);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_notifyZoomResetListeners);
		}

		static Delegate cb_removeZoomListener_Lorg_achartengine_tools_ZoomListener_;
#pragma warning disable 0169
		static Delegate GetRemoveZoomListener_Lorg_achartengine_tools_ZoomListener_Handler ()
		{
			if (cb_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ == null)
				cb_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveZoomListener_Lorg_achartengine_tools_ZoomListener_);
			return cb_removeZoomListener_Lorg_achartengine_tools_ZoomListener_;
		}

		static void n_RemoveZoomListener_Lorg_achartengine_tools_ZoomListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.Tools.Zoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Zoom> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IZoomListener p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveZoomListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_;
		[Register ("removeZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V", "GetRemoveZoomListener_Lorg_achartengine_tools_ZoomListener_Handler")]
		public virtual void RemoveZoomListener (global::Org.Achartengine.Tools.IZoomListener p0)
		{
			if (id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ == IntPtr.Zero)
				id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNIEnv.GetMethodID (class_ref, "removeZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_, new JValue (p0));
		}

		static Delegate cb_setZoomRate_F;
#pragma warning disable 0169
		static Delegate GetSetZoomRate_FHandler ()
		{
			if (cb_setZoomRate_F == null)
				cb_setZoomRate_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoomRate_F);
			return cb_setZoomRate_F;
		}

		static void n_SetZoomRate_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Org.Achartengine.Tools.Zoom __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.Zoom> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomRate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomRate_F;
		[Register ("setZoomRate", "(F)V", "GetSetZoomRate_FHandler")]
		public virtual void SetZoomRate (float p0)
		{
			if (id_setZoomRate_F == IntPtr.Zero)
				id_setZoomRate_F = JNIEnv.GetMethodID (class_ref, "setZoomRate", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoomRate_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setZoomRate_F, new JValue (p0));
		}

#region "Event implementation for Org.Achartengine.Tools.IZoomListener"
		public event EventHandler<global::Org.Achartengine.Tools.ZoomAppliedEventArgs> ZoomApplied {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Org.Achartengine.Tools.IZoomListener, global::Org.Achartengine.Tools.IZoomListenerImplementor>(
						ref weak_implementor_AddZoomListener,
						__CreateIZoomListenerImplementor,
						AddZoomListener,
						__h => __h.ZoomAppliedHandler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Org.Achartengine.Tools.IZoomListener, global::Org.Achartengine.Tools.IZoomListenerImplementor>(
						ref weak_implementor_AddZoomListener,
						global::Org.Achartengine.Tools.IZoomListenerImplementor.__IsEmpty,
						AddZoomListener,
						__h => __h.ZoomAppliedHandler -= value);
			}
		}

		public event EventHandler ZoomReset {
			add {
				global::Java.Interop.AndroidEventHelper.AddEventHandler<global::Org.Achartengine.Tools.IZoomListener, global::Org.Achartengine.Tools.IZoomListenerImplementor>(
						ref weak_implementor_AddZoomListener,
						__CreateIZoomListenerImplementor,
						AddZoomListener,
						__h => __h.ZoomResetHandler += value);
			}
			remove {
				global::Java.Interop.AndroidEventHelper.RemoveEventHandler<global::Org.Achartengine.Tools.IZoomListener, global::Org.Achartengine.Tools.IZoomListenerImplementor>(
						ref weak_implementor_AddZoomListener,
						global::Org.Achartengine.Tools.IZoomListenerImplementor.__IsEmpty,
						AddZoomListener,
						__h => __h.ZoomResetHandler -= value);
			}
		}

		WeakReference weak_implementor_AddZoomListener;

		global::Org.Achartengine.Tools.IZoomListenerImplementor __CreateIZoomListenerImplementor ()
		{
			return new global::Org.Achartengine.Tools.IZoomListenerImplementor (this);
		}
#endregion
	}
}
