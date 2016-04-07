using System.Collections.ObjectModel;

namespace ModelView.Model
{
   public class CollectionTodo
    {
        private ObservableCollection<Todo> _todoC;

        public CollectionTodo()
        {
            _todoC = new ObservableCollection<Todo>();
        }

       public ObservableCollection<Todo> GetCollection()
        {
            if (_todoC == null)
                _todoC = new ObservableCollection<Todo>();
            return _todoC;
        }
    }
}
