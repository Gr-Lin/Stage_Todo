package md5ab04217234427ddcb4974f765500d258;


public abstract class AbstractDialogFragmentBase
	extends android.support.v4.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onResume:()V:GetOnResumeHandler\n" +
			"n_onPause:()V:GetOnPauseHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"n_onCancel:(Landroid/content/DialogInterface;)V:GetOnCancel_Landroid_content_DialogInterface_Handler\n" +
			"n_onDismiss:(Landroid/content/DialogInterface;)V:GetOnDismiss_Landroid_content_DialogInterface_Handler\n" +
			"";
		mono.android.Runtime.register ("Storm.Mvvm.Dialogs.AbstractDialogFragmentBase, Storm.Mvvm.Android.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AbstractDialogFragmentBase.class, __md_methods);
	}


	public AbstractDialogFragmentBase () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AbstractDialogFragmentBase.class)
			mono.android.TypeManager.Activate ("Storm.Mvvm.Dialogs.AbstractDialogFragmentBase, Storm.Mvvm.Android.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();


	public void onPause ()
	{
		n_onPause ();
	}

	private native void n_onPause ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();


	public void onCancel (android.content.DialogInterface p0)
	{
		n_onCancel (p0);
	}

	private native void n_onCancel (android.content.DialogInterface p0);


	public void onDismiss (android.content.DialogInterface p0)
	{
		n_onDismiss (p0);
	}

	private native void n_onDismiss (android.content.DialogInterface p0);

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
