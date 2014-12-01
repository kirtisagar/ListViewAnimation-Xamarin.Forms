using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateDismissAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/AnimateDismissAdapter", DoNotGenerateAcw=true)]
	public partial class AnimateDismissAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/AnimateDismissAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimateDismissAdapter); }
		}

		protected AnimateDismissAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateDismissAdapter']/constructor[@name='AnimateDismissAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.BaseAdapter'] and parameter[2][@type='com.nhaarman.listviewanimations.itemmanipulation.OnDismissCallback']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", "")]
		public AnimateDismissAdapter (global::Android.Widget.BaseAdapter p0, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.IOnDismissCallback p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnimateDismissAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_ == IntPtr.Zero)
				id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/widget/BaseAdapter;Lcom/nhaarman/listviewanimations/itemmanipulation/OnDismissCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_widget_BaseAdapter_Lcom_nhaarman_listviewanimations_itemmanipulation_OnDismissCallback_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_animateDismiss_I;
#pragma warning disable 0169
		static Delegate GetAnimateDismiss_IHandler ()
		{
			if (cb_animateDismiss_I == null)
				cb_animateDismiss_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AnimateDismiss_I);
			return cb_animateDismiss_I;
		}

		static void n_AnimateDismiss_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_animateDismiss_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateDismissAdapter']/method[@name='animateDismiss' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animateDismiss", "(I)V", "GetAnimateDismiss_IHandler")]
		public virtual void AnimateDismiss (int p0)
		{
			if (id_animateDismiss_I == IntPtr.Zero)
				id_animateDismiss_I = JNIEnv.GetMethodID (class_ref, "animateDismiss", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateDismiss_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateDismiss", "(I)V"), new JValue (p0));
		}

		static Delegate cb_animateDismiss_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAnimateDismiss_Ljava_util_Collection_Handler ()
		{
			if (cb_animateDismiss_Ljava_util_Collection_ == null)
				cb_animateDismiss_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateDismiss_Ljava_util_Collection_);
			return cb_animateDismiss_Ljava_util_Collection_;
		}

		static void n_AnimateDismiss_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateDismissAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.AnimateDismissAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.ICollection<Java.Lang.Integer> p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateDismiss (p0);
		}
#pragma warning restore 0169

		static IntPtr id_animateDismiss_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation']/class[@name='AnimateDismissAdapter']/method[@name='animateDismiss' and count(parameter)=1 and parameter[1][@type='java.util.Collection']]"
		[Register ("animateDismiss", "(Ljava/util/Collection;)V", "GetAnimateDismiss_Ljava_util_Collection_Handler")]
		public virtual void AnimateDismiss (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0)
		{
			if (id_animateDismiss_Ljava_util_Collection_ == IntPtr.Zero)
				id_animateDismiss_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "animateDismiss", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateDismiss_Ljava_util_Collection_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateDismiss", "(Ljava/util/Collection;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
