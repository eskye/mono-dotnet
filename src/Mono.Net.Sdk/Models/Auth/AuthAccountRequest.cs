using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Auth
{
    public class AuthAccountRequest
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}