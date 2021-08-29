using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class WalletBalanceResponse
    {
        [JsonProperty("balance")]
        public long Balance { get; set; }
    }
}