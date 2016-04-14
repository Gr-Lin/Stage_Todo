using Android.App;
using Storm.Mvvm.Inject;
using Storm.Mvvm.Interfaces;

namespace TodoList.Services
{
    public abstract class AbstractAndroidService
    {
        protected IActivityService ActivityService => LazyResolver<IActivityService>.Service;

        protected Activity CurrentActivity => ActivityService.CurrentActivity;

    }
}