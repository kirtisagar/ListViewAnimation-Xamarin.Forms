using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter", DoNotGenerateAcw=true)]
	public partial class ContextualUndoAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoListViewTouchListener.ICallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoAdapter.CountDownFormatter']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter/ICountDownFormatterInvoker")]
		public partial interface ICountDownFormatter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoAdapter.CountDownFormatter']/method[@name='getCountDownString' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getCountDownString", "(J)Ljava/lang/String;", "GetGetCountDownString_JHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter/ICountDownFormatterInvoker, ListViewAnimations")]
			string GetCountDownString (long p0);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter", DoNotGenerateAcw=true)]
		internal class ICountDownFormatterInvoker : global::Java.Lang.Object, ICountDownFormatter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter");
			IntPtr class_ref;

			public static ICountDownFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICountDownFormatter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.CountDownFormatter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICountDownFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ICountDownFormatterInvoker); }
			}

			static Delegate cb_getCountDownString_J;
#pragma warning disable 0169
			static Delegate GetGetCountDownString_JHandler ()
			{
				if (cb_getCountDownString_J == null)
					cb_getCountDownString_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetCountDownString_J);
				return cb_getCountDownString_J;
			}

			static IntPtr n_GetCountDownString_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.ICountDownFormatter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.ICountDownFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetCountDownString (p0));
			}
#pragma warning restore 0169

			IntPtr id_getCountDownString_J;
			public string GetCountDownString (long p0)
			{
				if (id_getCountDownString_J == IntPtr.Zero)
					id_getCountDownString_J = JNIEnv.GetMethodID (class_ref, "getCountDownString", "(J)Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getCountDownString_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.CountDownRunnable']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownRunnable", DoNotGenerateAcw=true)]
		public partial class CountDownRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CountDownRunnable); }
			}

			protected CountDownRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.CountDownRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.CountDownRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.CountDownRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoAdapter.DeleteItemCallback']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter/IDeleteItemCallbackInvoker")]
		public partial interface IDeleteItemCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/interface[@name='ContextualUndoAdapter.DeleteItemCallback']/method[@name='deleteItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("deleteItem", "(I)V", "GetDeleteItem_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter/IDeleteItemCallbackInvoker, ListViewAnimations")]
			void DeleteItem (int p0);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback", DoNotGenerateAcw=true)]
		internal class IDeleteItemCallbackInvoker : global::Java.Lang.Object, IDeleteItemCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback");
			IntPtr class_ref;

			public static IDeleteItemCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDeleteItemCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.DeleteItemCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeleteItemCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IDeleteItemCallbackInvoker); }
			}

			static Delegate cb_deleteItem_I;
#pragma warning disable 0169
			static Delegate GetDeleteItem_IHandler ()
			{
				if (cb_deleteItem_I == null)
					cb_deleteItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeleteItem_I);
				return cb_deleteItem_I;
			}

			static void n_DeleteItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.IDeleteItemCallback __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.IDeleteItemCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.DeleteItem (p0);
			}
