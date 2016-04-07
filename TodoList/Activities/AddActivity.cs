using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;

namespace TodoList.Activities
{
    [Activity(Label = "Add", MainLauncher = false, Icon = "@drawable/icon")]
    public partial class AddActivity : ActivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Add);

            SetViewModel(new AddModelView());

        }
    }
}
 