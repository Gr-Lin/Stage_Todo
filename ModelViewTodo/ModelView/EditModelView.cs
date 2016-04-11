
using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using Storm.Mvvm.Navigation;
using Storm.Mvvm.Services;
using ModelViewTodo.Model;
using System.Collections.ObjectModel;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.ModelView
{
    public class EditModelView : ViewModelBase
    {
        private string _title;
        private string _desc;
        private int _index;

        public ICommand ButtonBack { get; set; }
        public ICommand ButtonSaveEdit { get; set; }
        public ICommand ButtonDelete { get; set; }

        [NavigationParameter]
        public int Index { get; set; }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Description
        {
            get { return _desc; }
            set { SetProperty(ref _desc, value); }
        }

        public ObservableCollection<Todo> CollectionTodo
        {
            get { return LazyResolver<ICollectionTodoService>.Service.GetCollection(); }
        }

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            _index = Index;
            Title = CollectionTodo[_index].Name;
            Description = CollectionTodo[_index].Description;
        }

        public EditModelView()
        {
            ButtonBack = new DelegateCommand(ButtonBackClicked);
            ButtonSaveEdit = new DelegateCommand(ButtonSaveEditClicked);
            ButtonDelete = new DelegateCommand(ButtonDeleteClicked);
        }

        public void ButtonSaveEditClicked()
        {
            LazyResolver<ICollectionTodoService>.Service.EditCollec(Title, Description, Index);
            NavigationService.GoBack();
        }

        private void ButtonBackClicked()
        {
            NavigationService.GoBack();
        }

        private void ButtonDeleteClicked()
        {
            LazyResolver<ICollectionTodoService>.Service.SuppCollec(Index);
            NavigationService.GoBack();
        }
    }
}
