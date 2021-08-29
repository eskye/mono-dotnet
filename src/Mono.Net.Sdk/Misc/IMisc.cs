using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Misc;

namespace Mono.Net.Sdk.Misc
{
    public interface IMiscClient
    {
        /// <summary>
        /// Get the avaliable institutions
        /// </summary>  
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<List<InstitutionResponse>>> GetInstitutions(CancellationToken cancellationToken = default);
        /// <summary>
        /// Look up a business
        /// </summary> 
        /// <param name="name">The name of the company you want to lookup.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<List<BusinessLookUpResponse>>> BusinessLookUp(string name, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the shareholder details of a company
        /// </summary> 
        /// <param name="businessId">The business id returned from the business look up.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<List<ShareholderResponse>>> ShareholderDetails(string businessId,
            CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// Get the shareholder details of a company
        /// </summary> 
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> UnlinkAccount(string accountId,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}