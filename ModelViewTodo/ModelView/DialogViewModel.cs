using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;

namespace ModelViewTodo.ModelView
{
    class DialogViewModel : ViewModelBase
    {
        public ICommand DeleteCommand { get; private set; }

        protected DialogViewModel()
        {
            DeleteCommand = new DelegateCommand(DeleteTodo);
        }

        protected void DeleteTodo()
        {

        }
    }
}
