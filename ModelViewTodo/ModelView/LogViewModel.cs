using System.Threading.Tasks;
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.ModelView
{
    public class LogViewModel : ViewModelBase
    {
        private string _id;
        private string _pwd;
        private string _error;
        private bool _isChecked;
        private bool _isHashed;

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
            set
            {
                SetProperty(ref _pwd, value);
                _isHashed = false;
            }
        }

        public string Error
        {
            get { return _error; }
            set { SetProperty(ref _error, value); }
        }

        public bool RememberChecked
        {
            get { return _isChecked; }
            set { SetProperty(ref _isChecked, value); }
        }

        public IHttpService HttpService => LazyResolver<IHttpService>.Service;
        public IUserService UserService => LazyResolver<IUserService>.Service;

        public LogViewModel()
        {
            ButtonLogin = new DelegateCommand(ButtonLogClickedAsync);
            ButtonSignUp = new DelegateCommand(ButtonSignClickedAsync);

            InitUserAsync();
        }

        private async void InitUserAsync()
        {
            Task<User> task = UserService.GetUserInfoAsync();
            User user = await task;
            RememberChecked = user.Remember;
            if (RememberChecked)
            {
                Id = user.Login;
                Pass = user.Password;
                _isHashed = true;
            }
        }

        private void RememberUser()
        {
           User u = !_isHashed ? new User(Id, HttpService.HashPassword(Pass), RememberChecked) : new User(Id, Pass, RememberChecked);
           UserService.SaveUserAsync(u);
        }


        private async void ButtonLogClickedAsync()
        {
            HttpResult isCo = await HttpService.ConnexionAsync(Id, Pass, _isHashed);
            if (isCo.Ok)
            {
                RememberUser();
                NavigationService.Navigate("Home");
            }
            else
                Error = isCo.Message;
        }

        private async void ButtonSignClickedAsync()
        {
            HttpResult isCo = await HttpService.RegisterAsync(Id, Pass);
            if (isCo.Ok)
            {
                RememberUser();
                NavigationService.Navigate("Home");
            }
            else
                Error = isCo.Message;
        }
    }
}
