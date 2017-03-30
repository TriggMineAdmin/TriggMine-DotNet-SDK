using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TriggMine.SDK.Core
{
    /// <summary>
    /// Base HttpClient with url & api key TriggMine
    /// </summary>
    internal static class HttpClientBase
    {
        internal static HttpClient CreateHttpClient(string apiKey, Uri apiUrl)
        {
            var client = new HttpClient();

            if (string.IsNullOrEmpty(apiKey))
                return client;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("ApiKey", apiKey);
            client.BaseAddress = apiUrl;

            return client;
        }
    }
}
