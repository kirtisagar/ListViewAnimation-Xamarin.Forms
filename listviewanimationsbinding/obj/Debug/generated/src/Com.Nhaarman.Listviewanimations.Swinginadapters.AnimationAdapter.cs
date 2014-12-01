using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Swinginadapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/AnimationAdapter", DoNotGenerateAcw=true)]
	public abstract partial class AnimationAdapter : global::Com.Nhaarman.Listviewanimations.BaseAdapterDecorator {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/field[@name='DEFAULTANIMATIONDELAYMILLIS']"
		[Register ("DEFAULTANIMATIONDELAYMILLIS")]
		protected const long Defaultanimationdelaymillis = (long) 100L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/field[@name='DEFAULTANIMATIONDURATIONMILLIS']"
		[Register ("DEFAULTANIMATIONDURATIONMILLIS")]
		protected const long Defaultanimationdurationmillis = (long) 300L;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/swinginadapters/AnimationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimationAdapter); }
		}

		protected AnimationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_widget_BaseAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/constructor[@name='AnimationAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.BaseAdapter']]"
		[Register (".ctor", "(Landroid/widget/BaseAdapter;)V", "")]
		public AnimationAdapter (global::Android.Widget.BaseAdapter p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AnimationAdapter)) {
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

		static Delegate cb_getAnimationDelayMillis;
#pragma warning disable 0169
		static Delegate GetGetAnimationDelayMillisHandler ()
		{
			if (cb_getAnimationDelayMillis == null)
				cb_getAnimationDelayMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAnimationDelayMillis);
			return cb_getAnimationDelayMillis;
		}

		static long n_GetAnimationDelayMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationDelayMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimationDelayMillis;
		protected virtual long AnimationDelayMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='getAnimationDelayMillis' and count(parameter)=0]"
			[Register ("getAnimationDelayMillis", "()J", "GetGetAnimationDelayMillisHandler")]
			get {
				if (id_getAnimationDelayMillis == IntPtr.Zero)
					id_getAnimationDelayMillis = JNIEnv.GetMethodID (class_ref, "getAnimationDelayMillis", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAnimationDelayMillis);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimationDelayMillis", "()J"));
			}
		}

		static Delegate cb_getAnimationDurationMillis;
#pragma warning disable 0169
		static Delegate GetGetAnimationDurationMillisHandler ()
		{
			if (cb_getAnimationDurationMillis == null)
				cb_getAnimationDurationMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAnimationDurationMillis);
			return cb_getAnimationDurationMillis;
		}

		static long n_GetAnimationDurationMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationDurationMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimationDurationMillis;
		protected virtual long AnimationDurationMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='getAnimationDurationMillis' and count(parameter)=0]"
			[Register ("getAnimationDurationMillis", "()J", "GetGetAnimationDurationMillisHandler")]
			get {
				if (id_getAnimationDurationMillis == IntPtr.Zero)
					id_getAnimationDurationMillis = JNIEnv.GetMethodID (class_ref, "getAnimationDurationMillis", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getAnimationDurationMillis);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimationDurationMillis", "()J"));
			}
		}

		static Delegate cb_getInitialDelayMillis;
#pragma warning disable 0169
		static Delegate GetGetInitialDelayMillisHandler ()
		{
			if (cb_getInitialDelayMillis == null)
				cb_getInitialDelayMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInitialDelayMillis);
			return cb_getInitialDelayMillis;
		}

		static long n_GetInitialDelayMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitialDelayMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getInitialDelayMillis;
		protected virtual long InitialDelayMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='getInitialDelayMillis' and count(parameter)=0]"
			[Register ("getInitialDelayMillis", "()J", "GetGetInitialDelayMillisHandler")]
			get {
				if (id_getInitialDelayMillis == IntPtr.Zero)
					id_getInitialDelayMillis = JNIEnv.GetMethodID (class_ref, "getInitialDelayMillis", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getInitialDelayMillis);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialDelayMillis", "()J"));
			}
		}

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "")]
		public override sealed global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_reset);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
		}

		static Delegate cb_setAnimationDelayMillis_J;
