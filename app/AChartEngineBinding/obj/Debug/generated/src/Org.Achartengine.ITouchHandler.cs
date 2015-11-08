using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']"
	[Register ("org/achartengine/ITouchHandler", "", "Org.Achartengine.ITouchHandlerInvoker")]
	public partial interface ITouchHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']/method[@name='addPanListener' and count(parameter)=1 and parameter[1][@type='org.achartengine.tools.PanListener']]"
		[Register ("addPanListener", "(Lorg/achartengine/tools/PanListener;)V", "GetAddPanListener_Lorg_achartengine_tools_PanListener_Handler:Org.Achartengine.ITouchHandlerInvoker, AChartEngineBinding")]
		void AddPanListener (global::Org.Achartengine.Tools.IPanListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']/method[@name='addZoomListener' and count(parameter)=1 and parameter[1][@type='org.achartengine.tools.ZoomListener']]"
		[Register ("addZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V", "GetAddZoomListener_Lorg_achartengine_tools_ZoomListener_Handler:Org.Achartengine.ITouchHandlerInvoker, AChartEngineBinding")]
		void AddZoomListener (global::Org.Achartengine.Tools.IZoomListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']/method[@name='handleTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("handleTouch", "(Landroid/view/MotionEvent;)Z", "GetHandleTouch_Landroid_view_MotionEvent_Handler:Org.Achartengine.ITouchHandlerInvoker, AChartEngineBinding")]
		bool HandleTouch (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']/method[@name='removePanListener' and count(parameter)=1 and parameter[1][@type='org.achartengine.tools.PanListener']]"
		[Register ("removePanListener", "(Lorg/achartengine/tools/PanListener;)V", "GetRemovePanListener_Lorg_achartengine_tools_PanListener_Handler:Org.Achartengine.ITouchHandlerInvoker, AChartEngineBinding")]
		void RemovePanListener (global::Org.Achartengine.Tools.IPanListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine']/interface[@name='ITouchHandler']/method[@name='removeZoomListener' and count(parameter)=1 and parameter[1][@type='org.achartengine.tools.ZoomListener']]"
		[Register ("removeZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V", "GetRemoveZoomListener_Lorg_achartengine_tools_ZoomListener_Handler:Org.Achartengine.ITouchHandlerInvoker, AChartEngineBinding")]
		void RemoveZoomListener (global::Org.Achartengine.Tools.IZoomListener p0);

	}

	[global::Android.Runtime.Register ("org/achartengine/ITouchHandler", DoNotGenerateAcw=true)]
	internal class ITouchHandlerInvoker : global::Java.Lang.Object, ITouchHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/achartengine/ITouchHandler");
		IntPtr class_ref;

		public static ITouchHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITouchHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.achartengine.ITouchHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITouchHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITouchHandlerInvoker); }
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
			global::Org.Achartengine.ITouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.ITouchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IPanListener p0 = (global::Org.Achartengine.Tools.IPanListener)global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IPanListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPanListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addPanListener_Lorg_achartengine_tools_PanListener_;
		public unsafe void AddPanListener (global::Org.Achartengine.Tools.IPanListener p0)
		{
			if (id_addPanListener_Lorg_achartengine_tools_PanListener_ == IntPtr.Zero)
				id_addPanListener_Lorg_achartengine_tools_PanListener_ = JNIEnv.GetMethodID (class_ref, "addPanListener", "(Lorg/achartengine/tools/PanListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_addPanListener_Lorg_achartengine_tools_PanListener_, __args);
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
			global::Org.Achartengine.ITouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.ITouchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IZoomListener p0 = (global::Org.Achartengine.Tools.IZoomListener)global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddZoomListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addZoomListener_Lorg_achartengine_tools_ZoomListener_;
		public unsafe void AddZoomListener (global::Org.Achartengine.Tools.IZoomListener p0)
		{
			if (id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ == IntPtr.Zero)
				id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNIEnv.GetMethodID (class_ref, "addZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_addZoomListener_Lorg_achartengine_tools_ZoomListener_, __args);
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
			global::Org.Achartengine.ITouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.ITouchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleTouch (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleTouch_Landroid_view_MotionEvent_;
		public unsafe bool HandleTouch (global::Android.Views.MotionEvent p0)
		{
			if (id_handleTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_handleTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "handleTouch", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_handleTouch_Landroid_view_MotionEvent_, __args);
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
			global::Org.Achartengine.ITouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.ITouchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IPanListener p0 = (global::Org.Achartengine.Tools.IPanListener)global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IPanListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePanListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removePanListener_Lorg_achartengine_tools_PanListener_;
		public unsafe void RemovePanListener (global::Org.Achartengine.Tools.IPanListener p0)
		{
			if (id_removePanListener_Lorg_achartengine_tools_PanListener_ == IntPtr.Zero)
				id_removePanListener_Lorg_achartengine_tools_PanListener_ = JNIEnv.GetMethodID (class_ref, "removePanListener", "(Lorg/achartengine/tools/PanListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_removePanListener_Lorg_achartengine_tools_PanListener_, __args);
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
			global::Org.Achartengine.ITouchHandler __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.ITouchHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IZoomListener p0 = (global::Org.Achartengine.Tools.IZoomListener)global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveZoomListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_;
		public unsafe void RemoveZoomListener (global::Org.Achartengine.Tools.IZoomListener p0)
		{
			if (id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ == IntPtr.Zero)
				id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_ = JNIEnv.GetMethodID (class_ref, "removeZoomListener", "(Lorg/achartengine/tools/ZoomListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_removeZoomListener_Lorg_achartengine_tools_ZoomListener_, __args);
		}

	}

}
