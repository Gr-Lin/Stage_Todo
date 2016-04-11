﻿using System;
using Android.App;
using Android.Runtime;
using Storm.Mvvm;
using Storm.Mvvm.Inject;
using System.Collections.Generic;
using TodoList.Activities;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Services;

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
            { "Add", typeof(AddActivity)},
            { "Disp", typeof(DisplayActivity) }
        };


        AndroidContainer.CreateInstance<AndroidContainer>(this, views);
        AndroidContainer.GetInstance().RegisterInstance<ICollectionTodoService>(new CollectionTodoService());
    }
}