#pragma warning restore 0169

			IntPtr id_deleteItem_I;
			public void DeleteItem (int p0)
			{
				if (id_deleteItem_I == IntPtr.Zero)
					id_deleteItem_I = JNIEnv.GetMethodID (class_ref, "deleteItem", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_deleteItem_I, new JValue (p0));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.HierarchyChangeListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$HierarchyChangeListener", DoNotGenerateAcw=true)]
		public partial class HierarchyChangeListener : global::Java.Lang.Object, global::Android.Views.ViewGroup.IOnHierarchyChangeListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$HierarchyChangeListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HierarchyChangeListener); }
			}

			protected HierarchyChangeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler ()
			{
				if (cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == null)
					cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_);
				return cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
			}

			static void n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.HierarchyChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.HierarchyChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnChildViewAdded (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.HierarchyChangeListener']/method[@name='onChildViewAdded' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
			[Register ("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler")]
			public virtual void OnChildViewAdded (global::Android.Views.View p0, global::Android.Views.View p1)
			{
				if (id_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
					id_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onChildViewAdded_Landroid_view_View_Landroid_view_View_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V"), new JValue (p0), new JValue (p1));
			}

			static Delegate cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler ()
			{
				if (cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == null)
					cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_);
				return cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
			}

			static void n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.HierarchyChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.HierarchyChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnChildViewRemoved (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.HierarchyChangeListener']/method[@name='onChildViewRemoved' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
			[Register ("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler")]
			public virtual void OnChildViewRemoved (global::Android.Views.View p0, global::Android.Views.View p1)
			{
				if (id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
					id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V"), new JValue (p0), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.RemoveViewAnimatorUpdateListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$RemoveViewAnimatorUpdateListener", DoNotGenerateAcw=true)]
		public partial class RemoveViewAnimatorUpdateListener : global::Java.Lang.Object {

			protected RemoveViewAnimatorUpdateListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.UndoListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$UndoListener", DoNotGenerateAcw=true)]
		public partial class UndoListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$UndoListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UndoListener); }
			}

			protected UndoListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.UndoListener']/constructor[@name='ContextualUndoAdapter.UndoListener' and count(parameter)=2 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoView']]"
			[Register (".ctor", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView;)V", "")]
			public UndoListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __self, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (UndoListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoView_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoView_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoView_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.UndoListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.UndoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onClick_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.UndoListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), new JValue (p0));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter.ViewHolder']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$ViewHolder", DoNotGenerateAcw=true)]
		public partial class ViewHolder : global::Java.Lang.Object {

			protected ViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContextualUndoAdapter); }
		}

		protected ContextualUndoAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_IILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/constructor[@name='ContextualUndoAdapter' and count(parameter)=4 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.DeleteItemCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;IILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", "")]
		public ContextualUndoAdapter (global::Android.Widget.BaseAdapter p0, int p1, int p2, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.IDeleteItemCallback p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContextualUndoAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;IILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;IILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_IILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_IILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;IILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_IILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_IILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_IIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/constructor[@name='ContextualUndoAdapter' and count(parameter)=5 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.DeleteItemCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;IIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", "")]
		public ContextualUndoAdapter (global::Android.Widget.BaseAdapter p0, int p1, int p2, int p3, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.IDeleteItemCallback p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContextualUndoAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;IIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;IIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_IIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_IIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;IIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_IIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_IIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
		}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_IIIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_CountDownFormatter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/constructor[@name='ContextualUndoAdapter' and count(parameter)=7 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.DeleteItemCallback'] and parameter[7][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo.ContextualUndoAdapter.CountDownFormatter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;IIIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter;)V", "")]
		public ContextualUndoAdapter (global::Android.Widget.BaseAdapter p0, int p1, int p2, int p3, int p4, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.IDeleteItemCallback p5, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter.ICountDownFormatter p6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ContextualUndoAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;IIIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;IIIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter;)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_IIIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_CountDownFormatter_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_IIIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_CountDownFormatter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;IIIILcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$DeleteItemCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/contextualundo/ContextualUndoAdapter$CountDownFormatter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_IIIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_CountDownFormatter_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_IIIILcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_DeleteItemCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_contextualundo_ContextualUndoAdapter_CountDownFormatter_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6));
		}

		static Delegate cb_animateRemovePendingItem;
#pragma warning disable 0169
		static Delegate GetAnimateRemovePendingItemHandler ()
		{
			if (cb_animateRemovePendingItem == null)
				cb_animateRemovePendingItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AnimateRemovePendingItem);
			return cb_animateRemovePendingItem;
		}

		static void n_AnimateRemovePendingItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateRemovePendingItem ();
		}
#pragma warning restore 0169

		static IntPtr id_animateRemovePendingItem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='animateRemovePendingItem' and count(parameter)=0]"
		[Register ("animateRemovePendingItem", "()V", "GetAnimateRemovePendingItemHandler")]
		public virtual void AnimateRemovePendingItem ()
		{
			if (id_animateRemovePendingItem == IntPtr.Zero)
				id_animateRemovePendingItem = JNIEnv.GetMethodID (class_ref, "animateRemovePendingItem", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateRemovePendingItem);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateRemovePendingItem", "()V"));
		}

		static Delegate cb_cancelCountDown;
#pragma warning disable 0169
		static Delegate GetCancelCountDownHandler ()
		{
			if (cb_cancelCountDown == null)
				cb_cancelCountDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelCountDown);
			return cb_cancelCountDown;
		}

		static void n_CancelCountDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCountDown ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelCountDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='cancelCountDown' and count(parameter)=0]"
		[Register ("cancelCountDown", "()V", "GetCancelCountDownHandler")]
		public virtual void CancelCountDown ()
		{
			if (id_cancelCountDown == IntPtr.Zero)
				id_cancelCountDown = JNIEnv.GetMethodID (class_ref, "cancelCountDown", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_cancelCountDown);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelCountDown", "()V"));
		}

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "")]
		public override sealed global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnListScrolled ();
		}
