using System;
using System.Net.Http;
using Mono.Net.Sdk.Interfaces;

namespace Mono.Net.Sdk
{
    public class BaseHttpClient : IBaseHttpClient
    {
        private readonly HttpClient _httpClient;

        public BaseHttpClient(HttpClient httpClient = null)
        {
            _httpClient =  httpClient ?? new HttpClient();
            
        }
        /// <summary>
        /// Return <see cref="HttpClient"/> http client instance;
        /// </summary>
        /// <returns></returns>
        public HttpClient CreateClient() => _httpClient;
         
    }
}