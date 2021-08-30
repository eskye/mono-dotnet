using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Auth
{
  public class ReAuthorizeCodeResponse
  {
    [JsonProperty("token")]
    public string Token { get; set; }
  }
}
