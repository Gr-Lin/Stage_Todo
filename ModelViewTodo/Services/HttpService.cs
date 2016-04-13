using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ModelViewTodo.Interfaces;
using ModelViewTodo.Model;
using Newtonsoft.Json;

namespace ModelViewTodo.Services
{
    public class HttpService : IHttpService
    {
        private const string Url = "http://storm-project.fr/ios/api/";
        private const string Login = "/login";
        private const string Register = "/register";
        private const string Get = "/list";
        private const string Add = "/add";
        private const string Edit = "/edit";
        private const string Delete = "/delete";

        private readonly HttpClient _client = new HttpClient();

        public async Task<HttpResult> ConnexionAsync(string log, string pwd, bool hashed)
        {
            if (!hashed)
            {
                pwd = HashPassword(pwd);
            }
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("login", log),
                new KeyValuePair<string, string>("password", pwd)
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var result = await _client.PostAsync(Url + Login, content);
            var resultString = await result.Content.ReadAsStringAsync();
        
            return JsonConvert.DeserializeObject<HttpResult>(resultString);

        }

        public async Task<HttpResult> RegisterAsync(string id, string pwd)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("login", id),
                new KeyValuePair<string, string>("password", HashPassword(pwd))
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var result = await _client.PostAsync(Url + Register, content);
            var resultString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<HttpResult>(resultString);

        }

        public string HashPassword(string pwd)
        {
            SHA1CryptoServiceProvider algo = new SHA1CryptoServiceProvider();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(pwd);
            string pass =  BitConverter.ToString(algo.ComputeHash(buffer)).Replace("-", ""); 
            return pass.ToLower();
        }

        public async Task<List<Todo>> GetTodoAsync()
        {
            var result = await _client.GetAsync(Url + Get);
            var resultString = await result.Content.ReadAsStringAsync();

            HttpResultList answer = JsonConvert.DeserializeObject<HttpResultList>(resultString);
            if (answer.Ok)
                return answer.Resource;
            throw new JsonException("Deserialization failed.");
        }

        public async Task<HttpResultTodo> AddTodoAsync(Todo t)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("title", t.Name),
                new KeyValuePair<string, string>("description", t.Description)
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var result = await _client.PostAsync(Url + Add, content);
            var resultString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<HttpResultTodo>(resultString);
        }

        public async Task<HttpResultTodo> EditTodoAsync(Todo t)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("id", t.Index.ToString()),
                new KeyValuePair<string, string>("title", t.Name),
                new KeyValuePair<string, string>("description", t.Description)
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var result = await _client.PostAsync(Url + Edit, content);
            var resultString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<HttpResultTodo>(resultString);
        }

        public async Task<HttpResult> DeleteTodoAsync(Todo t)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("id", t.Index.ToString()),
            };
            HttpContent content = new FormUrlEncodedContent(tab);

            var result = await _client.PostAsync(Url + Add, content);
            var resultString = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<HttpResult>(resultString);

        } 
    }
}