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

namespace ModelViewTodo.ModelView
{
    public class EditModelView : ViewModelBase
    {
        private string _title;
        private string _desc;
        
        public ICommand ButtonSaveEdit { get; set; }
        public ICommand ButtonDelete { get; set; }
        public ICommand ButtonShare { get; set; }

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

        public ObservableCollection<Todo> CollectionTodo => CollectionService.GetCollection();
        public IToastService ToastService => LazyResolver<IToastService>.Service;
        public ICollectionTodoService CollectionService => LazyResolver<ICollectionTodoService>.Service;

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            var todo = CollectionService.GetTodoById(Index);
            Title = todo.Name;
            Description = todo.Description;
        }

        public EditModelView()
        {
            ButtonSaveEdit = new DelegateCommand(ButtonSaveEditAsyncClicked);
            ButtonDelete = new DelegateCommand(ButtonDeleteClicked);
            ButtonShare = new DelegateCommand(ButtonShareClicked);
        }

        public async void ButtonSaveEditAsyncClicked()
        {
            if (Title != "" && Description != "")
            {
                HttpResultTodo res = await LazyResolver<IHttpService>.Service.EditTodoAsync(Index, Title, Description);
                if (res.Ok)
                {
                   ToastService.DisplayToast("Saving Change");
                    LazyResolver<ICollectionTodoService>.Service.EditCollec(res.Resource.Name, res.Resource.Description,
                        Index);
                    NavigationService.GoBack();
                }
                else
                    ToastService.DisplayToast(res.Message);
            } else 
                ToastService.DisplayToast("Todo's field can't be blank");
        }

        protected IMessageDialogService MessageDialogService => LazyResolver<IMessageDialogService>.Service;

        private void ButtonDeleteClicked()
        {
            MessageDialogService.Show("Delete", new Dictionary<string, object>
                {
                    {"Index", Index}
                });
        }

        public void ButtonShareClicked()
        {
            NavigationService.Navigate("Share", new Dictionary<string, object>
            {
                {"Index", Index }
            });
        }
    }
}
