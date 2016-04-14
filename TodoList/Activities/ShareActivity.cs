using Android.App;
using Android.OS;
using ModelViewTodo.ModelView;
using Storm.Mvvm;

namespace TodoList.Activities
{
    [Activity(Label = "Share", MainLauncher = false, Icon = "@drawable/icon")]
    public partial class ShareActivity : ActivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Share);

            SetViewModel(new ShareViewModel());

        }
    }
}