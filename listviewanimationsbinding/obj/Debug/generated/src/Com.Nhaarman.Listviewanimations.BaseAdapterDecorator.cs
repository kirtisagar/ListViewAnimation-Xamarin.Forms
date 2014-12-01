using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/BaseAdapterDecorator", DoNotGenerateAcw=true)]
	public abstract partial class BaseAdapterDecorator : global::Android.Widget.BaseAdapter, global::Android.Widget.ISectionIndexer, global::Com.Nhaarman.Listviewanimations.IListViewSetter, global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.ISwappable {


		static IntPtr mDecoratedBaseAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/field[@name='mDecoratedBaseAdapter']"
		[Register ("mDecoratedBaseAdapter")]
		protected global::Android.Widget.BaseAdapter MDecoratedBaseAdapter {
			get {
				if (mDecoratedBaseAdapter_jfieldId == IntPtr.Zero)
					mDecoratedBaseAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mDecoratedBaseAdapter", "Landroid/widget/BaseAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDecoratedBaseAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDecoratedBaseAdapter_jfieldId == IntPtr.Zero)
					mDecoratedBaseAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mDecoratedBaseAdapter", "Landroid/widget/BaseAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDecoratedBaseAdapter_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/BaseAdapterDecorator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAdapterDecorator); }
		}

		protected BaseAdapterDecorator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/constructor[@name='BaseAdapterDecorator' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public BaseAdapterDecorator (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BaseAdapterDecorator)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_, new JValue (p0));
		}

		static Delegate cb_getAbsListView;
#pragma warning disable 0169
		static Delegate GetGetAbsListViewHandler ()
		{
			if (cb_getAbsListView == null)
				cb_getAbsListView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAbsListView);
			return cb_getAbsListView;
		}

		static IntPtr n_GetAbsListView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AbsListView);
		}
#pragma warning restore 0169

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
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AbsListView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAbsListView;
		static IntPtr id_setAbsListView_Landroid_widget_AbsListView_;
		public virtual global::Android.Widget.AbsListView AbsListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getAbsListView' and count(parameter)=0]"
			[Register ("getAbsListView", "()Landroid/widget/AbsListView;", "GetGetAbsListViewHandler")]
			get {
				if (id_getAbsListView == IntPtr.Zero)
					id_getAbsListView = JNIEnv.GetMethodID (class_ref, "getAbsListView", "()Landroid/widget/AbsListView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (JNIEnv.CallObjectMethod  (Handle, id_getAbsListView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAbsListView", "()Landroid/widget/AbsListView;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='setAbsListView' and count(parameter)=1 and parameter[1][@type='android.widget.AbsListView']]"
			[Register ("setAbsListView", "(Landroid/widget/AbsListView;)V", "GetSetAbsListView_Landroid_widget_AbsListView_Handler")]
			set {
				if (id_setAbsListView_Landroid_widget_AbsListView_ == IntPtr.Zero)
					id_setAbsListView_Landroid_widget_AbsListView_ = JNIEnv.GetMethodID (class_ref, "setAbsListView", "(Landroid/widget/AbsListView;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAbsListView_Landroid_widget_AbsListView_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAbsListView", "(Landroid/widget/AbsListView;)V"), new JValue (value));
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
			}
		}

		static Delegate cb_getDecoratedBaseAdapter;
#pragma warning disable 0169
		static Delegate GetGetDecoratedBaseAdapterHandler ()
		{
			if (cb_getDecoratedBaseAdapter == null)
				cb_getDecoratedBaseAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecoratedBaseAdapter);
			return cb_getDecoratedBaseAdapter;
		}

		static IntPtr n_GetDecoratedBaseAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DecoratedBaseAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getDecoratedBaseAdapter;
		public virtual global::Android.Widget.BaseAdapter DecoratedBaseAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getDecoratedBaseAdapter' and count(parameter)=0]"
			[Register ("getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;", "GetGetDecoratedBaseAdapterHandler")]
			get {
				if (id_getDecoratedBaseAdapter == IntPtr.Zero)
					id_getDecoratedBaseAdapter = JNIEnv.GetMethodID (class_ref, "getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallObjectMethod  (Handle, id_getDecoratedBaseAdapter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecoratedBaseAdapter", "()Landroid/widget/BaseAdapter;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isParentHorizontalScrollContainer;
#pragma warning disable 0169
		static Delegate GetIsParentHorizontalScrollContainerHandler ()
		{
			if (cb_isParentHorizontalScrollContainer == null)
				cb_isParentHorizontalScrollContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsParentHorizontalScrollContainer);
			return cb_isParentHorizontalScrollContainer;
		}

		static bool n_IsParentHorizontalScrollContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsParentHorizontalScrollContainer;
		}
