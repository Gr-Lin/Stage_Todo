using System.Collections.ObjectModel;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;

namespace ModelViewTodo.Services
{
    public class CollectionTodoService : ICollectionTodoService
    {
        private ObservableCollection<Todo> _todoCollection;

        public ObservableCollection<Todo> GetCollection()
        {
            if (_todoCollection == null)
                _todoCollection = new ObservableCollection<Todo>();
            return _todoCollection;
        }

        public void AddCollec(string title, string description)
        {
            _todoCollection.Add(new Todo(title, description));
        }
    }
}