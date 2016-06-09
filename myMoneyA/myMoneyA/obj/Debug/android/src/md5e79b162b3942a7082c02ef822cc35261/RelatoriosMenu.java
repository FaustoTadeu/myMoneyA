package md5e79b162b3942a7082c02ef822cc35261;


public class RelatoriosMenu
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("myMoneyA.RelatoriosMenu, myMoneyA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RelatoriosMenu.class, __md_methods);
	}


	public RelatoriosMenu () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RelatoriosMenu.class)
			mono.android.TypeManager.Activate ("myMoneyA.RelatoriosMenu, myMoneyA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
