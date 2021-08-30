using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.User
{
    public class WalletBalanceResponse
    {
        [JsonProperty("balance")]
        public long Balance { get; set; }
    }
}