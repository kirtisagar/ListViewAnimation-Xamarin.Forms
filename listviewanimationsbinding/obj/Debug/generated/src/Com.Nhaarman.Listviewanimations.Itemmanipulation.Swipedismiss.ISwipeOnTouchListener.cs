using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/interface[@name='SwipeOnTouchListener']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnTouchListener", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListenerInvoker")]
	public partial interface ISwipeOnTouchListener : global::Android.Views.View.IOnTouchListener {

		bool IsSwiping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/interface[@name='SwipeOnTouchListener']/method[@name='isSwiping' and count(parameter)=0]"
			[Register ("isSwiping", "()Z", "GetIsSwipingHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListenerInvoker, ListViewAnimations")] get;
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnTouchListener", DoNotGenerateAcw=true)]
	internal class ISwipeOnTouchListenerInvoker : global::Java.Lang.Object, ISwipeOnTouchListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnTouchListener");
		IntPtr class_ref;

		public static ISwipeOnTouchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISwipeOnTouchListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeOnTouchListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISwipeOnTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISwipeOnTouchListenerInvoker); }
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSwiping;
		}
#pragma warning restore 0169

		IntPtr id_isSwiping;
		public bool IsSwiping {
			get {
				if (id_isSwiping == IntPtr.Zero)
					id_isSwiping = JNIEnv.GetMethodID (class_ref, "isSwiping", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isSwiping);
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		public global::System.Boolean OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, new JValue (v), new JValue (e));
			return __ret;
		}

	}

}
