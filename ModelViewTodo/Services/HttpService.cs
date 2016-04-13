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

        private readonly HttpClient _client = new HttpClient();

        public async Task<HttpResult> ConnexionAsync(string log, string pwd)
        {
            IEnumerable<KeyValuePair<string, string>> tab = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("login", log),
                new KeyValuePair<string, string>("password", HashPassword(pwd))
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
    }
}