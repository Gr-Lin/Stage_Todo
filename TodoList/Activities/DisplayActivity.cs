using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;

namespace TodoList.Activities
{
    [Activity(Label = "Disp", MainLauncher = false, Icon = "@drawable/icon")]
    public partial class DisplayActivity : ActivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Disp);

            SetViewModel(new DisplayModelView());

        }
    }
}
