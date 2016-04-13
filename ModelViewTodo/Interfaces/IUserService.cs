using System.Threading.Tasks;
using ModelViewTodo.Model;

namespace ModelViewTodo.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserInfoAsync();
        void SaveUserAsync(User u);
    }
}
