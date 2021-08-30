using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Auth;

namespace Mono.Net.Sdk.Auth
{
    public interface IAuthClient
    {
        /// <summary>
        /// Use this endpoint to request for account id (that identifies the authenticated account) after successful enrolment on the Mono connect widget.
        /// </summary>
        /// <param name="request">Body request to retrieve the account id, contain the code returned from the mono widget after successful enrolment</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<AuthAccountResponse>> GetAccountId(AuthAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));
        
        /// <summary>
        /// This method handles manual data sync of specified <paramref name="accountId"/> 
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<ManualDataSyncResponse>> SyncDataManually(string accountId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Use this endpoint to send re-authorization requests.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<ApiResponse<ReAuthorizeCodeResponse>> ReAuthorizeCode(string accountId, CancellationToken cancellationToken = default(CancellationToken));
    }
    
}