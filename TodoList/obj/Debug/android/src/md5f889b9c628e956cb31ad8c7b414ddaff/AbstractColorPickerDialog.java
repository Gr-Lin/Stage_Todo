package md5f889b9c628e956cb31ad8c7b414ddaff;


public abstract class AbstractColorPickerDialog
	extends md5ab04217234427ddcb4974f765500d258.AlertDialogFragmentBase
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Storm.Mvvm.Framework.ColorPicker.AbstractColorPickerDialog, Storm.Mvvm.Android.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AbstractColorPickerDialog.class, __md_methods);
	}


	public AbstractColorPickerDialog () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AbstractColorPickerDialog.class)
			mono.android.TypeManager.Activate ("Storm.Mvvm.Framework.ColorPicker.AbstractColorPickerDialog, Storm.Mvvm.Android.Support, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
