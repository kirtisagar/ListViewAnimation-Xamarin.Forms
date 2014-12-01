using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeOnScrollListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener", DoNotGenerateAcw=true)]
	public partial class SwipeOnScrollListener : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeOnScrollListener); }
		}

		protected SwipeOnScrollListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeOnScrollListener']/constructor[@name='SwipeOnScrollListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public SwipeOnScrollListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwipeOnScrollListener)) {
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

		static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
		{
			if (cb_onScroll_Landroid_widget_AbsListView_III == null)
				cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
			return cb_onScroll_Landroid_widget_AbsListView_III;
		}

		static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeOnScrollListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
		public virtual void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
		{
			if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
				id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
		static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
		{
			if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
				cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
			return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
		}

		static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
			__this.OnScrollStateChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeOnScrollListener']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
		[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
		public virtual void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
		{
			if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
				id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), new JValue (p0), new JValue ((int) p1));
		}

		static Delegate cb_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_Handler ()
		{
			if (cb_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ == null)
				cb_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_);
			return cb_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_;
		}

		static void n_SetTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener p0 = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTouchListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeOnScrollListener']/method[@name='setTouchListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeDismissListViewTouchListener']]"
		[Register ("setTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;)V", "GetSetTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_Handler")]
		public virtual void SetTouchListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener p0)
		{
			if (id_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ == IntPtr.Zero)
				id_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ = JNIEnv.GetMethodID (class_ref, "setTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTouchListener_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTouchListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;)V"), new JValue (p0));
		}

	}
}
