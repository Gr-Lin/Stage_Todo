using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using Android.Widget;
using ModelViewTodo.Model;
using ModelViewTodo.Services;

namespace ModelViewTodo.ModelView
{
    public class LogViewModel : ViewModelBase
    {
        //TODO verifier que id et pwd ne soit pas nul
        private string _id;
        private string _pwd;
        private string _error;

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

        public string Error
        {
            get { return _error; }
            set { SetProperty(ref _error, value); }
        }

        public LogViewModel()
        {
            ButtonLogin = new DelegateCommand(ButtonLogClickedAsync);
            ButtonSignUp = new DelegateCommand(ButtonSignClicked);
        }


        private async void ButtonLogClickedAsync()
        {
            HttpService co = new HttpService();
            HttpResult IsCo = await co.ConnexionAsync(Id, Pass);
            if (IsCo.Ok)
                NavigationService.Navigate("Home");
            else
               Error = IsCo.Message;
        }

        private void ButtonSignClicked()
        {
            //demande l'enregistrent
        }
    }
}