#pragma warning restore 0169

		static Delegate cb_setIsParentHorizontalScrollContainer_Z;
#pragma warning disable 0169
		static Delegate GetSetIsParentHorizontalScrollContainer_ZHandler ()
		{
			if (cb_setIsParentHorizontalScrollContainer_Z == null)
				cb_setIsParentHorizontalScrollContainer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsParentHorizontalScrollContainer_Z);
			return cb_setIsParentHorizontalScrollContainer_Z;
		}

		static void n_SetIsParentHorizontalScrollContainer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsParentHorizontalScrollContainer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isParentHorizontalScrollContainer;
		static IntPtr id_setIsParentHorizontalScrollContainer_Z;
		public virtual bool IsParentHorizontalScrollContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='isParentHorizontalScrollContainer' and count(parameter)=0]"
			[Register ("isParentHorizontalScrollContainer", "()Z", "GetIsParentHorizontalScrollContainerHandler")]
			get {
				if (id_isParentHorizontalScrollContainer == IntPtr.Zero)
					id_isParentHorizontalScrollContainer = JNIEnv.GetMethodID (class_ref, "isParentHorizontalScrollContainer", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isParentHorizontalScrollContainer);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isParentHorizontalScrollContainer", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='setIsParentHorizontalScrollContainer' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsParentHorizontalScrollContainer", "(Z)V", "GetSetIsParentHorizontalScrollContainer_ZHandler")]
			set {
				if (id_setIsParentHorizontalScrollContainer_Z == IntPtr.Zero)
					id_setIsParentHorizontalScrollContainer_Z = JNIEnv.GetMethodID (class_ref, "setIsParentHorizontalScrollContainer", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIsParentHorizontalScrollContainer_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsParentHorizontalScrollContainer", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getTouchChild;
#pragma warning disable 0169
		static Delegate GetGetTouchChildHandler ()
		{
			if (cb_getTouchChild == null)
				cb_getTouchChild = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTouchChild);
			return cb_getTouchChild;
		}

		static int n_GetTouchChild (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchChild;
		}
#pragma warning restore 0169

		static Delegate cb_setTouchChild_I;
#pragma warning disable 0169
		static Delegate GetSetTouchChild_IHandler ()
		{
			if (cb_setTouchChild_I == null)
				cb_setTouchChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTouchChild_I);
			return cb_setTouchChild_I;
		}

		static void n_SetTouchChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TouchChild = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTouchChild;
		static IntPtr id_setTouchChild_I;
		public virtual int TouchChild {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getTouchChild' and count(parameter)=0]"
			[Register ("getTouchChild", "()I", "GetGetTouchChildHandler")]
			get {
				if (id_getTouchChild == IntPtr.Zero)
					id_getTouchChild = JNIEnv.GetMethodID (class_ref, "getTouchChild", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTouchChild);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTouchChild", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='setTouchChild' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTouchChild", "(I)V", "GetSetTouchChild_IHandler")]
			set {
				if (id_setTouchChild_I == IntPtr.Zero)
					id_setTouchChild_I = JNIEnv.GetMethodID (class_ref, "setTouchChild", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTouchChild_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTouchChild", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");

			if (GetType () == ThresholdType)
				return JNIEnv.CallLongMethod  (Handle, id_getItemId_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), new JValue (p0));
		}

		static Delegate cb_getPositionForSection_I;
