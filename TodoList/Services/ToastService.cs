using Android.Widget;
using ModelViewTodo.Interfaces;

namespace TodoList.Services
{
    public class ToastService : AbstractAndroidService, IToastService
    {
       
        public void DisplayToast(string msg)
        {
            Toast.MakeText(CurrentActivity, msg, ToastLength.Short).Show();
        }

    }
}