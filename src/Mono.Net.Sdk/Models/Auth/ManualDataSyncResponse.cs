using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Auth
{
    public class ManualDataSyncResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}