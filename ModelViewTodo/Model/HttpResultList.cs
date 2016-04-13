using System.Collections.Generic;

namespace ModelViewTodo.Model
{
    public class HttpResultList : HttpResult
    {
        public  List<Todo> Resource { get; set; }

        public HttpResultList()
        {
            Resource = new List<Todo>();
        }
    }

}