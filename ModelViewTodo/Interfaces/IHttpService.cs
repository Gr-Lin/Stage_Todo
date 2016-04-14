using System.Collections.Generic;
using System.Threading.Tasks;
using ModelViewTodo.Model;

namespace ModelViewTodo.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResult> ConnexionAsync(string i, string p, bool h);
        Task<HttpResult>RegisterAsync(string i, string p);
        string HashPassword(string pwd);
        Task<List<Todo>> GetTodoAsync();
        Task<HttpResultTodo> AddTodoAsync(Todo t);
        Task<HttpResultTodo> EditTodoAsync(int i, string t, string d);
        Task<HttpResult> DeleteTodoAsync(Todo t);

    }

}