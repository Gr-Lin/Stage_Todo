using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;


[Activity(Label = "Home", MainLauncher = true, Icon = "@drawable/icon")]
public partial class DisplayActivity : ActivityBase
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resources.Layout.Home);

        SetViewModel(new DisplayModelView());
    }
}