#pragma warning disable 0169
		static Delegate GetGetPositionForSection_IHandler ()
		{
			if (cb_getPositionForSection_I == null)
				cb_getPositionForSection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPositionForSection_I);
			return cb_getPositionForSection_I;
		}

		static int n_GetPositionForSection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPositionForSection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionForSection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getPositionForSection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPositionForSection", "(I)I", "GetGetPositionForSection_IHandler")]
		public virtual int GetPositionForSection (int p0)
		{
			if (id_getPositionForSection_I == IntPtr.Zero)
				id_getPositionForSection_I = JNIEnv.GetMethodID (class_ref, "getPositionForSection", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getPositionForSection_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionForSection", "(I)I"), new JValue (p0));
		}

		static Delegate cb_getSectionForPosition_I;
#pragma warning disable 0169
		static Delegate GetGetSectionForPosition_IHandler ()
		{
			if (cb_getSectionForPosition_I == null)
				cb_getSectionForPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSectionForPosition_I);
			return cb_getSectionForPosition_I;
		}

		static int n_GetSectionForPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSectionForPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getSectionForPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getSectionForPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSectionForPosition", "(I)I", "GetGetSectionForPosition_IHandler")]
		public virtual int GetSectionForPosition (int p0)
		{
			if (id_getSectionForPosition_I == IntPtr.Zero)
				id_getSectionForPosition_I = JNIEnv.GetMethodID (class_ref, "getSectionForPosition", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getSectionForPosition_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSectionForPosition", "(I)I"), new JValue (p0));
		}

		static Delegate cb_getSections;
#pragma warning disable 0169
		static Delegate GetGetSectionsHandler ()
		{
			if (cb_getSections == null)
				cb_getSections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSections);
			return cb_getSections;
		}

		static IntPtr n_GetSections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSections ());
		}
#pragma warning restore 0169

		static IntPtr id_getSections;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getSections' and count(parameter)=0]"
		[Register ("getSections", "()[Ljava/lang/Object;", "GetGetSectionsHandler")]
		public virtual global::Java.Lang.Object[] GetSections ()
		{
			if (id_getSections == IntPtr.Zero)
				id_getSections = JNIEnv.GetMethodID (class_ref, "getSections", "()[Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSections), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			else
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSections", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");

			global::Android.Views.View __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_notifyDataSetChanged_Z;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChanged_ZHandler ()
		{
			if (cb_notifyDataSetChanged_Z == null)
				cb_notifyDataSetChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_NotifyDataSetChanged_Z);
			return cb_notifyDataSetChanged_Z;
		}

		static void n_NotifyDataSetChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyDataSetChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='notifyDataSetChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("notifyDataSetChanged", "(Z)V", "GetNotifyDataSetChanged_ZHandler")]
		public virtual void NotifyDataSetChanged (bool p0)
		{
			if (id_notifyDataSetChanged_Z == IntPtr.Zero)
				id_notifyDataSetChanged_Z = JNIEnv.GetMethodID (class_ref, "notifyDataSetChanged", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_notifyDataSetChanged_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyDataSetChanged", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_swapItems_II;
#pragma warning disable 0169
		static Delegate GetSwapItems_IIHandler ()
		{
			if (cb_swapItems_II == null)
				cb_swapItems_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SwapItems_II);
			return cb_swapItems_II;
		}

		static void n_SwapItems_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapItems (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_swapItems_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='BaseAdapterDecorator']/method[@name='swapItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("swapItems", "(II)V", "GetSwapItems_IIHandler")]
		public virtual void SwapItems (int p0, int p1)
		{
			if (id_swapItems_II == IntPtr.Zero)
				id_swapItems_II = JNIEnv.GetMethodID (class_ref, "swapItems", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_swapItems_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swapItems", "(II)V"), new JValue (p0), new JValue (p1));
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/BaseAdapterDecorator", DoNotGenerateAcw=true)]
	internal partial class BaseAdapterDecoratorInvoker : BaseAdapterDecorator {

		public BaseAdapterDecoratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAdapterDecoratorInvoker); }
		}

	}

}
