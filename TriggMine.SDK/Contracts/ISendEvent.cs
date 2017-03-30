using System.Net.Http;
using System.Threading.Tasks;

namespace TriggMine.SDK.Contracts
{
    public interface ISendEvent
    {
        HttpResponseMessage SendEvent<T>(T eventDto);
        Task<HttpResponseMessage> SendEventAsync<T>(T eventDto);
    }
}
