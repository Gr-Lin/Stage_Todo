using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;

namespace ModelViewTodo.ModelView
{
    public class SignViewModel : ViewModelBase
    {

        //TODO verifier que id et pwd ne soit pas nul

        private string _id;
        private string _pwd;

        public ICommand ButtonSaveNew { get; set; }

        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public string Pass
        {
            get { return _pwd; }
            set { SetProperty(ref _pwd, value); }
        }

        public SignViewModel()
        {
            ButtonSaveNew = new DelegateCommand(ButtonSignClicked);
        }

        private void ButtonSignClicked()
        {
            NavigationService.Navigate("Home");
        }
    }
}
