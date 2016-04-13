using System.Threading.Tasks;
using ModelViewTodo.Model;

namespace ModelViewTodo.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResult> ConnexionAsync(string i, string p);
        Task<HttpResult>RegisterAsync(string i, string p);
    }

}