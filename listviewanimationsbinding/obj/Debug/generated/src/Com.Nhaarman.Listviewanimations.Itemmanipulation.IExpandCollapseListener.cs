using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='ExpandCollapseListener']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/ExpandCollapseListener", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListenerInvoker")]
	public partial interface IExpandCollapseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='ExpandCollapseListener']/method[@name='onItemCollapsed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onItemCollapsed", "(I)V", "GetOnItemCollapsed_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListenerInvoker, ListViewAnimations")]
		void OnItemCollapsed (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/interface[@name='ExpandCollapseListener']/method[@name='onItemExpanded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onItemExpanded", "(I)V", "GetOnItemExpanded_IHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListenerInvoker, ListViewAnimations")]
		void OnItemExpanded (int p0);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/ExpandCollapseListener", DoNotGenerateAcw=true)]
	internal class IExpandCollapseListenerInvoker : global::Java.Lang.Object, IExpandCollapseListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/ExpandCollapseListener");
		IntPtr class_ref;

		public static IExpandCollapseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpandCollapseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.ExpandCollapseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpandCollapseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IExpandCollapseListenerInvoker); }
		}

		static Delegate cb_onItemCollapsed_I;
#pragma warning disable 0169
		static Delegate GetOnItemCollapsed_IHandler ()
		{
			if (cb_onItemCollapsed_I == null)
				cb_onItemCollapsed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemCollapsed_I);
			return cb_onItemCollapsed_I;
		}

		static void n_OnItemCollapsed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemCollapsed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onItemCollapsed_I;
		public void OnItemCollapsed (int p0)
		{
			if (id_onItemCollapsed_I == IntPtr.Zero)
				id_onItemCollapsed_I = JNIEnv.GetMethodID (class_ref, "onItemCollapsed", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_onItemCollapsed_I, new JValue (p0));
		}

		static Delegate cb_onItemExpanded_I;
#pragma warning disable 0169
		static Delegate GetOnItemExpanded_IHandler ()
		{
			if (cb_onItemExpanded_I == null)
				cb_onItemExpanded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemExpanded_I);
			return cb_onItemExpanded_I;
		}

		static void n_OnItemExpanded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IExpandCollapseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemExpanded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onItemExpanded_I;
		public void OnItemExpanded (int p0)
		{
			if (id_onItemExpanded_I == IntPtr.Zero)
				id_onItemExpanded_I = JNIEnv.GetMethodID (class_ref, "onItemExpanded", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_onItemExpanded_I, new JValue (p0));
		}

	}

	public partial class ItemCollapsedEventArgs : global::System.EventArgs {

		public ItemCollapsedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class ItemExpandedEventArgs : global::System.EventArgs {

		public ItemExpandedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nhaarman/listviewanimations/itemmanipulation/ExpandCollapseListenerImplementor")]
	internal sealed class IExpandCollapseListenerImplementor : global::Java.Lang.Object, IExpandCollapseListener {

		object sender;

		public IExpandCollapseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nhaarman/listviewanimations/itemmanipulation/ExpandCollapseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ItemCollapsedEventArgs> OnItemCollapsedHandler;
#pragma warning restore 0649

		public void OnItemCollapsed (int p0)
		{
			var __h = OnItemCollapsedHandler;
			if (__h != null)
				__h (sender, new ItemCollapsedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ItemExpandedEventArgs> OnItemExpandedHandler;
#pragma warning restore 0649

		public void OnItemExpanded (int p0)
		{
			var __h = OnItemExpandedHandler;
			if (__h != null)
				__h (sender, new ItemExpandedEventArgs (p0));
		}

		internal static bool __IsEmpty (IExpandCollapseListenerImplementor value)
		{
			return value.OnItemCollapsedHandler == null && value.OnItemExpandedHandler == null;
		}
	}

}
