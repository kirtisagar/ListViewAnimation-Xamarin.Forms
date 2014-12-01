using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='OnDismissCallback']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallbackInvoker")]
	public partial interface IOnDismissCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='OnDismissCallback']/method[@name='onDismiss' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int[]']]"
		[Register ("onDismiss", "(Landroid/widget/AbsListView;[I)V", "GetOnDismiss_Landroid_widget_AbsListView_arrayIHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallbackInvoker, ListViewAnimations")]
		void OnDismiss (global::Android.Widget.AbsListView p0, int[] p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback", DoNotGenerateAcw=true)]
	internal class IOnDismissCallbackInvoker : global::Java.Lang.Object, IOnDismissCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback");
		IntPtr class_ref;

		public static IOnDismissCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDismissCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.OnDismissCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDismissCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnDismissCallbackInvoker); }
		}

		static Delegate cb_onDismiss_Landroid_widget_AbsListView_arrayI;
#pragma warning disable 0169
		static Delegate GetOnDismiss_Landroid_widget_AbsListView_arrayIHandler ()
		{
			if (cb_onDismiss_Landroid_widget_AbsListView_arrayI == null)
				cb_onDismiss_Landroid_widget_AbsListView_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDismiss_Landroid_widget_AbsListView_arrayI);
			return cb_onDismiss_Landroid_widget_AbsListView_arrayI;
		}

		static void n_OnDismiss_Landroid_widget_AbsListView_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnDismiss (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onDismiss_Landroid_widget_AbsListView_arrayI;
		public void OnDismiss (global::Android.Widget.AbsListView p0, int[] p1)
		{
			if (id_onDismiss_Landroid_widget_AbsListView_arrayI == IntPtr.Zero)
				id_onDismiss_Landroid_widget_AbsListView_arrayI = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Landroid/widget/AbsListView;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JNIEnv.CallVoidMethod (Handle, id_onDismiss_Landroid_widget_AbsListView_arrayI, new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
