using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener", DoNotGenerateAcw=true)]
	public partial class SwipeDismissListViewTouchListener : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.ISwipeOnTouchListener {


		static IntPtr mAnimationTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/field[@name='mAnimationTime']"
		[Register ("mAnimationTime")]
		protected long MAnimationTime {
			get {
				if (mAnimationTime_jfieldId == IntPtr.Zero)
					mAnimationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnimationTime", "J");
				return JNIEnv.GetLongField (Handle, mAnimationTime_jfieldId);
			}
			set {
				if (mAnimationTime_jfieldId == IntPtr.Zero)
					mAnimationTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnimationTime", "J");
				JNIEnv.SetField (Handle, mAnimationTime_jfieldId, value);
			}
		}

		static IntPtr mPendingDismisses_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/field[@name='mPendingDismisses']"
		[Register ("mPendingDismisses")]
		protected global::System.Collections.IList MPendingDismisses {
			get {
				if (mPendingDismisses_jfieldId == IntPtr.Zero)
					mPendingDismisses_jfieldId = JNIEnv.GetFieldID (class_ref, "mPendingDismisses", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPendingDismisses_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPendingDismisses_jfieldId == IntPtr.Zero)
					mPendingDismisses_jfieldId = JNIEnv.GetFieldID (class_ref, "mPendingDismisses", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPendingDismisses_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData", DoNotGenerateAcw=true)]
		protected internal partial class PendingDismissData : global::Java.Lang.Object, global::Java.Lang.IComparable {


			static IntPtr position_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']/field[@name='position']"
			[Register ("position")]
			public int Position {
				get {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
					return JNIEnv.GetIntField (Handle, position_jfieldId);
				}
				set {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "I");
					JNIEnv.SetField (Handle, position_jfieldId, value);
				}
			}

			static IntPtr view_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']/field[@name='view']"
			[Register ("view")]
			public global::Android.Views.View View {
				get {
					if (view_jfieldId == IntPtr.Zero)
						view_jfieldId = JNIEnv.GetFieldID (class_ref, "view", "Landroid/view/View;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, view_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (view_jfieldId == IntPtr.Zero)
						view_jfieldId = JNIEnv.GetFieldID (class_ref, "view", "Landroid/view/View;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, view_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PendingDismissData); }
			}

			protected PendingDismissData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ILandroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']/constructor[@name='SwipeDismissListViewTouchListener.PendingDismissData' and count(parameter)=3 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeDismissListViewTouchListener'] and parameter[2][@type='int'] and parameter[3][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;ILandroid/view/View;)V", "")]
			public PendingDismissData (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __self, int p1, global::Android.Views.View p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PendingDismissData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILandroid/view/View;)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILandroid/view/View;)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ILandroid_view_View_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener;ILandroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ILandroid_view_View_, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_ILandroid_view_View_, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler ()
			{
				if (cb_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == null)
					cb_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_);
				return cb_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
			}

			static int n_CompareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0 = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData']]"
			[Register ("compareTo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)I", "GetCompareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler")]
			public virtual int CompareTo (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0)
			{
				if (id_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == IntPtr.Zero)
					id_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)I"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
			{
				if (cb_compareTo_Ljava_lang_Object_ == null)
					cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
				return cb_compareTo_Ljava_lang_Object_;
			}

			static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CompareTo (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compareTo_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener.PendingDismissData']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
			public virtual int CompareTo (global::Java.Lang.Object p0)
			{
				if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Ljava/lang/Object;)I"), new JValue (p0));
				return __ret;
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeDismissListViewTouchListener); }
		}

		protected SwipeDismissListViewTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/constructor[@name='SwipeDismissListViewTouchListener' and count(parameter)=3 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.OnDismissCallback'] and parameter[3][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeOnScrollListener']]"
		[Register (".ctor", "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", "")]
		public SwipeDismissListViewTouchListener (global::Android.Widget.AbsListView p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback p1, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeOnScrollListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SwipeDismissListViewTouchListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_ == IntPtr.Zero)
				id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/AbsListView;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeOnScrollListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_AbsListView_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeOnScrollListener_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSwiping;
		}
#pragma warning restore 0169

		static IntPtr id_isSwiping;
		public virtual bool IsSwiping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='isSwiping' and count(parameter)=0]"
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

		static Delegate cb_allowSwipe;
