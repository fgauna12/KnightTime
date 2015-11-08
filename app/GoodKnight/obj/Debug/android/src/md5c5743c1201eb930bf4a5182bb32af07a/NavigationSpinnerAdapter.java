package md5c5743c1201eb930bf4a5182bb32af07a;


public class NavigationSpinnerAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"";
		mono.android.Runtime.register ("KnightTime.Android.View.NavigationSpinnerAdapter, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NavigationSpinnerAdapter.class, __md_methods);
	}


	public NavigationSpinnerAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NavigationSpinnerAdapter.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.NavigationSpinnerAdapter, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public NavigationSpinnerAdapter (android.content.Context p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == NavigationSpinnerAdapter.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.NavigationSpinnerAdapter, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();

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
