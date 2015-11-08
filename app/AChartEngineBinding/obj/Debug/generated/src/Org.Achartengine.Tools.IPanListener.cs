using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Tools {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.achartengine.tools']/interface[@name='PanListener']"
	[Register ("org/achartengine/tools/PanListener", "", "Org.Achartengine.Tools.IPanListenerInvoker")]
	public partial interface IPanListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.achartengine.tools']/interface[@name='PanListener']/method[@name='panApplied' and count(parameter)=0]"
		[Register ("panApplied", "()V", "GetPanAppliedHandler:Org.Achartengine.Tools.IPanListenerInvoker, AChartEngineBinding")]
		void PanApplied ();

	}

	[global::Android.Runtime.Register ("org/achartengine/tools/PanListener", DoNotGenerateAcw=true)]
	internal class IPanListenerInvoker : global::Java.Lang.Object, IPanListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/achartengine/tools/PanListener");
		IntPtr class_ref;

		public static IPanListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPanListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.achartengine.tools.PanListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPanListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPanListenerInvoker); }
		}

		static Delegate cb_panApplied;
#pragma warning disable 0169
		static Delegate GetPanAppliedHandler ()
		{
			if (cb_panApplied == null)
				cb_panApplied = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PanApplied);
			return cb_panApplied;
		}

		static void n_PanApplied (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Achartengine.Tools.IPanListener __this = global::Java.Lang.Object.GetObject<global::Org.Achartengine.Tools.IPanListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PanApplied ();
		}
#pragma warning restore 0169

		IntPtr id_panApplied;
		public unsafe void PanApplied ()
		{
			if (id_panApplied == IntPtr.Zero)
				id_panApplied = JNIEnv.GetMethodID (class_ref, "panApplied", "()V");
			JNIEnv.CallVoidMethod (Handle, id_panApplied);
		}

	}

	[global::Android.Runtime.Register ("mono/org/achartengine/tools/PanListenerImplementor")]
	internal sealed partial class IPanListenerImplementor : global::Java.Lang.Object, IPanListener {

		object sender;

		public IPanListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/achartengine/tools/PanListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void PanApplied ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IPanListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
