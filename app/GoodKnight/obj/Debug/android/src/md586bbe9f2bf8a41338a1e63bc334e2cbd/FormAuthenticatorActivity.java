package md586bbe9f2bf8a41338a1e63bc334e2cbd;


public class FormAuthenticatorActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onRetainNonConfigurationInstance:()Ljava/lang/Object;:GetOnRetainNonConfigurationInstanceHandler\n" +
			"n_onSaveInstanceState:(Landroid/os/Bundle;)V:GetOnSaveInstanceState_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Auth.FormAuthenticatorActivity, Xamarin.Auth.Android, Version=1.0.4771.25144, Culture=neutral, PublicKeyToken=null", FormAuthenticatorActivity.class, __md_methods);
	}


	public FormAuthenticatorActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FormAuthenticatorActivity.class)
			mono.android.TypeManager.Activate ("Xamarin.Auth.FormAuthenticatorActivity, Xamarin.Auth.Android, Version=1.0.4771.25144, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public java.lang.Object onRetainNonConfigurationInstance ()
	{
		return n_onRetainNonConfigurationInstance ();
	}

	private native java.lang.Object n_onRetainNonConfigurationInstance ();


	public void onSaveInstanceState (android.os.Bundle p0)
	{
		n_onSaveInstanceState (p0);
	}

	private native void n_onSaveInstanceState (android.os.Bundle p0);

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