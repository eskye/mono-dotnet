using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Interfaces;

namespace Mono.Net.Sdk
{
    public class SecretKeyAuthHeader : IApiAuthHeader
    {
        private readonly ApiConfig _config;

        public SecretKeyAuthHeader(ApiConfig config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Set your mono secret key for the request to be authorized
        /// </summary>
        /// <param name="message"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public Task SetAuthHeaderCredential(HttpRequestMessage request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrEmpty(_config.SecretKey)) 
                throw new ArgumentNullException("Your (Mono Secret Key) must be configured", nameof(_config.SecretKey));
            request.Headers.Authorization = new AuthenticationHeaderValue(_config.SecretKey);
            return Task.FromResult(0);
        }
    }
}