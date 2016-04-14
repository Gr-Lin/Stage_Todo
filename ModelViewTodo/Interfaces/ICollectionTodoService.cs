using ModelViewTodo.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ModelViewTodo.Interfaces
{
    public interface ICollectionTodoService
    {
        ObservableCollection<Todo> GetCollection();
        Todo GetTodoById(int id);
        void AddCollec(string t, string d);
        void EditCollec(string t, string d, int i);
        Task<bool> Refresh();
        void SuppCollec(int i);
    }
}
