using System.Collections.Generic;
using System.Net.Http;
using ModelViewTodo.Interfaces;

namespace ModelViewTodo.Services
{
    public class HttpService : IHttpService
    {
        private const string Url = "http://storm-project.fr/ios/api/";
        private const string Login = "/login";
        private readonly HttpClient _client = new HttpClient();

        public bool Connexion(string log, string pwd)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("login", log),
                new KeyValuePair<string, string>("password", pwd)
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var ret = _client.PostAsync(Url+Login, content);
            return true;
        }
    }
}