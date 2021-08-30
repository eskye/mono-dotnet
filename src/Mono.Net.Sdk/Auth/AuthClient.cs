using System;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Interfaces;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Auth;

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

        public async Task<ApiResponse<AuthAccountResponse>> GetAccountId(AuthAccountRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrEmpty(request.Code)) throw new ArgumentNullException(nameof(request.Code));
            var response = await _apiClient.PostHttpAsync<AuthAccountResponse>($"account/auth", request, cancellationToken);
            return response.ToApiResponse();
        }

        public async Task<ApiResponse<ManualDataSyncResponse>> SyncDataManually(string accountId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if(string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId)); 
            var response = await _apiClient.PostHttpAsync<ManualDataSyncResponse>($"accounts/{accountId}/sync", null, cancellationToken);
            return response.ToApiResponse();
        }

        public async Task<ApiResponse<ReAuthorizeCodeResponse>> ReAuthorizeCode(string accountId, CancellationToken cancellationToken = default(CancellationToken))
        {
          if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId));
          var response = await _apiClient.PostHttpAsync<ReAuthorizeCodeResponse>($"accounts/{accountId}/reauthorise", null, cancellationToken);
          return response.ToApiResponse();
        }
  }
}