using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;


namespace TodoList.Activities
{
    [Activity(Label = "TodoList", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class HomeActivity : ActivityBase
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Home);

            SetViewModel(new HomeModelView());
        }
    }
}
