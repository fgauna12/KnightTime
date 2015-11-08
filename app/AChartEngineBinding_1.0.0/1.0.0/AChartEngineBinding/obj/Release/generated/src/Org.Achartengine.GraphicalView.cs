using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine {

	[global::Android.Runtime.Register ("org/achartengine/GraphicalView", DoNotGenerateAcw=true)]
	public partial class GraphicalView : global::Android.Views.View {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/GraphicalView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GraphicalView); }
		}

		protected GraphicalView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_achartengine_chart_AbstractChart_;
		[Register (".ctor", "(Landroid/content/Context;Lorg/achartengine/chart/AbstractChart;)V", "")]
		public GraphicalView (global::Android.Content.Context p0, global::Org.Achartengine.Chart.AbstractChart p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GraphicalView)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Landroid/content/Context;Lorg/achartengine/chart/AbstractChart;)V", new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_achartengine_chart_AbstractChart_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_achartengine_chart_AbstractChart_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/achartengine/chart/AbstractChart;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Landroid_content_Context_Lorg_achartengine_chart_AbstractChart_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCurrentSeriesAndPoint;
#pragma warning disable 0169
		static Delegate GetGetCurrentSeriesAndPointHandler ()
		{
			if (cb_getCurrentSeriesAndPoint == null)
				cb_getCurrentSeriesAndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentSeriesAndPoint);
			return cb_getCurrentSeriesAndPoint;
		}

		static IntPtr n_GetCurrentSeriesAndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentSeriesAndPoint);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSeriesAndPoint;
		public virtual global::Org.Achartengine.Model.SeriesSelection CurrentSeriesAndPoint {
			[Register ("getCurrentSeriesAndPoint", "()Lorg/achartengine/model/SeriesSelection;", "GetGetCurrentSeriesAndPointHandler")]
			get {
				if (id_getCurrentSeriesAndPoint == IntPtr.Zero)
					id_getCurrentSeriesAndPoint = JNIEnv.GetMethodID (class_ref, "getCurrentSeriesAndPoint", "()Lorg/achartengine/model/SeriesSelection;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentSeriesAndPoint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Achartengine.Model.SeriesSelection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getCurrentSeriesAndPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomRectangle;
#pragma warning disable 0169
		static Delegate GetGetZoomRectangleHandler ()
		{
			if (cb_getZoomRectangle == null)
				cb_getZoomRectangle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomRectangle);
			return cb_getZoomRectangle;
		}

		static IntPtr n_GetZoomRectangle (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomRectangle);
		}
#pragma warning restore 0169

		static IntPtr id_getZoomRectangle;
		protected virtual global::Android.Graphics.RectF ZoomRectangle {
			[Register ("getZoomRectangle", "()Landroid/graphics/RectF;", "GetGetZoomRectangleHandler")]
			get {
				if (id_getZoomRectangle == IntPtr.Zero)
					id_getZoomRectangle = JNIEnv.GetMethodID (class_ref, "getZoomRectangle", "()Landroid/graphics/RectF;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getZoomRectangle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_getZoomRectangle), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ;
#pragma warning disable 0169
		static Delegate GetAddZoomListener_Lorg_achartengine_tools_ZoomListener_ZZHandler ()
		{
			if (cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ == null)
				cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_AddZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ);
			return cb_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ;
		}

		static void n_AddZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, bool p2)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Achartengine.Tools.IZoomListener p0 = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IZoomListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddZoomListener (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ;
		[Register ("addZoomListener", "(Lorg/achartengine/tools/ZoomListener;ZZ)V", "GetAddZoomListener_Lorg_achartengine_tools_ZoomListener_ZZHandler")]
		public virtual void AddZoomListener (global::Org.Achartengine.Tools.IZoomListener p0, bool p1, bool p2)
		{
			if (id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ == IntPtr.Zero)
				id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ = JNIEnv.GetMethodID (class_ref, "addZoomListener", "(Lorg/achartengine/tools/ZoomListener;ZZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_addZoomListener_Lorg_achartengine_tools_ZoomListener_ZZ, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_repaint;
#pragma warning disable 0169
		static Delegate GetRepaintHandler ()
		{
			if (cb_repaint == null)
				cb_repaint = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Repaint);
			return cb_repaint;
		}

		static void n_Repaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Repaint ();
		}
#pragma warning restore 0169

		static IntPtr id_repaint;
		[Register ("repaint", "()V", "GetRepaintHandler")]
		public virtual void Repaint ()
		{
			if (id_repaint == IntPtr.Zero)
				id_repaint = JNIEnv.GetMethodID (class_ref, "repaint", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_repaint);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_repaint);
		}

		static Delegate cb_repaint_IIII;
#pragma warning disable 0169
		static Delegate GetRepaint_IIIIHandler ()
		{
			if (cb_repaint_IIII == null)
				cb_repaint_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_Repaint_IIII);
			return cb_repaint_IIII;
		}

		static void n_Repaint_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.Repaint (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_repaint_IIII;
		[Register ("repaint", "(IIII)V", "GetRepaint_IIIIHandler")]
		public virtual void Repaint (int p0, int p1, int p2, int p3)
		{
			if (id_repaint_IIII == IntPtr.Zero)
				id_repaint_IIII = JNIEnv.GetMethodID (class_ref, "repaint", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_repaint_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_repaint_IIII, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
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
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_toBitmap;
#pragma warning disable 0169
		static Delegate GetToBitmapHandler ()
		{
			if (cb_toBitmap == null)
				cb_toBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBitmap);
			return cb_toBitmap;
		}

		static IntPtr n_ToBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToBitmap ());
		}
#pragma warning restore 0169

		static IntPtr id_toBitmap;
		[Register ("toBitmap", "()Landroid/graphics/Bitmap;", "GetToBitmapHandler")]
		public virtual global::Android.Graphics.Bitmap ToBitmap ()
		{
			if (id_toBitmap == IntPtr.Zero)
				id_toBitmap = JNIEnv.GetMethodID (class_ref, "toBitmap", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_toBitmap), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toBitmap), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toRealPoint_I;
#pragma warning disable 0169
		static Delegate GetToRealPoint_IHandler ()
		{
			if (cb_toRealPoint_I == null)
				cb_toRealPoint_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ToRealPoint_I);
			return cb_toRealPoint_I;
		}

		static IntPtr n_ToRealPoint_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToRealPoint (p0));
		}
#pragma warning restore 0169

		static IntPtr id_toRealPoint_I;
		[Register ("toRealPoint", "(I)[D", "GetToRealPoint_IHandler")]
		public virtual double[] ToRealPoint (int p0)
		{
			if (id_toRealPoint_I == IntPtr.Zero)
				id_toRealPoint_I = JNIEnv.GetMethodID (class_ref, "toRealPoint", "(I)[D");

			if (GetType () == ThresholdType)
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toRealPoint_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
			else
				return (double[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_toRealPoint_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual void ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomIn);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_zoomIn);
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual void ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomOut);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_zoomOut);
		}

		static Delegate cb_zoomReset;
#pragma warning disable 0169
		static Delegate GetZoomResetHandler ()
		{
			if (cb_zoomReset == null)
				cb_zoomReset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomReset);
			return cb_zoomReset;
		}

		static void n_ZoomReset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.GraphicalView __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.GraphicalView> (native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomReset ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomReset;
		[Register ("zoomReset", "()V", "GetZoomResetHandler")]
		public virtual void ZoomReset ()
		{
			if (id_zoomReset == IntPtr.Zero)
				id_zoomReset = JNIEnv.GetMethodID (class_ref, "zoomReset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomReset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_zoomReset);
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
	}
}
