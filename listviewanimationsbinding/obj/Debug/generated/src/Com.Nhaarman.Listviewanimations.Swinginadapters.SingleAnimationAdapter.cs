using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='SingleAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/SingleAnimationAdapter", DoNotGenerateAcw=true)]
	public abstract partial class SingleAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/SingleAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleAnimationAdapter); }
		}

		protected SingleAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='SingleAnimationAdapter']/constructor[@name='SingleAnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public SingleAnimationAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SingleAnimationAdapter)) {
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

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/SingleAnimationAdapter", DoNotGenerateAcw=true)]
	internal partial class SingleAnimationAdapterInvoker : SingleAnimationAdapter {

		public SingleAnimationAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleAnimationAdapterInvoker); }
		}

	}

}
