package md5c5743c1201eb930bf4a5182bb32af07a;


public class NavigationListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.app.ActionBar.OnNavigationListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onNavigationItemSelected:(IJ)Z:GetOnNavigationItemSelected_IJHandler:Android.App.ActionBar/IOnNavigationListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("KnightTime.Android.View.NavigationListener, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NavigationListener.class, __md_methods);
	}


	public NavigationListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NavigationListener.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.NavigationListener, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public NavigationListener (android.app.FragmentManager p0, int p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == NavigationListener.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.NavigationListener, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.FragmentManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public boolean onNavigationItemSelected (int p0, long p1)
	{
		return n_onNavigationItemSelected (p0, p1);
	}

	private native boolean n_onNavigationItemSelected (int p0, long p1);

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
