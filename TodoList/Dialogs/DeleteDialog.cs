using Android.Views;
using Storm.Mvvm;
using Storm.Mvvm.Bindings;
using Storm.Mvvm.Dialogs;

namespace TodoList.Dialogs
{
    [BindingElement(Path = "DeleteTodo", TargetPath = "PositiveButtonEvent")]
    public partial class DeleteDialog : AlertDialogFragmentBase
    {
        public DeleteDialog()
        {
            Title = "Confirm Delete";
            Message = "Are you sure you want to delete this Todo ?";
            Buttons.Add(DialogsButton.Positive, "Yes");
            Buttons.Add(DialogsButton.Negative, "No");
        }

        protected override ViewModelBase CreateViewModel()
        {
            return Container.Locator.Delete;
        }

        protected override View CreateView(LayoutInflater inflater, ViewGroup container)
        {
            return null;
        }
    }
}