using Storm.Mvvm.Inject;
using ModelViewTodo.ModelView;

namespace ModelViewTodo
{
    public class ViewModelLocator
    {
        private static IContainer _container;

        public static void Initialize(IContainer container)
        {
            container.RegisterFactory(x => new DeleteViewModel());
            _container = container;
        }

        public DeleteViewModel Delete => _container.Resolve<DeleteViewModel>();
    }
}