
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using Storm.Mvvm.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Storm.Mvvm.Services;
using ModelViewTodo.Model;
using Storm.Mvvm.Inject;
using ModelViewTodo.Interfaces;

namespace ModelViewTodo.ModelView
{
    public class AddModelView : ViewModelBase
    {
        private string _title;
        private string _descritpion;

        public ICommand ButtonSave { get; set; }

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
            ButtonSave = new DelegateCommand(ButtonClicked);
        }


        private void ButtonClicked()
        {
            LazyResolver<ICollectionTodoService>.Service.AddCollec(Title, Description);
            NavigationService.GoBack();
        }
    }
}
