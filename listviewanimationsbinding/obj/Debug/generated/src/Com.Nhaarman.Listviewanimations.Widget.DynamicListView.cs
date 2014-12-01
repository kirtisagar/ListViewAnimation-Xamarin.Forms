using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/widget/DynamicListView", DoNotGenerateAcw=true)]
	public partial class DynamicListView : global::Android.Widget.ListView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.OnHoverCellListener']"
		[Register ("com/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener", "", "Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnHoverCellListenerInvoker")]
		public partial interface IOnHoverCellListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.OnHoverCellListener']/method[@name='onHoverCellCreated' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("onHoverCellCreated", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;", "GetOnHoverCellCreated_Landroid_graphics_drawable_Drawable_Handler:Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnHoverCellListenerInvoker, ListViewAnimations")]
			global::Android.Graphics.Drawables.Drawable OnHoverCellCreated (global::Android.Graphics.Drawables.Drawable p0);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener", DoNotGenerateAcw=true)]
		internal class IOnHoverCellListenerInvoker : global::Java.Lang.Object, IOnHoverCellListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener");
			IntPtr class_ref;

			public static IOnHoverCellListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnHoverCellListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.widget.DynamicListView.OnHoverCellListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnHoverCellListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnHoverCellListenerInvoker); }
			}

			static Delegate cb_onHoverCellCreated_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetOnHoverCellCreated_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_onHoverCellCreated_Landroid_graphics_drawable_Drawable_ == null)
					cb_onHoverCellCreated_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnHoverCellCreated_Landroid_graphics_drawable_Drawable_);
				return cb_onHoverCellCreated_Landroid_graphics_drawable_Drawable_;
			}

			static IntPtr n_OnHoverCellCreated_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnHoverCellCreated (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onHoverCellCreated_Landroid_graphics_drawable_Drawable_;
			public global::Android.Graphics.Drawables.Drawable OnHoverCellCreated (global::Android.Graphics.Drawables.Drawable p0)
			{
				if (id_onHoverCellCreated_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_onHoverCellCreated_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "onHoverCellCreated", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;");
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_onHoverCellCreated_Landroid_graphics_drawable_Drawable_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		public delegate global::Android.Graphics.Drawables.Drawable HoverCellHandler (global::Android.Graphics.Drawables.Drawable p0);

		[global::Android.Runtime.Register ("mono/com/nhaarman/listviewanimations/widget/DynamicListView_OnHoverCellListenerImplementor")]
		internal sealed class IOnHoverCellListenerImplementor : global::Java.Lang.Object, IOnHoverCellListener {

			public IOnHoverCellListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nhaarman/listviewanimations/widget/DynamicListView_OnHoverCellListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			}

#pragma warning disable 0649
			public HoverCellHandler Handler;
#pragma warning restore 0649

			public Android.Graphics.Drawables.Drawable OnHoverCellCreated (global::Android.Graphics.Drawables.Drawable p0)
			{
				var __h = Handler;
				return __h != null ? __h (p0) : default (global::Android.Graphics.Drawables.Drawable);
			}

			internal static bool __IsEmpty (IOnHoverCellListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.OnItemMovedListener']"
		[Register ("com/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener", "", "Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnItemMovedListenerInvoker")]
		public partial interface IOnItemMovedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.OnItemMovedListener']/method[@name='onItemMoved' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onItemMoved", "(I)V", "GetOnItemMoved_IHandler:Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnItemMovedListenerInvoker, ListViewAnimations")]
			void OnItemMoved (int p0);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener", DoNotGenerateAcw=true)]
		internal class IOnItemMovedListenerInvoker : global::Java.Lang.Object, IOnItemMovedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener");
			IntPtr class_ref;

			public static IOnItemMovedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnItemMovedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.widget.DynamicListView.OnItemMovedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnItemMovedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnItemMovedListenerInvoker); }
			}

			static Delegate cb_onItemMoved_I;
#pragma warning disable 0169
			static Delegate GetOnItemMoved_IHandler ()
			{
				if (cb_onItemMoved_I == null)
					cb_onItemMoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemMoved_I);
				return cb_onItemMoved_I;
			}

			static void n_OnItemMoved_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemMoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onItemMoved_I;
			public void OnItemMoved (int p0)
			{
				if (id_onItemMoved_I == IntPtr.Zero)
					id_onItemMoved_I = JNIEnv.GetMethodID (class_ref, "onItemMoved", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_onItemMoved_I, new JValue (p0));
			}

		}

		public partial class ItemMovedEventArgs : global::System.EventArgs {

			public ItemMovedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/nhaarman/listviewanimations/widget/DynamicListView_OnItemMovedListenerImplementor")]
		internal sealed class IOnItemMovedListenerImplementor : global::Java.Lang.Object, IOnItemMovedListener {

			object sender;

			public IOnItemMovedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nhaarman/listviewanimations/widget/DynamicListView_OnItemMovedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemMovedEventArgs> Handler;
#pragma warning restore 0649

			public void OnItemMoved (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ItemMovedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnItemMovedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.Swappable']"
		[Register ("com/nhaarman/listviewanimations/widget/DynamicListView$Swappable", "", "Com.Nhaarman.Listviewanimations.Widget.DynamicListView/ISwappableInvoker")]
		public partial interface ISwappable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/interface[@name='DynamicListView.Swappable']/method[@name='swapItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("swapItems", "(II)V", "GetSwapItems_IIHandler:Com.Nhaarman.Listviewanimations.Widget.DynamicListView/ISwappableInvoker, ListViewAnimations")]
			void SwapItems (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/widget/DynamicListView$Swappable", DoNotGenerateAcw=true)]
		internal class ISwappableInvoker : global::Java.Lang.Object, ISwappable {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/widget/DynamicListView$Swappable");
			IntPtr class_ref;

			public static ISwappable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISwappable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.widget.DynamicListView.Swappable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISwappableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ISwappableInvoker); }
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
				global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.ISwappable __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.ISwappable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SwapItems (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_swapItems_II;
			public void SwapItems (int p0, int p1)
			{
				if (id_swapItems_II == IntPtr.Zero)
					id_swapItems_II = JNIEnv.GetMethodID (class_ref, "swapItems", "(II)V");
				JNIEnv.CallVoidMethod (Handle, id_swapItems_II, new JValue (p0), new JValue (p1));
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/widget/DynamicListView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamicListView); }
		}

		protected DynamicListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public DynamicListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DynamicListView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public DynamicListView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DynamicListView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/constructor[@name='DynamicListView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public DynamicListView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DynamicListView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
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
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsParentHorizontalScrollContainer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isParentHorizontalScrollContainer;
		static IntPtr id_setIsParentHorizontalScrollContainer_Z;
		public virtual bool IsParentHorizontalScrollContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='isParentHorizontalScrollContainer' and count(parameter)=0]"
			[Register ("isParentHorizontalScrollContainer", "()Z", "GetIsParentHorizontalScrollContainerHandler")]
			get {
				if (id_isParentHorizontalScrollContainer == IntPtr.Zero)
					id_isParentHorizontalScrollContainer = JNIEnv.GetMethodID (class_ref, "isParentHorizontalScrollContainer", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isParentHorizontalScrollContainer);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isParentHorizontalScrollContainer", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='setIsParentHorizontalScrollContainer' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Landroid_content_Context_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), new JValue (p0));
		}

		static Delegate cb_setAdapter_Landroid_widget_BaseAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_BaseAdapter_Handler ()
		{
			if (cb_setAdapter_Landroid_widget_BaseAdapter_ == null)
				cb_setAdapter_Landroid_widget_BaseAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_BaseAdapter_);
			return cb_setAdapter_Landroid_widget_BaseAdapter_;
		}

		static void n_SetAdapter_Landroid_widget_BaseAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.BaseAdapter p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.BaseAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register ("setAdapter", "(Landroid/widget/BaseAdapter;)V", "GetSetAdapter_Landroid_widget_BaseAdapter_Handler")]
		public virtual void SetAdapter (global::Android.Widget.BaseAdapter p0)
		{
			if (id_setAdapter_Landroid_widget_BaseAdapter_ == IntPtr.Zero)
				id_setAdapter_Landroid_widget_BaseAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/BaseAdapter;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAdapter_Landroid_widget_BaseAdapter_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/BaseAdapter;)V"), new JValue (p0));
		}

		static Delegate cb_setDynamicTouchChild_I;
