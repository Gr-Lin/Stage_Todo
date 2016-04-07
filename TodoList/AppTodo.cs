using System;
using Android.App;
using Android.Runtime;
using Storm.Mvvm;
using Storm.Mvvm.Inject;

[Application]
public class AppTodo : ApplicationBase
{
    public AppTodo(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
        AndroidContainer.CreateInstance<AndroidContainer>(this, null);
    }
}