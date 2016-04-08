
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using Storm.Mvvm.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Storm.Mvvm.Services;
using ModelViewTodo.Model;

namespace ModelViewTodo.ModelView
{
    public class AddModelView : ViewModelBase
    {

        private string _title;
        private string _descritpion;

        [NavigationParameter]
        public ObservableCollection<Todo> List { get; set; }

        public ICommand ButtonSave { get; private set; }

        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public string Description
        {
            get { return _descritpion; }
            private set { _descritpion = value; }
        }

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
        }

        public AddModelView()
        {
            ButtonSave = new DelegateCommand(ButtonClicked);
        }


        private void ButtonClicked()
        {
            List.Add(new Todo(Title, Description));
            NavigationService.GoBack();
        }
    }
}
