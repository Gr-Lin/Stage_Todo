using ModelViewTodo.Model;
using System.Collections.ObjectModel;

namespace ModelViewTodo.Interfaces
{
    public interface ICollectionTodoService
    {
        ObservableCollection<Todo> GetCollection();
        void AddCollec(string t, string d);
        void EditCollec(string t, string d, int i);
        void SuppCollec(int i);
    }
}
