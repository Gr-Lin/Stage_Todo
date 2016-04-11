﻿using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ModelViewTodo.Model;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;
using System.Collections.Generic;
using Storm.Mvvm.Services;

namespace ModelViewTodo.ModelView
{
    public class HomeModelView : ViewModelBase
    {
        public ICommand ButtonAdd { get; private set; }
        public ICommand ButtonEdit { get; private set; }

        private Todo _Selected;

        public Todo SelectedTodo {
            get { return _Selected; } 
            set { SetProperty(ref _Selected, value); } }

        public ObservableCollection<Todo> CollectionTodo
        {
            get { return LazyResolver<ICollectionTodoService>.Service.GetCollection(); }
        }


        public HomeModelView()
        {
            CollectionTodo.Add(new Todo("Premiere Tache", "Ceci est un descriptif de tache", 0));
            CollectionTodo.Add(new Todo("Deuxieme Tache", "J'essais des trucs", 1));
            CollectionTodo.Add(new Todo ("test", "pk ca s'afficheen double wesh je comprends aps", 2));

            ButtonAdd = new DelegateCommand(ButtonAddClicked);
            ButtonEdit = new DelegateCommand(ButtonEditClicked);
        }

        private void ButtonAddClicked()
        {
             NavigationService.Navigate("Add");
        }

        private void ButtonEditClicked ()
        {
            NavigationService.Navigate("Disp", new Dictionary<string, object>()
                                         {
                                             {"Index", CollectionTodo.IndexOf(SelectedTodo)}
                                         });
        }

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            CollectionTodo.Add(new Todo());
            CollectionTodo.RemoveAt(CollectionTodo.Count - 1);
        }

    }


}