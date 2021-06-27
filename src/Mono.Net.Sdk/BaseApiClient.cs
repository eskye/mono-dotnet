using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Constants;
using Mono.Net.Sdk.Helpers;
using Mono.Net.Sdk.Interfaces;

namespace Mono.Net.Sdk
{
    public class BaseApiClient : IBaseApiClient
    {
        private readonly ApiConfig _config;
        private readonly HttpClient _httpClient;

        public BaseApiClient(ApiConfig config) : this(config, new BaseHttpClient())
        {
            
        }
        
        /// <summary>
        /// Explicitly define the <see cref="BaseApiClient"/> constructor with the necessary parameters (ApiConfig and BaseHttpClient)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="baseHttpClient"></param>
        public BaseApiClient(ApiConfig config, IBaseHttpClient baseHttpClient)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            if (baseHttpClient == null) throw new ArgumentNullException(nameof(baseHttpClient));
            _httpClient = baseHttpClient.CreateClient();
            _httpClient.BaseAddress = new Uri(BaseConstant.MonoBaseUrl);
        }
        
        protected async Task<RequestResponseHandler<T>> GetHttp<T>(string url)
        {            
            return await SendRequestAsync<T>(new HttpRequestMessage(HttpMethod.Get, url), )
        }
         
        private async Task<RequestResponseHandler<T>> SendRequestAsync<T>(HttpRequestMessage requestMessage, IApiAuthHeader apiAuthHeader, CancellationToken cancellationToken = default)
        { 
            await apiAuthHeader.SetAuthHeaderCredential(requestMessage); 
            var response = await _httpClient.SendAsync(requestMessage,cancellationToken); 
            return await RequestResponseHandler<T>.FromMessage(response); 
        }
    }
}