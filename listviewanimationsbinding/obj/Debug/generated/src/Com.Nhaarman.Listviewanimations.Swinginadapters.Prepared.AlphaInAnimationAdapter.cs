using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters.Prepared {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='AlphaInAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/prepared/AlphaInAnimationAdapter", DoNotGenerateAcw=true)]
	public partial class AlphaInAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/prepared/AlphaInAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlphaInAnimationAdapter); }
		}

		protected AlphaInAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='AlphaInAnimationAdapter']/constructor[@name='AlphaInAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public AlphaInAnimationAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AlphaInAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_, new JValue (p0));
		}

	}
}
