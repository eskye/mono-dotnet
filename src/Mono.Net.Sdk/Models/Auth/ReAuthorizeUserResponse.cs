using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Auth
{
  public class ReAuthorizeUserResponse
  {
    [JsonProperty("token")]
    public string Token { get; set; }
  }
}
