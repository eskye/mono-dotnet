using System;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Account;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Interfaces;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Account;
using Mono.Net.Sdk.Models.User;

namespace Mono.Net.Sdk.User
{
    public class UsersClient : IUsersClient
    {
        private readonly IBaseApiClient _apiClient;
        private readonly IApiAuthHeader _apiAuthHeader;

        public UsersClient(IBaseApiClient apiClient, ApiConfig config)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            if (config == null) throw new ArgumentNullException(nameof(config));
            _apiAuthHeader = new SecretKeyAuthHeader(config);
        }
        
        public async Task<ApiResponse<WalletBalanceResponse>> GetWalletBalance(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await _apiClient.GetHttpAsync<WalletBalanceResponse>($"users/stats/wallet", cancellationToken);
            return response.ToApiResponse();
        }
        
        
    }
}