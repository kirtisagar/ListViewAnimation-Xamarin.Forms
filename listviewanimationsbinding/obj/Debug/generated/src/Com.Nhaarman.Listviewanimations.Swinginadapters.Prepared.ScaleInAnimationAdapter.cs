using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters.Prepared {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='ScaleInAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/prepared/ScaleInAnimationAdapter", DoNotGenerateAcw=true)]
	public partial class ScaleInAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/prepared/ScaleInAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScaleInAnimationAdapter); }
		}

		protected ScaleInAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='ScaleInAnimationAdapter']/constructor[@name='ScaleInAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public ScaleInAnimationAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScaleInAnimationAdapter)) {
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

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='ScaleInAnimationAdapter']/constructor[@name='ScaleInAnimationAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;F)V", "")]
		public ScaleInAnimationAdapter (global::Android.Widget.BaseAdapter p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScaleInAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;F)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;F)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_F == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;F)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_F, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_F, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_FJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='ScaleInAnimationAdapter']/constructor[@name='ScaleInAnimationAdapter' and count(parameter)=4 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='float'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;FJJ)V", "")]
		public ScaleInAnimationAdapter (global::Android.Widget.BaseAdapter p0, float p1, long p2, long p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScaleInAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;FJJ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;FJJ)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_FJJ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_FJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;FJJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_FJJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_FJJ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}
}
