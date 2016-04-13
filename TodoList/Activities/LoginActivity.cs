using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;


namespace TodoList.Activities
{
    [Activity(Label = "Todo", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class LoginActivity : ActivityBase
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Log);

            SetViewModel(new LogViewModel());
        }
    }
}
