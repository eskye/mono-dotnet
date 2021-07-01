using System;

namespace Mono.Net.Sdk.Config
{
    public class ApiConfig
    {
        public ApiConfig(string secretKey)
        {
            if (string.IsNullOrEmpty(secretKey)) throw new ArgumentException($"Your Mono api secret key is required", nameof(secretKey));
            SecretKey = secretKey;
        }
        
        /// <summary>
        /// Gets the secret key that will be used to authenticate the Mono api.
        /// </summary>
        public string SecretKey { get; set; }
    }
}