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
        public ObservableCollection<Todo> CollectionTodo => LazyResolver<ICollectionTodoService>.Service.GetCollection();

        protected async void DeleteTodoAsync()
        { 
            HttpResult res = await LazyResolver<IHttpService>.Service.DeleteTodoAsync(CollectionTodo[Index]);
            if (res.Ok)
            {
                LazyResolver<ICollectionTodoService>.Service.SuppCollec(Index);
                MessageDialogService.DismissCurrentDialog();
                NavigationService.GoBack();
            }
        }
    }
}
