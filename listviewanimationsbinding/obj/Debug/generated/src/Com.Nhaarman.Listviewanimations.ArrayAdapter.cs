using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/ArrayAdapter", DoNotGenerateAcw=true)]
	public abstract partial class ArrayAdapter : global::Android.Widget.BaseAdapter, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter.IInsertable, global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.ISwappable, global::Java.Util.IList {


		static IntPtr mItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/field[@name='mItems']"
		[Register ("mItems")]
		protected global::System.Collections.IList MItems {
			get {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mItems_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mItems_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/ArrayAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayAdapter); }
		}

		protected ArrayAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/constructor[@name='ArrayAdapter' and count(parameter)=2 and parameter[1][@type='java.util.List'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/List;Z)V", "")]
		public ArrayAdapter (global::System.Collections.IList p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ArrayAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Z)V", new JValue (native_p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;Z)V", new JValue (native_p0), new JValue (p1));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_Z == IntPtr.Zero)
				id_ctor_Ljava_util_List_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Z, new JValue (native_p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/constructor[@name='ArrayAdapter' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public ArrayAdapter (global::System.Collections.IList p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ArrayAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/constructor[@name='ArrayAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ArrayAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ArrayAdapter)) {
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
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='getCount' and count(parameter)=0]"
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

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public virtual bool Add (global::Java.Lang.Object p0)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_add_Ljava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Object;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_add_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("add", "(ILjava/lang/Object;)V", "GetAdd_ILjava_lang_Object_Handler")]
		public virtual void Add (int p0, global::Java.Lang.Object p1)
		{
			if (id_add_ILjava_lang_Object_ == IntPtr.Zero)
				id_add_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_ILjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILjava/lang/Object;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_addAll_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddAll_arrayLjava_lang_Object_Handler ()
		{
			if (cb_addAll_arrayLjava_lang_Object_ == null)
				cb_addAll_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAll_arrayLjava_lang_Object_);
			return cb_addAll_arrayLjava_lang_Object_;
		}

		static bool n_AddAll_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			bool __ret = __this.AddAll (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("addAll", "([Ljava/lang/Object;)Z", "GetAddAll_arrayLjava_lang_Object_Handler")]
		public virtual bool AddAll (params global:: Java.Lang.Object[] p0)
		{
			if (id_addAll_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_addAll_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addAll", "([Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addAll_arrayLjava_lang_Object_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "([Ljava/lang/Object;)Z"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_addAll_IarrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddAll_IarrayLjava_lang_Object_Handler ()
		{
			if (cb_addAll_IarrayLjava_lang_Object_ == null)
				cb_addAll_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddAll_IarrayLjava_lang_Object_);
			return cb_addAll_IarrayLjava_lang_Object_;
		}

		static void n_AddAll_IarrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.AddAll (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addAll_IarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("addAll", "(I[Ljava/lang/Object;)V", "GetAddAll_IarrayLjava_lang_Object_Handler")]
		public virtual void AddAll (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_addAll_IarrayLjava_lang_Object_ == IntPtr.Zero)
				id_addAll_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addAll", "(I[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addAll_IarrayLjava_lang_Object_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(I[Ljava/lang/Object;)V"), new JValue (p0), new JValue (native_p1));
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addAll_ILjava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_ILjava_util_Collection_Handler ()
		{
			if (cb_addAll_ILjava_util_Collection_ == null)
				cb_addAll_ILjava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_AddAll_ILjava_util_Collection_);
			return cb_addAll_ILjava_util_Collection_;
		}

		static bool n_AddAll_ILjava_util_Collection_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p1 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_ILjava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='addAll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Collection']]"
		[Register ("addAll", "(ILjava/util/Collection;)Z", "GetAddAll_ILjava_util_Collection_Handler")]
		public virtual bool AddAll (int p0, global::System.Collections.ICollection p1)
		{
			if (id_addAll_ILjava_util_Collection_ == IntPtr.Zero)
				id_addAll_ILjava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(ILjava/util/Collection;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p1);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addAll_ILjava_util_Collection_, new JValue (p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(ILjava/util/Collection;)Z"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_addAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_Collection_Handler ()
		{
			if (cb_addAll_Ljava_util_Collection_ == null)
				cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddAll_Ljava_util_Collection_);
			return cb_addAll_Ljava_util_Collection_;
		}

		static bool n_AddAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("addAll", "(Ljava/util/Collection;)Z", "GetAddAll_Ljava_util_Collection_Handler")]
		public virtual bool AddAll (global::System.Collections.ICollection p0)
		{
			if (id_addAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_addAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addAll_Ljava_util_Collection_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/util/Collection;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_contains_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_Object_Handler ()
		{
			if (cb_contains_Ljava_lang_Object_ == null)
				cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_Object_);
			return cb_contains_Ljava_lang_Object_;
		}

		static bool n_Contains_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("contains", "(Ljava/lang/Object;)Z", "GetContains_Ljava_lang_Object_Handler")]
		public virtual bool Contains (global::Java.Lang.Object p0)
		{
			if (id_contains_Ljava_lang_Object_ == IntPtr.Zero)
				id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Ljava/lang/Object;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_containsAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetContainsAll_Ljava_util_Collection_Handler ()
		{
			if (cb_containsAll_Ljava_util_Collection_ == null)
				cb_containsAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsAll_Ljava_util_Collection_);
			return cb_containsAll_Ljava_util_Collection_;
		}

		static bool n_ContainsAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='containsAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("containsAll", "(Ljava/util/Collection;)Z", "GetContainsAll_Ljava_util_Collection_Handler")]
		public virtual bool ContainsAll (global::System.Collections.ICollection p0)
		{
			if (id_containsAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_containsAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "containsAll", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsAll_Ljava_util_Collection_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsAll", "(Ljava/util/Collection;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_indexOf_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIndexOf_Ljava_lang_Object_Handler ()
		{
			if (cb_indexOf_Ljava_lang_Object_ == null)
				cb_indexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IndexOf_Ljava_lang_Object_);
			return cb_indexOf_Ljava_lang_Object_;
		}

		static int n_IndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_indexOf_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("indexOf", "(Ljava/lang/Object;)I", "GetIndexOf_Ljava_lang_Object_Handler")]
		public virtual int IndexOf (global::Java.Lang.Object p0)
		{
			if (id_indexOf_Ljava_lang_Object_ == IntPtr.Zero)
				id_indexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "indexOf", "(Ljava/lang/Object;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_indexOf_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexOf", "(Ljava/lang/Object;)I"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod  (Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_lastIndexOf_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetLastIndexOf_Ljava_lang_Object_Handler ()
		{
			if (cb_lastIndexOf_Ljava_lang_Object_ == null)
				cb_lastIndexOf_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LastIndexOf_Ljava_lang_Object_);
			return cb_lastIndexOf_Ljava_lang_Object_;
		}

		static int n_LastIndexOf_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LastIndexOf (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lastIndexOf_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='lastIndexOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("lastIndexOf", "(Ljava/lang/Object;)I", "GetLastIndexOf_Ljava_lang_Object_Handler")]
		public virtual int LastIndexOf (global::Java.Lang.Object p0)
		{
			if (id_lastIndexOf_Ljava_lang_Object_ == IntPtr.Zero)
				id_lastIndexOf_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "lastIndexOf", "(Ljava/lang/Object;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_lastIndexOf_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lastIndexOf", "(Ljava/lang/Object;)I"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_listIterator;
#pragma warning disable 0169
		static Delegate GetListIteratorHandler ()
		{
			if (cb_listIterator == null)
				cb_listIterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListIterator);
			return cb_listIterator;
		}

		static IntPtr n_ListIterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListIterator ());
		}
#pragma warning restore 0169

		static IntPtr id_listIterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='listIterator' and count(parameter)=0]"
		[Register ("listIterator", "()Ljava/util/ListIterator;", "GetListIteratorHandler")]
		public virtual global::Java.Util.IListIterator ListIterator ()
		{
			if (id_listIterator == IntPtr.Zero)
				id_listIterator = JNIEnv.GetMethodID (class_ref, "listIterator", "()Ljava/util/ListIterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod  (Handle, id_listIterator), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listIterator", "()Ljava/util/ListIterator;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_listIterator_I;
#pragma warning disable 0169
		static Delegate GetListIterator_IHandler ()
		{
			if (cb_listIterator_I == null)
				cb_listIterator_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ListIterator_I);
			return cb_listIterator_I;
		}

		static IntPtr n_ListIterator_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListIterator (p0));
		}
#pragma warning restore 0169

		static IntPtr id_listIterator_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='listIterator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("listIterator", "(I)Ljava/util/ListIterator;", "GetListIterator_IHandler")]
		public virtual global::Java.Util.IListIterator ListIterator (int p0)
		{
			if (id_listIterator_I == IntPtr.Zero)
				id_listIterator_I = JNIEnv.GetMethodID (class_ref, "listIterator", "(I)Ljava/util/ListIterator;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallObjectMethod  (Handle, id_listIterator_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Util.IListIterator> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listIterator", "(I)Ljava/util/ListIterator;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_;
#pragma warning disable 0169
		static Delegate GetPropagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_Handler ()
		{
			if (cb_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_ == null)
				cb_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PropagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_);
			return cb_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_;
		}

		static void n_PropagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.BaseAdapter p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PropagateNotifyDataSetChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='propagateNotifyDataSetChanged' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register ("propagateNotifyDataSetChanged", "(Landroid/widget/BaseAdapter;)V", "GetPropagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_Handler")]
		public virtual void PropagateNotifyDataSetChanged (global::Android.Widget.BaseAdapter p0)
		{
			if (id_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
				id_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "propagateNotifyDataSetChanged", "(Landroid/widget/BaseAdapter;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_propagateNotifyDataSetChanged_Landroid_widget_BaseAdapter_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "propagateNotifyDataSetChanged", "(Landroid/widget/BaseAdapter;)V"), new JValue (p0));
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Remove_I);
			return cb_remove_I;
		}

		static IntPtr n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remove (p0));
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Ljava/lang/Object;", "GetRemove_IHandler")]
		public virtual global::Java.Lang.Object Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_remove_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)Ljava/lang/Object;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static bool n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Remove (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Z", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual bool Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_remove_Ljava_lang_Object_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_removeAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_util_Collection_Handler ()
		{
			if (cb_removeAll_Ljava_util_Collection_ == null)
				cb_removeAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveAll_Ljava_util_Collection_);
			return cb_removeAll_Ljava_util_Collection_;
		}

		static bool n_RemoveAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("removeAll", "(Ljava/util/Collection;)Z", "GetRemoveAll_Ljava_util_Collection_Handler")]
		public virtual bool RemoveAll (global::System.Collections.ICollection p0)
		{
			if (id_removeAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_removeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeAll_Ljava_util_Collection_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/util/Collection;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removePositions_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRemovePositions_Ljava_util_Collection_Handler ()
		{
			if (cb_removePositions_Ljava_util_Collection_ == null)
				cb_removePositions_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemovePositions_Ljava_util_Collection_);
			return cb_removePositions_Ljava_util_Collection_;
		}

		static IntPtr n_RemovePositions_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<Java.Lang.Integer> p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.RemovePositions (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removePositions_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='removePositions' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("removePositions", "(Ljava/util/Collection;)Ljava/util/Collection;", "GetRemovePositions_Ljava_util_Collection_Handler")]
		public virtual global::System.Collections.ICollection RemovePositions (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
		{
			if (id_removePositions_Ljava_util_Collection_ == IntPtr.Zero)
				id_removePositions_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "removePositions", "(Ljava/util/Collection;)Ljava/util/Collection;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.ToLocalJniHandle (p0);

			global::System.Collections.ICollection __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_removePositions_Ljava_util_Collection_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePositions", "(Ljava/util/Collection;)Ljava/util/Collection;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_retainAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetRetainAll_Ljava_util_Collection_Handler ()
		{
			if (cb_retainAll_Ljava_util_Collection_ == null)
				cb_retainAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RetainAll_Ljava_util_Collection_);
			return cb_retainAll_Ljava_util_Collection_;
		}

		static bool n_RetainAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.ICollection p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RetainAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_retainAll_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='retainAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("retainAll", "(Ljava/util/Collection;)Z", "GetRetainAll_Ljava_util_Collection_Handler")]
		public virtual bool RetainAll (global::System.Collections.ICollection p0)
		{
			if (id_retainAll_Ljava_util_Collection_ == IntPtr.Zero)
				id_retainAll_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "retainAll", "(Ljava/util/Collection;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_retainAll_Ljava_util_Collection_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retainAll", "(Ljava/util/Collection;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_set_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_lang_Object_Handler ()
		{
			if (cb_set_ILjava_lang_Object_ == null)
				cb_set_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Set_ILjava_lang_Object_);
			return cb_set_ILjava_lang_Object_;
		}

		static IntPtr n_Set_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetSet_ILjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object Set (int p0, global::Java.Lang.Object p1)
		{
			if (id_set_ILjava_lang_Object_ == IntPtr.Zero)
				id_set_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_set_ILjava_lang_Object_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
		}

		static Delegate cb_subList_II;
#pragma warning disable 0169
		static Delegate GetSubList_IIHandler ()
		{
			if (cb_subList_II == null)
				cb_subList_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SubList_II);
			return cb_subList_II;
		}

		static IntPtr n_SubList_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SubList (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_subList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='subList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("subList", "(II)Ljava/util/List;", "GetSubList_IIHandler")]
		public virtual global::System.Collections.IList SubList (int p0, int p1)
		{
			if (id_subList_II == IntPtr.Zero)
				id_subList_II = JNIEnv.GetMethodID (class_ref, "subList", "(II)Ljava/util/List;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_subList_II, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subList", "(II)Ljava/util/List;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwapItems (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_swapItems_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='swapItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual global::Java.Lang.Object[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/Object;");

			if (GetType () == ThresholdType)
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			else
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "()[Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_toArray_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetToArray_arrayLjava_lang_Object_Handler ()
		{
			if (cb_toArray_arrayLjava_lang_Object_ == null)
				cb_toArray_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_arrayLjava_lang_Object_);
			return cb_toArray_arrayLjava_lang_Object_;
		}

		static IntPtr n_ToArray_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.ArrayAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.ArrayAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toArray_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations']/class[@name='ArrayAdapter']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
		[Register ("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "GetToArray_arrayLjava_lang_Object_Handler")]
		public virtual global::Java.Lang.Object[] ToArray (global::Java.Lang.Object[] p0)
		{
			if (id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			global::Java.Lang.Object[] __ret;
			if (GetType () == ThresholdType)
				__ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_toArray_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			else
				__ret = (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/ArrayAdapter", DoNotGenerateAcw=true)]
	internal partial class ArrayAdapterInvoker : ArrayAdapter, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateAdditionAdapter.IInsertable {

		public ArrayAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayAdapterInvoker); }
		}

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.widget']/class[@name='BaseAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (position), new JValue (convertView), new JValue (parent)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
