package md5c5743c1201eb930bf4a5182bb32af07a;


public class MonitorBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("KnightTime.Android.View.MonitorBinder, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MonitorBinder.class, __md_methods);
	}


	public MonitorBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MonitorBinder.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.MonitorBinder, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MonitorBinder (md5c5743c1201eb930bf4a5182bb32af07a.KtService p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MonitorBinder.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.MonitorBinder, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "KnightTime.Android.View.KtService, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

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
