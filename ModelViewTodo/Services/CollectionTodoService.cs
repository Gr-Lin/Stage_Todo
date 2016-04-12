using System.Collections.ObjectModel;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;

namespace ModelViewTodo.Services
{
    public class CollectionTodoService : ICollectionTodoService
    {
        private ObservableCollection<Todo> _todoCollection;
        private int _count = 0;

        public ObservableCollection<Todo> GetCollection()
        {
            return _todoCollection ?? (_todoCollection = new ObservableCollection<Todo>());
        }

        public void AddCollec(string title, string description)
        {
            _todoCollection.Add(new Todo(title, description, _count));
            _count++;
        }

        public void EditCollec(string title, string description, int index)
        {
            _todoCollection[index].Name = title;
            _todoCollection[index].Description = description;
        }

        public void SuppCollec(int i)
        {
            _todoCollection.Remove(_todoCollection[i]);
            _count--;
        }
    }
}