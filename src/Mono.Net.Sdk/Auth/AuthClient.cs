using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Interfaces;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Auth;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mono.Net.Sdk.Auth
{
  public class AuthClient : IAuthClient
  {
    private readonly IBaseApiClient _apiClient;
    private readonly IApiAuthHeader _apiAuthHeader;

    public AuthClient(IBaseApiClient apiClient, ApiConfig config)
    {
      _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
      if (config == null) throw new ArgumentNullException(nameof(config));
      _apiAuthHeader = new SecretKeyAuthHeader(config);
    }

    public async Task<ApiResponse<ReAuthorizeUserResponse>> ReAuthorizeUser(string accountId, CancellationToken cancellationToken = default(CancellationToken))
    {
      if (accountId == null) throw new ArgumentNullException(nameof(accountId));
      var response = await _apiClient.PostHttpAsync<ReAuthorizeUserResponse>($"accounts/{accountId}/reauthorise", null, cancellationToken);
      return response.ToApiResponse();
    }
  }
}
