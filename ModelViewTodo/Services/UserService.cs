using System.Threading.Tasks;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;
using Newtonsoft.Json;
using PCLStorage;

namespace ModelViewTodo.Services
{
    public class UserService : IUserService
    {
        private const string Folder = "TodoUser";
        private const string File = "user.json";
        private User _user;

        public async Task<User> GetUserInfoAsync()
        {
            IFolder folder = await FileSystem.Current.LocalStorage.CreateFolderAsync(Folder, CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync(File, CreationCollisionOption.OpenIfExists);

            string content = await file.ReadAllTextAsync();

            _user = string.IsNullOrEmpty(content) ? new User() : JsonConvert.DeserializeObject<User>(content);

            return _user;
        }

        public async void SaveUserAsync(User u)
        {
            IFolder folder = await FileSystem.Current.LocalStorage.CreateFolderAsync(Folder, CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync(File, CreationCollisionOption.OpenIfExists);

            string json = JsonConvert.SerializeObject(u);
            await file.WriteAllTextAsync(json);

        }
    }

}