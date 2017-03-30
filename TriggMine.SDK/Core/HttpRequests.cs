using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TriggMine.SDK.Contracts;

namespace TriggMine.SDK.Core
{
    public abstract class HttpRequests : IHttpRequests
    {
        private readonly HttpClient _httpClient;

        protected HttpRequests(string apiKey, HttpClient httpClient)
        {
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrWhiteSpace(apiKey))
                throw new NullReferenceException();

            _httpClient = httpClient;
        }

        public HttpResponseMessage Get(string url)
        {
            using (_httpClient)
            {
                return _httpClient.GetAsync(url).Result;
            }
        }

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage Post<T>(string url, T body)
        {
            var content = JsonConvert.SerializeObject(body);

            return _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T body)
        {
            var content = JsonConvert.SerializeObject(body);

            return await _httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
        }
    }
}
