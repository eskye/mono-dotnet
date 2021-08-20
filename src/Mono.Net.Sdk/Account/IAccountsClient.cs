using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Account;

namespace Mono.Net.Sdk.Account
{
    public interface IAccountsClient
    {
        /// <summary>
        /// Get the account information for a specified accountId <paramref name="accountId"/>
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<InformationResponse>> GetAccountInformation(string accountId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the bank statement of a connected financial account for a specified accountId <paramref name="accountId"/> in JSON output format
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="period">You can query 1-12 months bank statement in one single call.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<StatementResponse>> GetAccountStatementsInJson(string accountId, int period = 1,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get the bank statement of a connected financial account for a specified accountId <paramref name="accountId"/> in PDF output format
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="period">You can query 1-12 months bank statement in one single call.</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<StatementPdfResponse>> GetAccountStatementsPdf(string accountId, int period = 1,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// With this resource, you set the output as PDF, and you can use this endpoint to poll the status
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param>
        /// <param name="jobId">ID returned from statements API of output type pdf</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<StatementPdfResponse>> GetPollPdfAccountStatementStatus(string accountId, string jobId,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}