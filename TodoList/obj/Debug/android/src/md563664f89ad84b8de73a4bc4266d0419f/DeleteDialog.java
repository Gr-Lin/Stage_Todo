package md563664f89ad84b8de73a4bc4266d0419f;


public class DeleteDialog
	extends md5ab04217234427ddcb4974f765500d258.AlertDialogFragmentBase
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TodoList.Dialogs.DeleteDialog, TodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DeleteDialog.class, __md_methods);
	}


	public DeleteDialog () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DeleteDialog.class)
			mono.android.TypeManager.Activate ("TodoList.Dialogs.DeleteDialog, TodoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
