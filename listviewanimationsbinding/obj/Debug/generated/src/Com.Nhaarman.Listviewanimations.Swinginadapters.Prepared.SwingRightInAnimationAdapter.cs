using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters.Prepared {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='SwingRightInAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/prepared/SwingRightInAnimationAdapter", DoNotGenerateAcw=true)]
	public partial class SwingRightInAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Swinginadapters.SingleAnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/prepared/SwingRightInAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwingRightInAnimationAdapter); }
		}

		protected SwingRightInAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='SwingRightInAnimationAdapter']/constructor[@name='SwingRightInAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public SwingRightInAnimationAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwingRightInAnimationAdapter)) {
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

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='SwingRightInAnimationAdapter']/constructor[@name='SwingRightInAnimationAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;J)V", "")]
		public SwingRightInAnimationAdapter (global::Android.Widget.BaseAdapter p0, long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwingRightInAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;J)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;J)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_J == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_J, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_J, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters.prepared']/class[@name='SwingRightInAnimationAdapter']/constructor[@name='SwingRightInAnimationAdapter' and count(parameter)=3 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;JJ)V", "")]
		public SwingRightInAnimationAdapter (global::Android.Widget.BaseAdapter p0, long p1, long p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwingRightInAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;JJ)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;JJ)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_JJ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;JJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_JJ, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_JJ, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
