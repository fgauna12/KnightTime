using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine {

	[global::Android.Runtime.Register ("org/achartengine/TouchHandler", DoNotGenerateAcw=true)]
	public partial class TouchHandler : global::Java.Lang.Object, global::Org.Achartengine.ITouchHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/TouchHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TouchHandler); }
		}

		protected TouchHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_GraphicalView_Lorg_achartengine_chart_AbstractChart_;
		[Register (".ctor", "(Lorg/achartengine/GraphicalView;Lorg/achartengine/chart/AbstractChart;)V", "")]
		public TouchHandler (global::Org.Achartengine.GraphicalView p0, global::Org.Achartengine.Chart.AbstractChart p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TouchHandler)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lorg/achartengine/GraphicalView;Lorg/achartengine/chart/AbstractChart;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lorg_achartengine_GraphicalView_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
				id_ctor_Lorg_achartengine_GraphicalView_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/GraphicalView;Lorg/achartengine/chart/AbstractChart;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lorg_achartengine_GraphicalView_Lorg_achartengine_chart_AbstractChart_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Achartengine.TouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.TouchHandler> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Achartengine.TouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.TouchHandler> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_handleTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetHandleTouch_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_handleTouch_Landroid_view_MotionEvent_ == null)
				cb_handleTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HandleTouch_Landroid_view_MotionEvent_);
			return cb_handleTouch_Landroid_view_MotionEvent_;
		}

		static bool n_HandleTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Achartengine.TouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.TouchHandler> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleTouch (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleTouch_Landroid_view_MotionEvent_;
		[Register ("handleTouch", "(Landroid/view/MotionEvent;)Z", "GetHandleTouch_Landroid_view_MotionEvent_Handler")]
		public virtual bool HandleTouch (global::Android.Views.MotionEvent p0)
		{
			if (id_handleTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_handleTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "handleTouch", "(Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_handleTouch_Landroid_view_MotionEvent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_handleTouch_Landroid_view_MotionEvent_, new JValue (p0));
			return __ret;
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
			global::Org.Achartengine.TouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.TouchHandler> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Achartengine.TouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.TouchHandler> (native__this, JniHandleOwnership.DoNotTransfer);
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

#region "Event implementation for Org.Achartengine.Tools.IPanListener"
		public event EventHandler Pan {
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
