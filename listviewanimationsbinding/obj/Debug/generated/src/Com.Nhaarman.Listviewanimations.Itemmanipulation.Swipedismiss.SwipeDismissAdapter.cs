using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissAdapter", DoNotGenerateAcw=true)]
	public partial class SwipeDismissAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {


		static IntPtr mOnDismissCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/field[@name='mOnDismissCallback']"
		[Register ("mOnDismissCallback")]
		protected global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback MOnDismissCallback {
			get {
				if (mOnDismissCallback_jfieldId == IntPtr.Zero)
					mOnDismissCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDismissCallback", "Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOnDismissCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnDismissCallback_jfieldId == IntPtr.Zero)
					mOnDismissCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnDismissCallback", "Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOnDismissCallback_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSwipeDismissListViewTouchListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/field[@name='mSwipeDismissListViewTouchListener']"
		[Register ("mSwipeDismissListViewTouchListener")]
		protected global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener MSwipeDismissListViewTouchListener {
			get {
				if (mSwipeDismissListViewTouchListener_jfieldId == IntPtr.Zero)
					mSwipeDismissListViewTouchListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwipeDismissListViewTouchListener", "Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSwipeDismissListViewTouchListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSwipeDismissListViewTouchListener_jfieldId == IntPtr.Zero)
					mSwipeDismissListViewTouchListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwipeDismissListViewTouchListener", "Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSwipeDismissListViewTouchListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSwipeOnScrollListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/field[@name='mSwipeOnScrollListener']"
		[Register ("mSwipeOnScrollListener")]
		protected global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener MSwipeOnScrollListener {
			get {
				if (mSwipeOnScrollListener_jfieldId == IntPtr.Zero)
					mSwipeOnScrollListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwipeOnScrollListener", "Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSwipeOnScrollListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSwipeOnScrollListener_jfieldId == IntPtr.Zero)
					mSwipeOnScrollListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwipeOnScrollListener", "Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSwipeOnScrollListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissAdapter); }
		}

		protected SwipeDismissAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/constructor[@name='SwipeDismissAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.OnDismissCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", "")]
		public SwipeDismissAdapter (global::Android.Widget.BaseAdapter p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwipeDismissAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/constructor[@name='SwipeDismissAdapter' and count(parameter)=3 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.OnDismissCallback'] and parameter[3][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeOnScrollListener']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", "")]
		public SwipeDismissAdapter (global::Android.Widget.BaseAdapter p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback p1, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwipeDismissAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_createListViewTouchListener_Landroid_widget_AbsListView_;
#pragma warning disable 0169
		static Delegate GetCreateListViewTouchListener_Landroid_widget_AbsListView_Handler ()
		{
			if (cb_createListViewTouchListener_Landroid_widget_AbsListView_ == null)
				cb_createListViewTouchListener_Landroid_widget_AbsListView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateListViewTouchListener_Landroid_widget_AbsListView_);
			return cb_createListViewTouchListener_Landroid_widget_AbsListView_;
		}

		static IntPtr n_CreateListViewTouchListener_Landroid_widget_AbsListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateListViewTouchListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createListViewTouchListener_Landroid_widget_AbsListView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissAdapter']/method[@name='createListViewTouchListener' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView']]"
		[Register ("createListViewTouchListener", "(Landroid/widget/AbsListView;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;", "GetCreateListViewTouchListener_Landroid_widget_AbsListView_Handler")]
		protected virtual global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener CreateListViewTouchListener (global::Android.Widget.AbsListView p0)
		{
			if (id_createListViewTouchListener_Landroid_widget_AbsListView_ == IntPtr.Zero)
				id_createListViewTouchListener_Landroid_widget_AbsListView_ = JNIEnv.GetMethodID (class_ref, "createListViewTouchListener", "(Landroid/widget/AbsListView;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;");

			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (JNIEnv.CallObjectMethod  (Handle, id_createListViewTouchListener_Landroid_widget_AbsListView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createListViewTouchListener", "(Landroid/widget/AbsListView;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
