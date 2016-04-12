using System.Threading.Tasks;

namespace ModelViewTodo.Interfaces
{
    public interface IHttpService
    {
        Task<bool> ConnexionAsync(string i, string p);
        //connection
        //enregistrement
    }

}