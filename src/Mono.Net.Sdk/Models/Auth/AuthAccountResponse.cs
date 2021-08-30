using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Auth
{
    public class AuthAccountResponse
    {
        [JsonProperty("id")]
        public string AccountId { get; set; }
    }
}