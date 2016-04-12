using System;
using System.Collections.Generic;
using Android.App;
using Android.Runtime;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Services;
using Storm.Mvvm;
using Storm.Mvvm.Inject;
using TodoList.Activities;
using TodoList.Dialogs;

namespace TodoList
{
    [Application]
    public class AppTodo : ApplicationBase
    {
        public AppTodo(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Dictionary<string, Type> views = new Dictionary<string, Type>
            {
                { "Home", typeof(HomeActivity)},
                { "Sign", typeof(SignActivity)},
                { "Add", typeof(AddActivity)},
                { "Disp", typeof(EditActivity) }
            };


            Dictionary<string, Type> dialogs = new Dictionary<string, Type>
            {
                { "Delete", typeof (DeleteDialog) }
            };


            AndroidContainer.CreateInstance<Container>(this, views, dialogs);
            AndroidContainer.GetInstance().RegisterInstance<ICollectionTodoService>(new CollectionTodoService());
        }
    }
}