package mono.com.nhaarman.listviewanimations.widget;


public class DynamicListView_OnItemMovedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nhaarman.listviewanimations.widget.DynamicListView.OnItemMovedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemMoved:(I)V:GetOnItemMoved_IHandler:Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnItemMovedListenerInvoker, ListViewAnimations\n" +
			"";
		mono.android.Runtime.register ("Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnItemMovedListenerImplementor, ListViewAnimations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DynamicListView_OnItemMovedListenerImplementor.class, __md_methods);
	}


	public DynamicListView_OnItemMovedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DynamicListView_OnItemMovedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnItemMovedListenerImplementor, ListViewAnimations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onItemMoved (int p0)
	{
		n_onItemMoved (p0);
	}

	private native void n_onItemMoved (int p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
