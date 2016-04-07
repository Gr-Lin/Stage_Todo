using Storm.Mvvm;
using Storm.Mvvm.Commands;
using System.Windows.Input;

namespace ModelView.ModelView
{
    public class DisplayModelView : ViewModelBase
    {
        public ICommand ButtonCommand { get; private set; }

        public DisplayModelView()
        {
            ButtonCommand = new DelegateCommand(ButtonClicked);

        }

        private void ButtonClicked()
        {
            //navigate to add
        }
    }
}