#pragma warning disable 0169
		static Delegate GetSetAnimationDelayMillis_JHandler ()
		{
			if (cb_setAnimationDelayMillis_J == null)
				cb_setAnimationDelayMillis_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAnimationDelayMillis_J);
			return cb_setAnimationDelayMillis_J;
		}

		static void n_SetAnimationDelayMillis_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDelayMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDelayMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setAnimationDelayMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAnimationDelayMillis", "(J)V", "GetSetAnimationDelayMillis_JHandler")]
		public virtual void SetAnimationDelayMillis (long p0)
		{
			if (id_setAnimationDelayMillis_J == IntPtr.Zero)
				id_setAnimationDelayMillis_J = JNIEnv.GetMethodID (class_ref, "setAnimationDelayMillis", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAnimationDelayMillis_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDelayMillis", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setAnimationDurationMillis_J;
#pragma warning disable 0169
		static Delegate GetSetAnimationDurationMillis_JHandler ()
		{
			if (cb_setAnimationDurationMillis_J == null)
				cb_setAnimationDurationMillis_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAnimationDurationMillis_J);
			return cb_setAnimationDurationMillis_J;
		}

		static void n_SetAnimationDurationMillis_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationDurationMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAnimationDurationMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setAnimationDurationMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setAnimationDurationMillis", "(J)V", "GetSetAnimationDurationMillis_JHandler")]
		public virtual void SetAnimationDurationMillis (long p0)
		{
			if (id_setAnimationDurationMillis_J == IntPtr.Zero)
				id_setAnimationDurationMillis_J = JNIEnv.GetMethodID (class_ref, "setAnimationDurationMillis", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAnimationDurationMillis_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationDurationMillis", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setHasParentAnimationAdapter_Z;
#pragma warning disable 0169
		static Delegate GetSetHasParentAnimationAdapter_ZHandler ()
		{
			if (cb_setHasParentAnimationAdapter_Z == null)
				cb_setHasParentAnimationAdapter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHasParentAnimationAdapter_Z);
			return cb_setHasParentAnimationAdapter_Z;
		}

		static void n_SetHasParentAnimationAdapter_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHasParentAnimationAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHasParentAnimationAdapter_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setHasParentAnimationAdapter' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHasParentAnimationAdapter", "(Z)V", "GetSetHasParentAnimationAdapter_ZHandler")]
		public virtual void SetHasParentAnimationAdapter (bool p0)
		{
			if (id_setHasParentAnimationAdapter_Z == IntPtr.Zero)
				id_setHasParentAnimationAdapter_Z = JNIEnv.GetMethodID (class_ref, "setHasParentAnimationAdapter", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setHasParentAnimationAdapter_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHasParentAnimationAdapter", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setInitialDelayMillis_J;
#pragma warning disable 0169
		static Delegate GetSetInitialDelayMillis_JHandler ()
		{
			if (cb_setInitialDelayMillis_J == null)
				cb_setInitialDelayMillis_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetInitialDelayMillis_J);
			return cb_setInitialDelayMillis_J;
		}

		static void n_SetInitialDelayMillis_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialDelayMillis (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialDelayMillis_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setInitialDelayMillis' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInitialDelayMillis", "(J)V", "GetSetInitialDelayMillis_JHandler")]
		public virtual void SetInitialDelayMillis (long p0)
		{
			if (id_setInitialDelayMillis_J == IntPtr.Zero)
				id_setInitialDelayMillis_J = JNIEnv.GetMethodID (class_ref, "setInitialDelayMillis", "(J)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInitialDelayMillis_J, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialDelayMillis", "(J)V"), new JValue (p0));
		}

		static Delegate cb_setShouldAnimate_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimate_ZHandler ()
		{
			if (cb_setShouldAnimate_Z == null)
				cb_setShouldAnimate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldAnimate_Z);
			return cb_setShouldAnimate_Z;
		}

		static void n_SetShouldAnimate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setShouldAnimate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldAnimate", "(Z)V", "GetSetShouldAnimate_ZHandler")]
		public virtual void SetShouldAnimate (bool p0)
		{
			if (id_setShouldAnimate_Z == IntPtr.Zero)
				id_setShouldAnimate_Z = JNIEnv.GetMethodID (class_ref, "setShouldAnimate", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimate_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimate", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setShouldAnimateFromPosition_I;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateFromPosition_IHandler ()
		{
			if (cb_setShouldAnimateFromPosition_I == null)
				cb_setShouldAnimateFromPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShouldAnimateFromPosition_I);
			return cb_setShouldAnimateFromPosition_I;
		}

		static void n_SetShouldAnimateFromPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateFromPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateFromPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setShouldAnimateFromPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShouldAnimateFromPosition", "(I)V", "GetSetShouldAnimateFromPosition_IHandler")]
		public virtual void SetShouldAnimateFromPosition (int p0)
		{
			if (id_setShouldAnimateFromPosition_I == IntPtr.Zero)
				id_setShouldAnimateFromPosition_I = JNIEnv.GetMethodID (class_ref, "setShouldAnimateFromPosition", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateFromPosition_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateFromPosition", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setShouldAnimateNotVisible;
#pragma warning disable 0169
		static Delegate GetSetShouldAnimateNotVisibleHandler ()
		{
			if (cb_setShouldAnimateNotVisible == null)
				cb_setShouldAnimateNotVisible = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetShouldAnimateNotVisible);
			return cb_setShouldAnimateNotVisible;
		}

		static void n_SetShouldAnimateNotVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Swinginadapters.AnimationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldAnimateNotVisible ();
		}
#pragma warning restore 0169

		static IntPtr id_setShouldAnimateNotVisible;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.swinginadapters']/class[@name='AnimationAdapter']/method[@name='setShouldAnimateNotVisible' and count(parameter)=0]"
		[Register ("setShouldAnimateNotVisible", "()V", "GetSetShouldAnimateNotVisibleHandler")]
		public virtual void SetShouldAnimateNotVisible ()
		{
			if (id_setShouldAnimateNotVisible == IntPtr.Zero)
				id_setShouldAnimateNotVisible = JNIEnv.GetMethodID (class_ref, "setShouldAnimateNotVisible", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShouldAnimateNotVisible);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldAnimateNotVisible", "()V"));
		}

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/swinginadapters/AnimationAdapter", DoNotGenerateAcw=true)]
	internal partial class AnimationAdapterInvoker : AnimationAdapter {

		public AnimationAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimationAdapterInvoker); }
		}

	}

}
