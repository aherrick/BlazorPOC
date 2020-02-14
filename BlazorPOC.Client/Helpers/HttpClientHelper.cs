using System;
using System.Net.Http;

namespace BlazorPOC.Client.Helpers
{
    public static class HttpClientHelper
    {
        public static HttpClient Client { get; } = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44357/")
        };
    }
}