using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;


namespace TodoList.Activities
{
    [Activity(Label = "Sign up", MainLauncher = false, Icon = "@drawable/icon")]
    public partial class SignActivity : ActivityBase
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Sign);

            SetViewModel(new SignViewModel());
        }
    }
}
