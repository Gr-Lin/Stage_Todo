using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ModelViewTodo.Model;
using ModelViewTodo.Interfaces;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.ModelView
{
    public class DisplayModelView : ViewModelBase
    {
        public ICommand ButtonAdd { get; private set; }

        public ObservableCollection<Todo> CollectionTodo
        {
            get { return LazyResolver<ICollectionTodoService>.Service.GetCollection(); }
        }


        public DisplayModelView()
        {
            CollectionTodo.Add(new Todo("Premiere Tache", "Ceci est un descriptif de tache"));
            CollectionTodo.Add(new Todo("Deuxieme Tache", "J'essais des trucs"));

            ButtonAdd = new DelegateCommand(ButtonClicked);
        }

        private void ButtonClicked()
        {
             NavigationService.Navigate("Add");
        }

    }

   
}
