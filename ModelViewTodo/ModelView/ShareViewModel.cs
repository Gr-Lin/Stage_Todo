using System.Text.RegularExpressions;
using System.Windows.Input;
using ModelViewTodo.Interfaces;
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Navigation;
using Storm.Mvvm.Services;

namespace ModelViewTodo.ModelView
{
    public class ShareViewModel : ViewModelBase
    {
        private readonly Regex _regex = new Regex("^((\\+33)|0)[1-9](.?[0-9]{2}){4}$");
        private string _phone;
        private string _message = "I'm sharing this Todo : ";
        private string _adresse;

        public ICommand SendSms { get; set; }
        public ICommand SendMail { get; set; }

        public string PhoneNumber
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        public string MessageTodo
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public string EmailAdress
        {
            get {return _adresse;}
            set { SetProperty(ref _adresse, value); }
        }

        [NavigationParameter]
        public int Index { get; set; }

        public ICollectionTodoService CollectionService => LazyResolver<ICollectionTodoService>.Service;
        public IToastService ToastService => LazyResolver<IToastService>.Service;
        public IShareService ShareService => LazyResolver<IShareService>.Service;

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            var todo = CollectionService.GetTodoById(Index);
            MessageTodo += todo.ToString();
        }

        public ShareViewModel()
        {
            SendSms = new DelegateCommand(ButtonSmsClicked);
            SendMail = new DelegateCommand(ButtonMailClicked);
        }

        private void ButtonSmsClicked()
        {
            if (CheckNumber())
            {
                ShareService.SendSms(PhoneNumber, MessageTodo);
                NavigationService.GoBack();
            }
            else
                ToastService.DisplayToast("The phone number is not valid");
        }

        private void ButtonMailClicked()
        {
            ShareService.SendMail(new string[] { EmailAdress }, "Sharing todo", MessageTodo);
            NavigationService.GoBack();
        }

        public bool CheckNumber()
        {
           return _regex.IsMatch(PhoneNumber); 
        }
    }
    

}