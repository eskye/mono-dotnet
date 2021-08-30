using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class IncomeResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("employer")]
        public string Employer { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }
}