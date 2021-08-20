using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class StatementPdfResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}