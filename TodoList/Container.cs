using Storm.Mvvm.Inject;
using ModelViewTodo;

namespace TodoList
{
    public class Container : AndroidContainer
    {
        public static readonly ViewModelLocator Locator = new ViewModelLocator();

        protected override void Initialize()
        {
            base.Initialize();
            ViewModelLocator.Initialize(this);
        }
    }
}