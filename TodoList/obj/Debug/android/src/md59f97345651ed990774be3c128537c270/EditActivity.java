package md59f97345651ed990774be3c128537c270;


public class EditActivity
	extends md5f30f4d946912a4f29e1131fe923d1dd9.ActivityBase
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("TodoList.Activities.EditActivity, TodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EditActivity.class, __md_methods);
	}


	public EditActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EditActivity.class)
			mono.android.TypeManager.Activate ("TodoList.Activities.EditActivity, TodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
