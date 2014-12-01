using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView", DoNotGenerateAcw=true)]
	public partial class ContextualUndoView : global::Android.Widget.FrameLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContextualUndoView); }
		}

		protected ContextualUndoView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/constructor[@name='ContextualUndoView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public ContextualUndoView (global::Android.Content.Context p0, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContextualUndoView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;II)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;II)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
				id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_II, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getContentView;
#pragma warning disable 0169
		static Delegate GetGetContentViewHandler ()
		{
			if (cb_getContentView == null)
				cb_getContentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentView);
			return cb_getContentView;
		}

		static IntPtr n_GetContentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentView);
		}
#pragma warning restore 0169

		static IntPtr id_getContentView;
		public virtual global::Android.Views.View ContentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='getContentView' and count(parameter)=0]"
			[Register ("getContentView", "()Landroid/view/View;", "GetGetContentViewHandler")]
			get {
				if (id_getContentView == IntPtr.Zero)
					id_getContentView = JNIEnv.GetMethodID (class_ref, "getContentView", "()Landroid/view/View;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getContentView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isContentDisplayed;
#pragma warning disable 0169
		static Delegate GetIsContentDisplayedHandler ()
		{
			if (cb_isContentDisplayed == null)
				cb_isContentDisplayed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContentDisplayed);
			return cb_isContentDisplayed;
		}

		static bool n_IsContentDisplayed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContentDisplayed;
		}
#pragma warning restore 0169

		static IntPtr id_isContentDisplayed;
		public virtual bool IsContentDisplayed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='isContentDisplayed' and count(parameter)=0]"
			[Register ("isContentDisplayed", "()Z", "GetIsContentDisplayedHandler")]
			get {
				if (id_isContentDisplayed == IntPtr.Zero)
					id_isContentDisplayed = JNIEnv.GetMethodID (class_ref, "isContentDisplayed", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isContentDisplayed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContentDisplayed", "()Z"));
			}
		}

		static Delegate cb_getItemId;
#pragma warning disable 0169
		static Delegate GetGetItemIdHandler ()
		{
			if (cb_getItemId == null)
				cb_getItemId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetItemId);
			return cb_getItemId;
		}

		static long n_GetItemId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemId;
		}
#pragma warning restore 0169

		static Delegate cb_setItemId_J;
#pragma warning disable 0169
		static Delegate GetSetItemId_JHandler ()
		{
			if (cb_setItemId_J == null)
				cb_setItemId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetItemId_J);
			return cb_setItemId_J;
		}

		static void n_SetItemId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemId;
		static IntPtr id_setItemId_J;
		public virtual long ItemId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='getItemId' and count(parameter)=0]"
			[Register ("getItemId", "()J", "GetGetItemIdHandler")]
			get {
				if (id_getItemId == IntPtr.Zero)
					id_getItemId = JNIEnv.GetMethodID (class_ref, "getItemId", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getItemId);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='setItemId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setItemId", "(J)V", "GetSetItemId_JHandler")]
			set {
				if (id_setItemId_J == IntPtr.Zero)
					id_setItemId_J = JNIEnv.GetMethodID (class_ref, "setItemId", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setItemId_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemId", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_displayContentView;
#pragma warning disable 0169
		static Delegate GetDisplayContentViewHandler ()
		{
			if (cb_displayContentView == null)
				cb_displayContentView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisplayContentView);
			return cb_displayContentView;
		}

		static void n_DisplayContentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayContentView ();
		}
#pragma warning restore 0169

		static IntPtr id_displayContentView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='displayContentView' and count(parameter)=0]"
		[Register ("displayContentView", "()V", "GetDisplayContentViewHandler")]
		public virtual void DisplayContentView ()
		{
			if (id_displayContentView == IntPtr.Zero)
				id_displayContentView = JNIEnv.GetMethodID (class_ref, "displayContentView", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_displayContentView);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayContentView", "()V"));
		}

		static Delegate cb_displayUndo;
#pragma warning disable 0169
		static Delegate GetDisplayUndoHandler ()
		{
			if (cb_displayUndo == null)
				cb_displayUndo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisplayUndo);
			return cb_displayUndo;
		}

		static void n_DisplayUndo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayUndo ();
		}
#pragma warning restore 0169

		static IntPtr id_displayUndo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='displayUndo' and count(parameter)=0]"
		[Register ("displayUndo", "()V", "GetDisplayUndoHandler")]
		public virtual void DisplayUndo ()
		{
			if (id_displayUndo == IntPtr.Zero)
				id_displayUndo = JNIEnv.GetMethodID (class_ref, "displayUndo", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_displayUndo);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "displayUndo", "()V"));
		}

		static Delegate cb_updateContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetUpdateContentView_Landroid_view_View_Handler ()
		{
			if (cb_updateContentView_Landroid_view_View_ == null)
				cb_updateContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateContentView_Landroid_view_View_);
			return cb_updateContentView_Landroid_view_View_;
		}

		static void n_UpdateContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContentView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='updateContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("updateContentView", "(Landroid/view/View;)V", "GetUpdateContentView_Landroid_view_View_Handler")]
		public virtual void UpdateContentView (global::Android.Views.View p0)
		{
			if (id_updateContentView_Landroid_view_View_ == IntPtr.Zero)
				id_updateContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "updateContentView", "(Landroid/view/View;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateContentView_Landroid_view_View_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContentView", "(Landroid/view/View;)V"), new JValue (p0));
		}

		static Delegate cb_updateCountDownTimer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateCountDownTimer_Ljava_lang_String_Handler ()
		{
			if (cb_updateCountDownTimer_Ljava_lang_String_ == null)
				cb_updateCountDownTimer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateCountDownTimer_Ljava_lang_String_);
			return cb_updateCountDownTimer_Ljava_lang_String_;
		}

		static void n_UpdateCountDownTimer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCountDownTimer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateCountDownTimer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoView']/method[@name='updateCountDownTimer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateCountDownTimer", "(Ljava/lang/String;)V", "GetUpdateCountDownTimer_Ljava_lang_String_Handler")]
		public virtual void UpdateCountDownTimer (string p0)
		{
			if (id_updateCountDownTimer_Ljava_lang_String_ == IntPtr.Zero)
				id_updateCountDownTimer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateCountDownTimer", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_updateCountDownTimer_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCountDownTimer", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
