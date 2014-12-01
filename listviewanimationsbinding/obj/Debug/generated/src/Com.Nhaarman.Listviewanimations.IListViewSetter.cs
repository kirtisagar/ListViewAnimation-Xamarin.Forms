using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations']/interface[@name='ListViewSetter']"
	[Register ("com/nhaarman/listviewanimations/ListViewSetter", "", "Com.Nhaarman.Listviewanimations.IListViewSetterInvoker")]
	public partial interface IListViewSetter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/interface[@name='ListViewSetter']/method[@name='setAbsListView' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView']]"
		[Register ("setAbsListView", "(Landroid/widget/AbsListView;)V", "GetSetAbsListView_Landroid_widget_AbsListView_Handler:Com.Nhaarman.Listviewanimations.IListViewSetterInvoker, ListViewAnimations")]
		void SetAbsListView (global::Android.Widget.AbsListView p0);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/ListViewSetter", DoNotGenerateAcw=true)]
	internal class IListViewSetterInvoker : global::Java.Lang.Object, IListViewSetter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/ListViewSetter");
		IntPtr class_ref;

		public static IListViewSetter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IListViewSetter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.ListViewSetter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IListViewSetterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IListViewSetterInvoker); }
		}

		static Delegate cb_setAbsListView_Landroid_widget_AbsListView_;
#pragma warning disable 0169
		static Delegate GetSetAbsListView_Landroid_widget_AbsListView_Handler ()
		{
			if (cb_setAbsListView_Landroid_widget_AbsListView_ == null)
				cb_setAbsListView_Landroid_widget_AbsListView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAbsListView_Landroid_widget_AbsListView_);
			return cb_setAbsListView_Landroid_widget_AbsListView_;
		}

		static void n_SetAbsListView_Landroid_widget_AbsListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.IListViewSetter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.IListViewSetter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAbsListView (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAbsListView_Landroid_widget_AbsListView_;
		public void SetAbsListView (global::Android.Widget.AbsListView p0)
		{
			if (id_setAbsListView_Landroid_widget_AbsListView_ == IntPtr.Zero)
				id_setAbsListView_Landroid_widget_AbsListView_ = JNIEnv.GetMethodID (class_ref, "setAbsListView", "(Landroid/widget/AbsListView;)V");
			JNIEnv.CallVoidMethod (Handle, id_setAbsListView_Landroid_widget_AbsListView_, new JValue (p0));
		}

	}

}
