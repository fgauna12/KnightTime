package mono.org.achartengine.tools;


public class PanListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.achartengine.tools.PanListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_panApplied:()V:GetPanAppliedHandler:Org.Achartengine.Tools.IPanListenerInvoker, AChartEngineBinding\n" +
			"";
		mono.android.Runtime.register ("Org.Achartengine.Tools.IPanListenerImplementor, AChartEngineBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PanListenerImplementor.class, __md_methods);
	}


	public PanListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PanListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Achartengine.Tools.IPanListenerImplementor, AChartEngineBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void panApplied ()
	{
		n_panApplied ();
	}

	private native void n_panApplied ();

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