#pragma warning disable 0169
		static Delegate GetAllowSwipeHandler ()
		{
			if (cb_allowSwipe == null)
				cb_allowSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AllowSwipe);
			return cb_allowSwipe;
		}

		static void n_AllowSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_allowSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='allowSwipe' and count(parameter)=0]"
		[Register ("allowSwipe", "()V", "GetAllowSwipeHandler")]
		public virtual void AllowSwipe ()
		{
			if (id_allowSwipe == IntPtr.Zero)
				id_allowSwipe = JNIEnv.GetMethodID (class_ref, "allowSwipe", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_allowSwipe);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allowSwipe", "()V"));
		}

		static Delegate cb_createPendingDismissData_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCreatePendingDismissData_ILandroid_view_View_Handler ()
		{
			if (cb_createPendingDismissData_ILandroid_view_View_ == null)
				cb_createPendingDismissData_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CreatePendingDismissData_ILandroid_view_View_);
			return cb_createPendingDismissData_ILandroid_view_View_;
		}

		static IntPtr n_CreatePendingDismissData_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePendingDismissData (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPendingDismissData_ILandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='createPendingDismissData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("createPendingDismissData", "(ILandroid/view/View;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;", "GetCreatePendingDismissData_ILandroid_view_View_Handler")]
		protected virtual global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData CreatePendingDismissData (int p0, global::Android.Views.View p1)
		{
			if (id_createPendingDismissData_ILandroid_view_View_ == IntPtr.Zero)
				id_createPendingDismissData_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "createPendingDismissData", "(ILandroid/view/View;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;");

			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (JNIEnv.CallObjectMethod  (Handle, id_createPendingDismissData_ILandroid_view_View_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPendingDismissData", "(ILandroid/view/View;)Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_disallowSwipe;
#pragma warning disable 0169
		static Delegate GetDisallowSwipeHandler ()
		{
			if (cb_disallowSwipe == null)
				cb_disallowSwipe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisallowSwipe);
			return cb_disallowSwipe;
		}

		static void n_DisallowSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisallowSwipe ();
		}
#pragma warning restore 0169

		static IntPtr id_disallowSwipe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='disallowSwipe' and count(parameter)=0]"
		[Register ("disallowSwipe", "()V", "GetDisallowSwipeHandler")]
		public virtual void DisallowSwipe ()
		{
			if (id_disallowSwipe == IntPtr.Zero)
				id_disallowSwipe = JNIEnv.GetMethodID (class_ref, "disallowSwipe", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disallowSwipe);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disallowSwipe", "()V"));
		}

		static Delegate cb_finalizeDismiss;
#pragma warning disable 0169
		static Delegate GetFinalizeDismissHandler ()
		{
			if (cb_finalizeDismiss == null)
				cb_finalizeDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinalizeDismiss);
			return cb_finalizeDismiss;
		}

		static void n_FinalizeDismiss (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalizeDismiss ();
		}
#pragma warning restore 0169

		static IntPtr id_finalizeDismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='finalizeDismiss' and count(parameter)=0]"
		[Register ("finalizeDismiss", "()V", "GetFinalizeDismissHandler")]
		protected virtual void FinalizeDismiss ()
		{
			if (id_finalizeDismiss == IntPtr.Zero)
				id_finalizeDismiss = JNIEnv.GetMethodID (class_ref, "finalizeDismiss", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_finalizeDismiss);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizeDismiss", "()V"));
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual void NotifyDataSetChanged ()
		{
			if (id_notifyDataSetChanged == IntPtr.Zero)
				id_notifyDataSetChanged = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyDataSetChanged);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "()V"));
		}

		static Delegate cb_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
#pragma warning disable 0169
		static Delegate GetOnDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler ()
		{
			if (cb_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == null)
				cb_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_);
			return cb_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
		}

		static void n_OnDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0 = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='onDismiss' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData']]"
		[Register ("onDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V", "GetOnDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler")]
		protected virtual void OnDismiss (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0)
		{
			if (id_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == IntPtr.Zero)
				id_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNIEnv.GetMethodID (class_ref, "onDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V"), new JValue (p0));
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
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

		static Delegate cb_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
#pragma warning disable 0169
		static Delegate GetPerformDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler ()
		{
			if (cb_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == null)
				cb_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PerformDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_);
			return cb_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
		}

		static void n_PerformDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0 = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PerformDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='performDismiss' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData']]"
		[Register ("performDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V", "GetPerformDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_Handler")]
		protected virtual void PerformDismiss (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData p0)
		{
			if (id_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ == IntPtr.Zero)
				id_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_ = JNIEnv.GetMethodID (class_ref, "performDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_performDismiss_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_SwipeDismissListViewTouchListener_PendingDismissData_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performDismiss", "(Lcom/nhaarman/listviewanimations/itemmanipulation/swipedismiss/SwipeDismissListViewTouchListener$PendingDismissData;)V"), new JValue (p0));
		}

		static Delegate cb_recycleDismissedViewsItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRecycleDismissedViewsItems_Ljava_util_List_Handler ()
		{
			if (cb_recycleDismissedViewsItems_Ljava_util_List_ == null)
				cb_recycleDismissedViewsItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecycleDismissedViewsItems_Ljava_util_List_);
			return cb_recycleDismissedViewsItems_Ljava_util_List_;
		}

		static void n_RecycleDismissedViewsItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> p0 = global::Android.Runtime.JavaList<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecycleDismissedViewsItems (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recycleDismissedViewsItems_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='recycleDismissedViewsItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("recycleDismissedViewsItems", "(Ljava/util/List;)V", "GetRecycleDismissedViewsItems_Ljava_util_List_Handler")]
		protected virtual void RecycleDismissedViewsItems (global::System.Collections.Generic.IList<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData> p0)
		{
			if (id_recycleDismissedViewsItems_Ljava_util_List_ == IntPtr.Zero)
				id_recycleDismissedViewsItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "recycleDismissedViewsItems", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener.PendingDismissData>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recycleDismissedViewsItems_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycleDismissedViewsItems", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.SwipeDismissListViewTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDismissableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDismissableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_swipedismiss_DismissableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/class[@name='SwipeDismissListViewTouchListener']/method[@name='setDismissableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager']]"
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

	}
}
