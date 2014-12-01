package mono.com.nhaarman.listviewanimations.widget;


public class DynamicListView_OnHoverCellListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nhaarman.listviewanimations.widget.DynamicListView.OnHoverCellListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onHoverCellCreated:(Landroid/graphics/drawable/Drawable;)Landroid/graphics/drawable/Drawable;:GetOnHoverCellCreated_Landroid_graphics_drawable_Drawable_Handler:Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnHoverCellListenerInvoker, ListViewAnimations\n" +
			"";
		mono.android.Runtime.register ("Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnHoverCellListenerImplementor, ListViewAnimations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DynamicListView_OnHoverCellListenerImplementor.class, __md_methods);
	}


	public DynamicListView_OnHoverCellListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DynamicListView_OnHoverCellListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nhaarman.Listviewanimations.Widget.DynamicListView/IOnHoverCellListenerImplementor, ListViewAnimations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.graphics.drawable.Drawable onHoverCellCreated (android.graphics.drawable.Drawable p0)
	{
		return n_onHoverCellCreated (p0);
	}

	private native android.graphics.drawable.Drawable n_onHoverCellCreated (android.graphics.drawable.Drawable p0);

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