#pragma warning restore 0169

		static IntPtr id_onListScrolled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='onListScrolled' and count(parameter)=0]"
		[Register ("onListScrolled", "()V", "GetOnListScrolledHandler")]
		public virtual void OnListScrolled ()
		{
			if (id_onListScrolled == IntPtr.Zero)
				id_onListScrolled = JNIEnv.GetMethodID (class_ref, "onListScrolled", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onListScrolled);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onListScrolled", "()V"));
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Bundle_ == null)
				cb_onRestoreInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Bundle_);
			return cb_onRestoreInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Bundle;)V", "GetOnRestoreInstanceState_Landroid_os_Bundle_Handler")]
		public virtual void OnRestoreInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onRestoreInstanceState_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"), new JValue (p0));
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			if (id_onSaveInstanceState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSaveInstanceState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSaveInstanceState_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "(Landroid/os/Bundle;)V"), new JValue (p0));
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnViewSwiped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onViewSwiped_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='onViewSwiped' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("onViewSwiped", "(JI)V", "GetOnViewSwiped_JIHandler")]
		public virtual void OnViewSwiped (long p0, int p1)
		{
			if (id_onViewSwiped_JI == IntPtr.Zero)
				id_onViewSwiped_JI = JNIEnv.GetMethodID (class_ref, "onViewSwiped", "(JI)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onViewSwiped_JI, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onViewSwiped", "(JI)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_removePendingItem;
#pragma warning disable 0169
		static Delegate GetRemovePendingItemHandler ()
		{
			if (cb_removePendingItem == null)
				cb_removePendingItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemovePendingItem);
			return cb_removePendingItem;
		}

		static void n_RemovePendingItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemovePendingItem ();
		}
#pragma warning restore 0169

		static IntPtr id_removePendingItem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='removePendingItem' and count(parameter)=0]"
		[Register ("removePendingItem", "()V", "GetRemovePendingItemHandler")]
		public virtual void RemovePendingItem ()
		{
			if (id_removePendingItem == IntPtr.Zero)
				id_removePendingItem = JNIEnv.GetMethodID (class_ref, "removePendingItem", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removePendingItem);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePendingItem", "()V"));
		}

		static Delegate cb_removePendingItem_Z;
#pragma warning disable 0169
		static Delegate GetRemovePendingItem_ZHandler ()
		{
			if (cb_removePendingItem_Z == null)
				cb_removePendingItem_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RemovePendingItem_Z);
			return cb_removePendingItem_Z;
		}

		static void n_RemovePendingItem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemovePendingItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePendingItem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='removePendingItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("removePendingItem", "(Z)V", "GetRemovePendingItem_ZHandler")]
		public virtual void RemovePendingItem (bool p0)
		{
			if (id_removePendingItem_Z == IntPtr.Zero)
				id_removePendingItem_Z = JNIEnv.GetMethodID (class_ref, "removePendingItem", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removePendingItem_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePendingItem", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_swipeViewAtPosition_I;
#pragma warning disable 0169
		static Delegate GetSwipeViewAtPosition_IHandler ()
		{
			if (cb_swipeViewAtPosition_I == null)
				cb_swipeViewAtPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SwipeViewAtPosition_I);
			return cb_swipeViewAtPosition_I;
		}

		static void n_SwipeViewAtPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.Contextualundo.ContextualUndoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwipeViewAtPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_swipeViewAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.contextualundo']/class[@name='ContextualUndoAdapter']/method[@name='swipeViewAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swipeViewAtPosition", "(I)V", "GetSwipeViewAtPosition_IHandler")]
		public virtual void SwipeViewAtPosition (int p0)
		{
			if (id_swipeViewAtPosition_I == IntPtr.Zero)
				id_swipeViewAtPosition_I = JNIEnv.GetMethodID (class_ref, "swipeViewAtPosition", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_swipeViewAtPosition_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swipeViewAtPosition", "(I)V"), new JValue (p0));
		}

	}
}
