using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Achartengine.Chart {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RangeBarChart']"
	[global::Android.Runtime.Register ("org/achartengine/chart/RangeBarChart", DoNotGenerateAcw=true)]
	public partial class RangeBarChart : global::Org.Achartengine.Chart.BarChart {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RangeBarChart']/field[@name='TYPE']"
		[Register ("TYPE")]
		public const string Type = (string) "RangeBar";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/achartengine/chart/RangeBarChart", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RangeBarChart); }
		}

		protected RangeBarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.achartengine.chart']/class[@name='RangeBarChart']/constructor[@name='RangeBarChart' and count(parameter)=3 and parameter[1][@type='org.achartengine.model.XYMultipleSeriesDataset'] and parameter[2][@type='org.achartengine.renderer.XYMultipleSeriesRenderer'] and parameter[3][@type='org.achartengine.chart.BarChart.Type']]"
		[Register (".ctor", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", "")]
		public unsafe RangeBarChart (global::Org.Achartengine.Model.XYMultipleSeriesDataset p0, global::Org.Achartengine.Renderer.XYMultipleSeriesRenderer p1, global::Org.Achartengine.Chart.BarChart.Type p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RangeBarChart)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V", __args);
					return;
				}

				if (id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ == IntPtr.Zero)
					id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/achartengine/model/XYMultipleSeriesDataset;Lorg/achartengine/renderer/XYMultipleSeriesRenderer;Lorg/achartengine/chart/BarChart$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_achartengine_model_XYMultipleSeriesDataset_Lorg_achartengine_renderer_XYMultipleSeriesRenderer_Lorg_achartengine_chart_BarChart_Type_, __args);
			} finally {
			}
		}

	}
}
