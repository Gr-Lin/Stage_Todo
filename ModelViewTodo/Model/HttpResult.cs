using Newtonsoft.Json;

namespace ModelViewTodo.Model
{
    public class HttpResult
    {
        public bool Ok { get; set; }

        [JsonProperty ("error")]
        public string Message { get; set; }

    }

}