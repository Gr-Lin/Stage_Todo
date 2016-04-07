package md5f30f4d946912a4f29e1131fe923d1dd9;


public class ApplicationBase
	extends mono.android.app.Application
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
	}


	public ApplicationBase () throws java.lang.Throwable
	{
		super ();
	}

	public void onCreate ()
	{
		mono.android.Runtime.register ("Storm.Mvvm.ApplicationBase, Storm.Mvvm.Android.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ApplicationBase.class, __md_methods);
		super.onCreate ();
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
