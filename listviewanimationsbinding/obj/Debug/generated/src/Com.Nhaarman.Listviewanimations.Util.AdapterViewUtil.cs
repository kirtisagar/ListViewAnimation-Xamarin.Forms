using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/util/AdapterViewUtil", DoNotGenerateAcw=true)]
	public partial class AdapterViewUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/util/AdapterViewUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdapterViewUtil); }
		}

		protected AdapterViewUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/constructor[@name='AdapterViewUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AdapterViewUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AdapterViewUtil)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_getPositionForView_Landroid_widget_AdapterView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.util']/class[@name='AdapterViewUtil']/method[@name='getPositionForView' and count(parameter)=2 and parameter[1][@type='android.widget.AdapterView'] and parameter[2][@type='android.view.View']]"
		[Register ("getPositionForView", "(Landroid/widget/AdapterView;Landroid/view/View;)I", "")]
		public static int GetPositionForView (global::Android.Widget.AdapterView p0, global::Android.Views.View p1)
		{
			if (id_getPositionForView_Landroid_widget_AdapterView_Landroid_view_View_ == IntPtr.Zero)
				id_getPositionForView_Landroid_widget_AdapterView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPositionForView", "(Landroid/widget/AdapterView;Landroid/view/View;)I");
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPositionForView_Landroid_widget_AdapterView_Landroid_view_View_, new JValue (p0), new JValue (p1));
			return __ret;
		}

	}
}
