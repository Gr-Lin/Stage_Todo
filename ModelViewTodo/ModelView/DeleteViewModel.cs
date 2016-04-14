using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Navigation;
using Storm.Mvvm.Services;
using System.Collections.ObjectModel;
using ModelViewTodo.Model;

namespace ModelViewTodo.ModelView
{
    public class DeleteViewModel : ViewModelBase
    {
        public ICommand DeleteCommand { get; private set; }

        [NavigationParameter]
        public int Index { get; set; }

        public DeleteViewModel()
        {
            DeleteCommand = new DelegateCommand(DeleteTodoAsync);
        }

        protected IMessageDialogService MessageDialogService => LazyResolver<IMessageDialogService>.Service;
        public ICollectionTodoService CollectionService => LazyResolver<ICollectionTodoService>.Service;
        public ObservableCollection<Todo> CollectionTodo => LazyResolver<ICollectionTodoService>.Service.GetCollection();
        public IToastService ToastService => LazyResolver<IToastService>.Service;

        protected async void DeleteTodoAsync()
        { 
            HttpResult res = await LazyResolver<IHttpService>.Service.DeleteTodoAsync(CollectionService.GetTodoById(Index));
            if (res.Ok)
            {
                ToastService.DisplayToast("Deleting Todo");
                LazyResolver<ICollectionTodoService>.Service.SuppCollec(Index);
                MessageDialogService.DismissCurrentDialog();
                NavigationService.GoBack();
            }
            else
                ToastService.DisplayToast(res.Message);
        }
    }
}
