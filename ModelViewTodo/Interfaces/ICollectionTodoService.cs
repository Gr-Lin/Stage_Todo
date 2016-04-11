using ModelViewTodo.Model;
using System.Collections.ObjectModel;

namespace ModelViewTodo.Interfaces
{
    public interface ICollectionTodoService
    {
        ObservableCollection<Todo> GetCollection();
        void AddCollec(string t, string d);
    }
}
