using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Navigation;
using Storm.Mvvm.Services;
using System;

namespace ModelViewTodo.ModelView
{
    public class DeleteViewModel : ViewModelBase
    {
        public ICommand DeleteCommand { get; private set; }

        [NavigationParameter]
        public int Index { get; set; }

        public DeleteViewModel()
        {
            DeleteCommand = new DelegateCommand(DeleteTodo);
        }

        protected IMessageDialogService MessageDialogService => LazyResolver<IMessageDialogService>.Service;

        /*[NavigationParameter(Mode = NavigationParameterMode.Optional)]
        public Action DeleteCallback { get; set; }*/

        protected void DeleteTodo()
        {
            LazyResolver<ICollectionTodoService>.Service.SuppCollec(Index);
            MessageDialogService.DismissCurrentDialog();
            NavigationService.GoBack();
        }
    }
}
