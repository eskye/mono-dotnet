using System;
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
        private readonly IApiAuthHeader _apiAuthHeader;
        private readonly HttpClient _httpClient;

        public BaseApiClient(ApiConfig config) : this(config, new BaseHttpClient(), new SecretKeyAuthHeader(config))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="apiAuthHeader"></param>
        public BaseApiClient(ApiConfig config, IApiAuthHeader apiAuthHeader) : this(config, new BaseHttpClient(),
            new SecretKeyAuthHeader(config))
        {
            
        }

        /// <summary>
        /// Explicitly define the <see cref="BaseApiClient"/> constructor with the necessary parameters (ApiConfig and BaseHttpClient)
        /// </summary>
        /// <param name="config"></param>
        /// <param name="baseHttpClient"></param>
        /// <param name="apiAuthHeader"></param>
        public BaseApiClient(ApiConfig config, IBaseHttpClient baseHttpClient, IApiAuthHeader apiAuthHeader)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            if (baseHttpClient == null) throw new ArgumentNullException(nameof(baseHttpClient));
            _httpClient = baseHttpClient.CreateClient();
            _httpClient.BaseAddress = new Uri(BaseConstant.MonoBaseUrl);
            _apiAuthHeader = new SecretKeyAuthHeader(config);
            
        }
        public async Task<RequestResponseHandler<TResult>> PostHttpAsync<TResult>(string url, object data, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            return await SendRequestAsync<TResult>(new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = HttpHelper.GetJsonBody(data)
            }, cancellationToken);
        }
        
        public async Task<RequestResponseHandler<TResult>> DeleteHttpAsync<TResult>(string url, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            return await SendRequestAsync<TResult>(new HttpRequestMessage(HttpMethod.Delete, url), cancellationToken);
        }
        public async Task<RequestResponseHandler<TResult>> GetHttpAsync<TResult>(string url,CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));
            return await SendRequestAsync<TResult>(new HttpRequestMessage(HttpMethod.Get, url), cancellationToken);
        }
         
        private async Task<RequestResponseHandler<TResult>> SendRequestAsync<TResult>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        { 
            await _apiAuthHeader.SetAuthHeaderCredential(requestMessage); 
            var response = await _httpClient.SendAsync(requestMessage,cancellationToken); 
            return await RequestResponseHandler<TResult>.FromMessage(response); 
        }
    }
}