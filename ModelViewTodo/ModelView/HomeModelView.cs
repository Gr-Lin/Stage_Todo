using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ModelViewTodo.Model;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;
using System.Collections.Generic;
using Storm.Mvvm.Services;

namespace ModelViewTodo.ModelView
{
    public class HomeModelView : ViewModelBase
    {

        public ICommand ButtonAdd { get; private set; }
        public ICommand ButtonEdit { get; private set; }

        private Todo _selected;

        public Todo SelectedTodo {
            get { return _selected; } 
            set { SetProperty(ref _selected, value); } }

        public ObservableCollection<Todo> CollectionTodo => LazyResolver<ICollectionTodoService>.Service.GetCollection();
        public IToastService ToastService => LazyResolver<IToastService>.Service;

        public HomeModelView()
        {
            ButtonAdd = new DelegateCommand(ButtonAddClicked);
            ButtonEdit = new DelegateCommand(ButtonEditClicked);

        }

        private void ButtonAddClicked()
        {
             NavigationService.Navigate("Add");
        }

        private void ButtonEditClicked()
        {
            if (SelectedTodo != null)
                NavigationService.Navigate("Disp", new Dictionary<string, object>
                {
                    {"Index", /*CollectionTodo.IndexOf(SelectedTodo)*/ SelectedTodo.Index}
                });
            else 
                ToastService.DisplayToast("Please select a Todo to edit");
        }

        public override void OnNavigatedTo(NavigationArgs e, string parametersKey)
        {
            base.OnNavigatedTo(e, parametersKey);
            CollectionTodo.Add(new Todo());
            CollectionTodo.RemoveAt(CollectionTodo.Count - 1);
        }

    }


}
