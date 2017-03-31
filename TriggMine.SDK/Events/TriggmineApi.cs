using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TriggMine.SDK.Contracts;
using TriggMine.SDK.Core;

namespace TriggMine.SDK.Events
{
    /// <summary>
    /// Main point to send event in TriggMine
    /// </summary>
    /// <typeparam name="T">Type of Event dto with client data</typeparam>
    public class TriggmineApi : HttpRequests, ISendEvent
    {
        public TriggmineApi(string apiKey, Uri apiUrl)
            : base(apiKey, HttpClientBase.CreateHttpClient(apiKey, apiUrl))
        { }

        /// <summary>
        /// Send type of event to TriggMine API
        /// </summary>
        /// <typeparam name="T">Type of event</typeparam>
        /// <param name="eventDto">Event data</param>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage SendEvent<T>(T eventDto)
        { 
            return Post(EventsRepository.GetEventUrl(typeof(T)), eventDto);
        }

        /// <summary>
        /// Async version send event to TriggMine API
        /// </summary>
        /// <typeparam name="T">Type of event</typeparam>
        /// <param name="eventDto">Event data</param>
        /// <returns>Task<HttpResponseMessage/></returns>
        public Task<HttpResponseMessage> SendEventAsync<T>(T eventDto)
        {
            return PostAsync(EventsRepository.GetEventUrl(typeof(T)), eventDto);
        }

        /// <summary>
        /// Static async version send event to TriggMine API
        /// </summary>
        /// <typeparam name="T">Type of event</typeparam>
        /// <param name="eventDto">Event data</param>
        /// <param name="apiKey">Client API key</param>
        /// <param name="apiUrl">Client Url</param>
        /// <returns>Task<HttpResponseMessage/></returns>
        public static HttpResponseMessage SendEvent<T>(T eventDto, string apiKey, Uri apiUrl)
        {
            using (var httpClient = HttpClientBase.CreateHttpClient(apiKey, apiUrl))
            {
                var content = JsonConvert.SerializeObject(eventDto);
                var url = EventsRepository.GetEventUrl(typeof(T));

                return httpClient.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json")).Result;
            }
        }
    }
}
