using System.Net.Http;
using System.Threading.Tasks;

namespace TriggMine.SDK.Contracts
{
    public interface IHttpRequests
    {
        HttpResponseMessage Get(string url);
        HttpResponseMessage Post<T>(string url, T body);
        Task<HttpResponseMessage> GetAsync(string url);
        Task<HttpResponseMessage> PostAsync<T>(string url, T body);
    }
}
