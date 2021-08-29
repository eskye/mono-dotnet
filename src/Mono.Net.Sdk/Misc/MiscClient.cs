using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Helpers;
using Mono.Net.Sdk.Interfaces;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Misc;

namespace Mono.Net.Sdk.Misc
{
    public class MiscClient : IMiscClient
    {
        private readonly IBaseApiClient _apiClient;
        private readonly IApiAuthHeader _apiAuthHeader;
        public MiscClient(IBaseApiClient apiClient, ApiConfig config)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient)); 
            if (config == null) throw new ArgumentNullException(nameof(config));
            _apiAuthHeader = new SecretKeyAuthHeader(config);
        }

        public async Task<ApiResponse<List<InstitutionResponse>>> GetInstitutions(CancellationToken cancellationToken = default)
        {
            var response = await _apiClient.GetHttpAsync<List<InstitutionResponse>>($"coverage", cancellationToken);
            return response.ToApiResponse();
        }
        
        public async Task<ApiResponse<List<BusinessLookUpResponse>>> BusinessLookUp(string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            if(string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            var url = QueryHelpers.AddQueryString("v1/cac/lookup", "name", name);
            var response = await _apiClient.GetHttpAsync<List<BusinessLookUpResponse>>(url, cancellationToken);
            return response.ToApiResponse();
        }
        
        public async Task<ApiResponse<List<ShareholderResponse>>> ShareholderDetails(string businessId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if(string.IsNullOrWhiteSpace(businessId)) throw new ArgumentNullException(nameof(businessId)); 
            var response = await _apiClient.GetHttpAsync<List<ShareholderResponse>>($"v1/cac/company/{businessId}", cancellationToken);
            return response.ToApiResponse();
        }

        public async Task<ApiResponse<string>> UnlinkAccount(string accountId, CancellationToken cancellationToken = default(CancellationToken))
        {
            if(string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException(nameof(accountId)); 
            var response = await _apiClient.PostHttpAsync<string>($"accounts/{accountId}/unlink", null, cancellationToken);
            return response.ToApiResponse();
        }
    }
}