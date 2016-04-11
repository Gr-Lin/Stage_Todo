using System.Collections.ObjectModel;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;

namespace ModelViewTodo.Services
{
    public class CollectionTodoService : ICollectionTodoService
    {
        private ObservableCollection<Todo> _todoCollection;
        int count = 0;

        public ObservableCollection<Todo> GetCollection()
        {
            if (_todoCollection == null)
                _todoCollection = new ObservableCollection<Todo>();
            return _todoCollection;
        }

        public void AddCollec(string title, string description)
        {
            _todoCollection.Add(new Todo(title, description, count));
            count++;
        }

        public void EditCollec(string title, string description, int index)
        {
            _todoCollection[index].Name = title;
            _todoCollection[index].Description = description;
        }

        public void SuppCollec(int i)
        {
            _todoCollection.Remove(_todoCollection[i]);
            count--;
        }
    }
}