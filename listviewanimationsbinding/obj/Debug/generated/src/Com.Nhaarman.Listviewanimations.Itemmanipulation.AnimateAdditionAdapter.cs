using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/AnimateAdditionAdapter", DoNotGenerateAcw=true)]
	public partial class AnimateAdditionAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='AnimateAdditionAdapter.Insertable']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/AnimateAdditionAdapter$Insertable", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter/IInsertableInvoker")]
		public partial interface IInsertable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='AnimateAdditionAdapter.Insertable']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
			[Register ("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler:Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter/IInsertableInvoker, ListViewAnimations")]
			void Add (int p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/AnimateAdditionAdapter$Insertable", DoNotGenerateAcw=true)]
		internal class IInsertableInvoker : global::Java.Lang.Object, IInsertable {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/AnimateAdditionAdapter$Insertable");
			IntPtr class_ref;

			public static IInsertable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInsertable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.AnimateAdditionAdapter.Insertable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInsertableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IInsertableInvoker); }
			}

			static Delegate cb_add_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetAdd_ILjava_lang_Object_Handler ()
			{
				if (cb_add_ILjava_lang_Object_ == null)
					cb_add_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILjava_lang_Object_);
				return cb_add_ILjava_lang_Object_;
			}

			static void n_Add_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter.IInsertable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter.IInsertable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_add_ILjava_lang_Object_;
			public void Add (int p0, global::Java.Lang.Object p1)
			{
				if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
					id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JNIEnv.CallVoidMethod (Handle, id_add_ILjava_lang_Object_, new JValue (p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/AnimateAdditionAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimateAdditionAdapter); }
		}

		protected AnimateAdditionAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/constructor[@name='AnimateAdditionAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public AnimateAdditionAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnimateAdditionAdapter)) {
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

		static Delegate cb_insert_arrayLandroid_util_Pair_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLandroid_util_Pair_Handler ()
		{
			if (cb_insert_arrayLandroid_util_Pair_ == null)
				cb_insert_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_arrayLandroid_util_Pair_);
			return cb_insert_arrayLandroid_util_Pair_;
		}

		static void n_Insert_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.Pair[] p0 = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_arrayLandroid_util_Pair_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.util.Pair...']]"
		[Register ("insert", "([Landroid/util/Pair;)V", "GetInsert_arrayLandroid_util_Pair_Handler")]
		public virtual void Insert (params global:: Android.Util.Pair[] p0)
		{
			if (id_insert_arrayLandroid_util_Pair_ == IntPtr.Zero)
				id_insert_arrayLandroid_util_Pair_ = JNIEnv.GetMethodID (class_ref, "insert", "([Landroid/util/Pair;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_insert_arrayLandroid_util_Pair_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "([Landroid/util/Pair;)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insert_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_Object_Handler ()
		{
			if (cb_insert_ILjava_lang_Object_ == null)
				cb_insert_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_ILjava_lang_Object_);
			return cb_insert_ILjava_lang_Object_;
		}

		static void n_Insert_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("insert", "(ILjava/lang/Object;)V", "GetInsert_ILjava_lang_Object_Handler")]
		public virtual void Insert (int p0, global::Java.Lang.Object p1)
		{
			if (id_insert_ILjava_lang_Object_ == IntPtr.Zero)
				id_insert_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_insert_ILjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/Object;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_insert_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_util_List_Handler ()
		{
			if (cb_insert_Ljava_util_List_ == null)
				cb_insert_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_Ljava_util_List_);
			return cb_insert_Ljava_util_List_;
		}

		static void n_Insert_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Android.Util.Pair> p0 = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("insert", "(Ljava/util/List;)V", "GetInsert_Ljava_util_List_Handler")]
		public virtual void Insert (global::System.Collections.Generic.IList<global::Android.Util.Pair> p0)
		{
			if (id_insert_Ljava_util_List_ == IntPtr.Zero)
				id_insert_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_insert_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setInsertionAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetInsertionAnimationDuration_JHandler ()
		{
			if (cb_setInsertionAnimationDuration_J == null)
				cb_setInsertionAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetInsertionAnimationDuration_J);
			return cb_setInsertionAnimationDuration_J;
		}

		static void n_SetInsertionAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInsertionAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInsertionAnimationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='setInsertionAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInsertionAnimationDuration", "(J)V", "GetSetInsertionAnimationDuration_JHandler")]
		public virtual void SetInsertionAnimationDuration (long p0)
		{
			if (id_setInsertionAnimationDuration_J == IntPtr.Zero)
				id_setInsertionAnimationDuration_J = JNIEnv.GetMethodID (class_ref, "setInsertionAnimationDuration", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInsertionAnimationDuration_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInsertionAnimationDuration", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setListView_Landroid_widget_ListView_;
#pragma warning disable 0169
		static Delegate GetSetListView_Landroid_widget_ListView_Handler ()
		{
			if (cb_setListView_Landroid_widget_ListView_ == null)
				cb_setListView_Landroid_widget_ListView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListView_Landroid_widget_ListView_);
			return cb_setListView_Landroid_widget_ListView_;
		}

		static void n_SetListView_Landroid_widget_ListView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListView_Landroid_widget_ListView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='setListView' and count(parameter)=1 and parameter[1][@type='android.widget.ListView']]"
		[Register ("setListView", "(Landroid/widget/ListView;)V", "GetSetListView_Landroid_widget_ListView_Handler")]
		public virtual void SetListView (global::Android.Widget.ListView p0)
		{
			if (id_setListView_Landroid_widget_ListView_ == IntPtr.Zero)
				id_setListView_Landroid_widget_ListView_ = JNIEnv.GetMethodID (class_ref, "setListView", "(Landroid/widget/ListView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setListView_Landroid_widget_ListView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListView", "(Landroid/widget/ListView;)V"), new JValue (p0));
		}

		static Delegate cb_setScrolldownAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetScrolldownAnimationDuration_JHandler ()
		{
			if (cb_setScrolldownAnimationDuration_J == null)
				cb_setScrolldownAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetScrolldownAnimationDuration_J);
			return cb_setScrolldownAnimationDuration_J;
		}

		static void n_SetScrolldownAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrolldownAnimationDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrolldownAnimationDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='setScrolldownAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setScrolldownAnimationDuration", "(J)V", "GetSetScrolldownAnimationDuration_JHandler")]
		public virtual void SetScrolldownAnimationDuration (long p0)
		{
			if (id_setScrolldownAnimationDuration_J == IntPtr.Zero)
				id_setScrolldownAnimationDuration_J = JNIEnv.GetMethodID (class_ref, "setScrolldownAnimationDuration", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScrolldownAnimationDuration_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrolldownAnimationDuration", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setShouldAnimateDown_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateDown_ZHandler ()
		{
			if (cb_setShouldAnimateDown_Z == null)
				cb_setShouldAnimateDown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldAnimateDown_Z);
			return cb_setShouldAnimateDown_Z;
		}

		static void n_SetShouldAnimateDown_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateDown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateAdditionAdapter']/method[@name='setShouldAnimateDown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldAnimateDown", "(Z)V", "GetSetShouldAnimateDown_ZHandler")]
		public virtual void SetShouldAnimateDown (bool p0)
		{
			if (id_setShouldAnimateDown_Z == IntPtr.Zero)
				id_setShouldAnimateDown_Z = JNIEnv.GetMethodID (class_ref, "setShouldAnimateDown", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateDown_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateDown", "(Z)V"), new JValue (p0));
		}

	}
}
