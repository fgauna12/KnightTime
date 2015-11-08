package md57d87049cf3e6ea4c81b5db9f45569a77;


public class MathGame
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("KnightTime.Android.View.SmartAlarms.MathGame, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MathGame.class, __md_methods);
	}


	public MathGame () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MathGame.class)
			mono.android.TypeManager.Activate ("KnightTime.Android.View.SmartAlarms.MathGame, KnightTime.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
