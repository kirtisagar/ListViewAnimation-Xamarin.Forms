using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='ResourceAnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/ResourceAnimationAdapter", DoNotGenerateAcw=true)]
	public abstract partial class ResourceAnimationAdapter : global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/ResourceAnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceAnimationAdapter); }
		}

		protected ResourceAnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='ResourceAnimationAdapter']/constructor[@name='ResourceAnimationAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", "")]
		public ResourceAnimationAdapter (global::Android.Widget.BaseAdapter p0, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ResourceAnimationAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Landroid_content_Context_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getAnimationResourceId;
#pragma warning disable 0169
		static Delegate GetGetAnimationResourceIdHandler ()
		{
			if (cb_getAnimationResourceId == null)
				cb_getAnimationResourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnimationResourceId);
			return cb_getAnimationResourceId;
		}

		static int n_GetAnimationResourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.ResourceAnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.ResourceAnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationResourceId;
		}
#pragma warning restore 0169

		protected abstract int AnimationResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='ResourceAnimationAdapter']/method[@name='getAnimationResourceId' and count(parameter)=0]"
			[Register ("getAnimationResourceId", "()I", "GetGetAnimationResourceIdHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/ResourceAnimationAdapter", DoNotGenerateAcw=true)]
	internal partial class ResourceAnimationAdapterInvoker : ResourceAnimationAdapter {

		public ResourceAnimationAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceAnimationAdapterInvoker); }
		}

		static IntPtr id_getAnimationResourceId;
		protected override int AnimationResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='ResourceAnimationAdapter']/method[@name='getAnimationResourceId' and count(parameter)=0]"
			[Register ("getAnimationResourceId", "()I", "GetGetAnimationResourceIdHandler")]
			get {
				if (id_getAnimationResourceId == IntPtr.Zero)
					id_getAnimationResourceId = JNIEnv.GetMethodID (class_ref, "getAnimationResourceId", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getAnimationResourceId);
			}
		}

	}

}
