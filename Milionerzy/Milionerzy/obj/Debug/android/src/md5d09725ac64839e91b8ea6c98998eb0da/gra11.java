package md5d09725ac64839e91b8ea6c98998eb0da;


public class gra11
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Milionerzy.gra11, Milionerzy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", gra11.class, __md_methods);
	}


	public gra11 ()
	{
		super ();
		if (getClass () == gra11.class)
			mono.android.TypeManager.Activate ("Milionerzy.gra11, Milionerzy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
