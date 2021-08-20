using System;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Interfaces;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Account;

namespace Mono.Net.Sdk.Account
{
    public class AccountsClient : IAccountsClient
    {
        private readonly IBaseApiClient _apiClient;
        private readonly IApiAuthHeader _apiAuthHeader;

        public AccountsClient(IBaseApiClient apiClient, ApiConfig config)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            if (config == null) throw new ArgumentNullException(nameof(config));
            _apiAuthHeader = new SecretKeyAuthHeader(config);
        }
        
        public async Task<ApiResponse<InformationResponse>> GetAccountInformation(string accountId,  CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId));
            var response = await _apiClient.GetHttpAsync<InformationResponse>($"accounts/{accountId}", cancellationToken);
            return response.ToApiResponse();
        }
        
        public async Task<ApiResponse<StatementResponse>> GetAccountStatementsInJson(string accountId, int period = 1, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId)); 
            var periodText = $"last{period}months";
            var statementRequest = new StatementRequest {Output = OutputType.Json.ToString(), Period = periodText};
            var queryString = statementRequest.PathWithQuery("statement");
            var response = await _apiClient.GetHttpAsync<StatementResponse>($"accounts/{accountId}/{queryString}", cancellationToken);
            return response.ToApiResponse();
        }
        
        public async Task<ApiResponse<StatementPdfResponse>> GetAccountStatementsPdf(string accountId, int period = 1,  CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId)); 
            var periodText = $"last{period}months";
            var statementRequest = new StatementRequest {Output = OutputType.Pdf.ToString(), Period = periodText};
            var queryString = statementRequest.PathWithQuery("statement");
            var response = await _apiClient.GetHttpAsync<StatementPdfResponse>($"accounts/{accountId}/{queryString}", cancellationToken);
            return response.ToApiResponse();
        }
        
        public async Task<ApiResponse<StatementPdfResponse>> GetPollPdfAccountStatementStatus(string accountId, string jobId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId)); 
            if (string.IsNullOrWhiteSpace(jobId)) throw new ArgumentNullException(nameof(jobId));  
            var response = await _apiClient.GetHttpAsync<StatementPdfResponse>($"accounts/{accountId}/statement/jobs/{jobId}", cancellationToken);
            return response.ToApiResponse();
        }
    }
}