package mono.org.achartengine.tools;


public class ZoomListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.achartengine.tools.ZoomListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_zoomApplied:(Lorg/achartengine/tools/ZoomEvent;)V:GetZoomApplied_Lorg_achartengine_tools_ZoomEvent_Handler:Org.Achartengine.Tools.IZoomListenerInvoker, AChartEngineBinding\n" +
			"n_zoomReset:()V:GetZoomResetHandler:Org.Achartengine.Tools.IZoomListenerInvoker, AChartEngineBinding\n" +
			"";
		mono.android.Runtime.register ("Org.Achartengine.Tools.IZoomListenerImplementor, AChartEngineBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ZoomListenerImplementor.class, __md_methods);
	}


	public ZoomListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ZoomListenerImplementor.class)
			mono.android.TypeManager.Activate ("Org.Achartengine.Tools.IZoomListenerImplementor, AChartEngineBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void zoomApplied (org.achartengine.tools.ZoomEvent p0)
	{
		n_zoomApplied (p0);
	}

	private native void n_zoomApplied (org.achartengine.tools.ZoomEvent p0);


	public void zoomReset ()
	{
		n_zoomReset ();
	}

	private native void n_zoomReset ();

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
