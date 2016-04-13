
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using Storm.Mvvm.Navigation;
using Storm.Mvvm.Services;
using ModelViewTodo.Model;
using System.Collections.ObjectModel;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;
using System.Collections.Generic;
using System;

namespace ModelViewTodo.ModelView
{
    public class EditModelView : ViewModelBase
    {
        private string _title;
        private string _desc;
        private int _index;

        public ICommand ButtonBack { get; set; }
        public ICommand ButtonSaveEdit { get; set; }
        public ICommand ButtonDelete { get; set; }

        [NavigationParameter]
        public int Index { get; set; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Description
        {
            get { return _desc; }
            set { SetProperty(ref _desc, value); }
        }

        public ObservableCollection<Todo> CollectionTodo => LazyResolver<ICollectionTodoService>.Service.GetCollection();

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            _index = Index;
            Title = CollectionTodo[_index].Name;
            Description = CollectionTodo[_index].Description;
        }

        public EditModelView()
        {
            ButtonBack = new DelegateCommand(ButtonBackClicked);
            ButtonSaveEdit = new DelegateCommand(ButtonSaveEditAsyncClicked);
            ButtonDelete = new DelegateCommand(ButtonDeleteClicked);
        }

        public async void ButtonSaveEditAsyncClicked()
        {
            if (Title != "" && Description != "")
            {
                HttpResult res = await LazyResolver<IHttpService>.Service.EditTodoAsync(CollectionTodo[_index]);
                if (res.Ok)
                {
                    LazyResolver<ICollectionTodoService>.Service.EditCollec(Title, Description, Index);
                    NavigationService.GoBack();
                }
            }
        }

        private void ButtonBackClicked()
        {
            NavigationService.GoBack();
        }

        protected IMessageDialogService MessageDialogService => LazyResolver<IMessageDialogService>.Service;

        private void ButtonDeleteClicked()
        {
            MessageDialogService.Show("Delete", new Dictionary<string, object>
                {
                    {"Index", Index}
                });
        }
    }
}
