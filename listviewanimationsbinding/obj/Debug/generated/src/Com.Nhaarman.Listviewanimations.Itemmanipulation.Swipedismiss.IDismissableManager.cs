using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/interface[@name='DismissableManager']"
	[Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManagerInvoker")]
	public partial interface IDismissableManager : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.swipedismiss']/interface[@name='DismissableManager']/method[@name='isDismissable' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("isDismissable", "(JI)Z", "GetIsDismissable_JIHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManagerInvoker, ListViewAnimations")]
		bool IsDismissable (long p0, int p1);

	}

	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager", DoNotGenerateAcw=true)]
	internal class IDismissableManagerInvoker : global::Java.Lang.Object, IDismissableManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/swipedismiss/DismissableManager");
		IntPtr class_ref;

		public static IDismissableManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDismissableManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.swipedismiss.DismissableManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDismissableManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDismissableManagerInvoker); }
		}

		static Delegate cb_isDismissable_JI;
#pragma warning disable 0169
		static Delegate GetIsDismissable_JIHandler ()
		{
			if (cb_isDismissable_JI == null)
				cb_isDismissable_JI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int, bool>) n_IsDismissable_JI);
			return cb_isDismissable_JI;
		}

		static bool n_IsDismissable_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Swipedismiss.IDismissableManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDismissable (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_isDismissable_JI;
		public bool IsDismissable (long p0, int p1)
		{
			if (id_isDismissable_JI == IntPtr.Zero)
				id_isDismissable_JI = JNIEnv.GetMethodID (class_ref, "isDismissable", "(JI)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_isDismissable_JI, new JValue (p0), new JValue (p1));
		}

	}

}
