using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.ModelView
{
    public class LogViewModel : ViewModelBase
    {
        //TODO verifier que id et pwd ne soit pas nul
        private string _id;
        private string _pwd;

        public ICommand ButtonLogin { get; set; }
        public ICommand ButtonSignUp { get; set; }

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

        public LogViewModel()
        {
            ButtonLogin = new DelegateCommand(ButtonLogClicked);
            ButtonSignUp = new DelegateCommand(ButtonSignClicked);
        }


        private void ButtonLogClicked()
        {
            LazyResolver<IHttpService>.Service.Connexion(Id, Pass);
        }

        private void ButtonSignClicked()
        {
            //demande l'enregistrent
        }
    }
}
