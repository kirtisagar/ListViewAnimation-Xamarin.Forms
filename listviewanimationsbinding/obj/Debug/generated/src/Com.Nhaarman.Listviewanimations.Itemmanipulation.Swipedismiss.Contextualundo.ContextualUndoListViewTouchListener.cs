using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener", DoNotGenerateAcw=true)]
	public partial class ContextualUndoListViewTouchListener : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoListViewTouchListener.Callback']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoListViewTouchListener.Callback']/method[@name='onListScrolled' and count(parameter)=0]"
			[Register ("onListScrolled", "()V", "GetOnListScrolledHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener/ICallbackInvoker, ListViewAnimations")]
			void OnListScrolled ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoListViewTouchListener.Callback']/method[@name='onViewSwiped' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
			[Register ("onViewSwiped", "(JI)V", "GetOnViewSwiped_JIHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener/ICallbackInvoker, ListViewAnimations")]
			void OnViewSwiped (long p0, int p1);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback");
			IntPtr class_ref;

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoListViewTouchListener.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICallbackInvoker); }
			}

			static Delegate cb_onListScrolled;
#pragma warning disable 0169
			static Delegate GetOnListScrolledHandler ()
			{
				if (cb_onListScrolled == null)
					cb_onListScrolled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnListScrolled);
				return cb_onListScrolled;
			}

			static void n_OnListScrolled (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnListScrolled ();
			}
#pragma warning restore 0169

			IntPtr id_onListScrolled;
			public void OnListScrolled ()
			{
				if (id_onListScrolled == IntPtr.Zero)
					id_onListScrolled = JNIEnv.GetMethodID (class_ref, "onListScrolled", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onListScrolled);
			}

			static Delegate cb_onViewSwiped_JI;
#pragma warning disable 0169
			static Delegate GetOnViewSwiped_JIHandler ()
			{
				if (cb_onViewSwiped_JI == null)
					cb_onViewSwiped_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int>) n_OnViewSwiped_JI);
				return cb_onViewSwiped_JI;
			}

			static void n_OnViewSwiped_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnViewSwiped (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onViewSwiped_JI;
			public void OnViewSwiped (long p0, int p1)
			{
				if (id_onViewSwiped_JI == IntPtr.Zero)
					id_onViewSwiped_JI = JNIEnv.GetMethodID (class_ref, "onViewSwiped", "(JI)V");
				JNIEnv.CallVoidMethod (Handle, id_onViewSwiped_JI, new JValue (p0), new JValue (p1));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContextualUndoListViewTouchListener); }
		}

		protected ContextualUndoListViewTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoListViewTouchListener_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/constructor[@name='ContextualUndoListViewTouchListener' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoListViewTouchListener.Callback']]"
		[Register (".ctor", "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback;)V", "")]
		public ContextualUndoListViewTouchListener (global::Android.Widget.AbsListView p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContextualUndoListViewTouchListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoListViewTouchListener_Callback_ == IntPtr.Zero)
				id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoListViewTouchListener_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoListViewTouchListener$Callback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoListViewTouchListener_Callback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoListViewTouchListener_Callback_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isSwiping;
#pragma warning disable 0169
		static Delegate GetIsSwipingHandler ()
		{
			if (cb_isSwiping == null)
				cb_isSwiping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSwiping);
			return cb_isSwiping;
		}

		static bool n_IsSwiping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSwiping;
		}
#pragma warning restore 0169

		static IntPtr id_isSwiping;
		public virtual bool IsSwiping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/method[@name='isSwiping' and count(parameter)=0]"
			[Register ("isSwiping", "()Z", "GetIsSwipingHandler")]
			get {
				if (id_isSwiping == IntPtr.Zero)
					id_isSwiping = JNIEnv.GetMethodID (class_ref, "isSwiping", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isSwiping);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSwiping", "()Z"));
			}
		}

		static Delegate cb_makeScrollListener;
#pragma warning disable 0169
		static Delegate GetMakeScrollListenerHandler ()
		{
			if (cb_makeScrollListener == null)
				cb_makeScrollListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MakeScrollListener);
			return cb_makeScrollListener;
		}

		static IntPtr n_MakeScrollListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MakeScrollListener ());
		}
#pragma warning restore 0169

		static IntPtr id_makeScrollListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/method[@name='makeScrollListener' and count(parameter)=0]"
		[Register ("makeScrollListener", "()Landroid/widget/AbsListView$OnScrollListener;", "GetMakeScrollListenerHandler")]
		public virtual global::Android.Widget.AbsListView.IOnScrollListener MakeScrollListener ()
		{
			if (id_makeScrollListener == IntPtr.Zero)
				id_makeScrollListener = JNIEnv.GetMethodID (class_ref, "makeScrollListener", "()Landroid/widget/AbsListView$OnScrollListener;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IOnScrollListener> (JNIEnv.CallObjectMethod  (Handle, id_makeScrollListener), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView.IOnScrollListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeScrollListener", "()Landroid/widget/AbsListView$OnScrollListener;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
#pragma warning disable 0169
		static Delegate GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler ()
		{
			if (cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == null)
				cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_);
			return cb_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		}

		static void n_SetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
		[Register ("setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V", "GetSetDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_Handler")]
		public virtual void SetDismissableManager (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0)
		{
			if (id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ == IntPtr.Zero)
				id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_ = JNIEnv.GetMethodID (class_ref, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDismissableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager;)V"), new JValue (p0));
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoListViewTouchListener']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
		public virtual void SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), new JValue (p0));
		}

	}
}
