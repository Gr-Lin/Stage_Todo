using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;
using Newtonsoft.Json;
using Storm.Mvvm.Extensions;
using Storm.Mvvm.Inject;

namespace ModelViewTodo.Services
{
    public class CollectionTodoService : ICollectionTodoService
    {
        private ObservableCollection<Todo> _todoCollection;
        private int _count = 0;

        public ObservableCollection<Todo> GetCollection()
        {
            GetTodoOnline();
            return _todoCollection ?? (_todoCollection = new ObservableCollection<Todo>());
        }

        public void AddCollec(string title, string description)
        {
            _todoCollection.Add(new Todo(title, description));
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

        public async void GetTodoOnline()
        {
            List<Todo> list = null;
            try
            {
                list = await LazyResolver<IHttpService>.Service.GetTodoAsync();
            }
            catch (JsonException e)
            {
                //error ne devrai pas arrive
            }
            if (list != null)
                _todoCollection = new ObservableCollection<Todo>(list);
        }
        
    }
}