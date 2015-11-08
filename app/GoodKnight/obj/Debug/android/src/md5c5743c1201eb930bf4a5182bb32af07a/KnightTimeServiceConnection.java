package md5c5743c1201eb930bf4a5182bb32af07a;


public class KnightTimeServiceConnection
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.ServiceConnection
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onServiceConnected:(Landroid/content/ComponentName;Landroid/os/IBinder;)V:GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler:Android.Content.IServiceConnectionInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onServiceDisconnected:(Landroid/content/ComponentName;)V:GetOnServiceDisconnected_Landroid_content_ComponentName_Handler:Android.Content.IServiceConnectionInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("KnightTime.Android.View.KnightTimeServiceConnection, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", KnightTimeServiceConnection.class, __md_methods);
	}


	public KnightTimeServiceConnection () throws java.lang.Throwable
	{
		super ();
		if (getClass () == KnightTimeServiceConnection.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.KnightTimeServiceConnection, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public KnightTimeServiceConnection (md5c5743c1201eb930bf4a5182bb32af07a.MonitorActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == KnightTimeServiceConnection.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.KnightTimeServiceConnection, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "KnightTime.Android.View.MonitorActivity, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onServiceConnected (android.content.ComponentName p0, android.os.IBinder p1)
	{
		n_onServiceConnected (p0, p1);
	}

	private native void n_onServiceConnected (android.content.ComponentName p0, android.os.IBinder p1);


	public void onServiceDisconnected (android.content.ComponentName p0)
	{
		n_onServiceDisconnected (p0);
	}

	private native void n_onServiceDisconnected (android.content.ComponentName p0);

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
