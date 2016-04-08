using System;
using Android.App;
using Android.OS;
using Storm.Mvvm;
using ModelViewTodo.ModelView;
using Android.Widget;


namespace TodoList.Activities
{
    [Activity(Label = "TodoList", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class DisplayActivity : ActivityBase
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Home);

            //_List = FindViewById<ListView> (Resource.Id.listView);

            SetViewModel(new DisplayModelView());
        }
    }
}