#pragma warning disable 0169
		static Delegate GetSetDynamicTouchChild_IHandler ()
		{
			if (cb_setDynamicTouchChild_I == null)
				cb_setDynamicTouchChild_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDynamicTouchChild_I);
			return cb_setDynamicTouchChild_I;
		}

		static void n_SetDynamicTouchChild_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDynamicTouchChild (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDynamicTouchChild_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='setDynamicTouchChild' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDynamicTouchChild", "(I)V", "GetSetDynamicTouchChild_IHandler")]
		public virtual void SetDynamicTouchChild (int p0)
		{
			if (id_setDynamicTouchChild_I == IntPtr.Zero)
				id_setDynamicTouchChild_I = JNIEnv.GetMethodID (class_ref, "setDynamicTouchChild", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDynamicTouchChild_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDynamicTouchChild", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_;
#pragma warning disable 0169
		static Delegate GetSetOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_Handler ()
		{
			if (cb_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_ == null)
				cb_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_);
			return cb_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_;
		}

		static void n_SetOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener p0 = (global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnHoverCellListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='setOnHoverCellListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.widget.DynamicListView.OnHoverCellListener']]"
		[Register ("setOnHoverCellListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener;)V", "GetSetOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_Handler")]
		public virtual void SetOnHoverCellListener (global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener p0)
		{
			if (id_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_ == IntPtr.Zero)
				id_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_ = JNIEnv.GetMethodID (class_ref, "setOnHoverCellListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnHoverCellListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnHoverCellListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnHoverCellListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnHoverCellListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_Handler ()
		{
			if (cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_ == null)
				cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_);
			return cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_;
		}

		static void n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener p0 = (global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemMovedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.widget']/class[@name='DynamicListView']/method[@name='setOnItemMovedListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.widget.DynamicListView.OnItemMovedListener']]"
		[Register ("setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener;)V", "GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_Handler")]
		public virtual void SetOnItemMovedListener (global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener p0)
		{
			if (id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_ == IntPtr.Zero)
				id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_widget_DynamicListView_OnItemMovedListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/widget/DynamicListView$OnItemMovedListener;)V"), new JValue (p0));
		}

#region "Event implementation for Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListener"
		WeakReference weak_implementor_HoverCell;
		global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor ImplHoverCell {
			get {
				if (weak_implementor_HoverCell == null || !weak_implementor_HoverCell.IsAlive)
					return null;
				return weak_implementor_HoverCell.Target as global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor;
			}
			set { weak_implementor_HoverCell = new WeakReference (value, true); }
		}

		public global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.HoverCellHandler HoverCell {
			get {
				global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor impl = ImplHoverCell;
				return impl == null ? null : impl.Handler;
			}
			set {
				global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor impl = ImplHoverCell;
				if (impl == null) {
					impl = new global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor ();
					ImplHoverCell = impl;
				} else
					impl.Handler = value;
			}
		}

		WeakReference weak_implementor_SetOnHoverCellListener;

		global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor __CreateIOnHoverCellListenerImplementor ()
		{
			return new global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnHoverCellListenerImplementor ();
		}
#endregion
#region "Event implementation for Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener"
		public event EventHandler<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.ItemMovedEventArgs> ItemMoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						__CreateIOnItemMovedListenerImplementor,
						SetOnItemMovedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListenerImplementor.__IsEmpty,
						__v => SetOnItemMovedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemMovedListener;

		global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListenerImplementor __CreateIOnItemMovedListenerImplementor ()
		{
			return new global::Com.Nhaarman.Listviewanimations.Widget.DynamicListView.IOnItemMovedListenerImplementor (this);
		}
#endregion
	}
}
