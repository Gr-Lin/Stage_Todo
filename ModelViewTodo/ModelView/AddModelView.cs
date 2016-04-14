using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using Storm.Mvvm.Inject;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;

namespace ModelViewTodo.ModelView
{
    public class AddModelView : ViewModelBase
    {
        private string _title;
        private string _descritpion;

        public ICommand ButtonSave { get; set; }
        public IToastService ToastService => LazyResolver<IToastService>.Service;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title,  value); }
        }

        public string Description
        {
            get { return _descritpion; }
            set { SetProperty(ref _descritpion, value); }
        }

        public AddModelView()
        {
            ButtonSave = new DelegateCommand(ButtonSaveAsyncClicked);
        }


        private async void ButtonSaveAsyncClicked()
        {
            if (Title != "" && Description != "")
            {
                HttpResult res = await LazyResolver<IHttpService>.Service.AddTodoAsync(new Todo(Title, Description));
                if (res.Ok)
                {
                   ToastService.DisplayToast("Adding Todo");
                   LazyResolver<ICollectionTodoService>.Service.AddCollec(Title, Description);
                   NavigationService.GoBack();
                } else 
                    ToastService.DisplayToast(res.Message);
            } else 
                ToastService.DisplayToast("Todo's field can't be Blank");
        }
    }
}
