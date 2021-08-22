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

        /// <summary>
        /// With this resource, you can retrieve the list of known transactions on the account.
        /// </summary>
        /// <param name="accountId">Account ID returned from token exchange</param> 
        /// <param name="paginate">true or false (If you want to receive the data all at once or you want it paginated)</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <param name="start">start period of the transactions eg. 01-10-2020</param>
        /// <param name="end">end period of the transactions eg. 07-10-2020</param>
        /// <param name="narration">filters all transactions by narration e.g Uber transactions</param>
        /// <param name="limit">limit the number of transactions returned per API call</param>
        /// <param name="type">filters transactions by debit or credit</param>
        /// <returns></returns>
        Task<ApiResponse<TransactionsResponse>> GetAccountTransactions(string accountId,
            string start = null,
            string end = null,
            string narration = null,
            int limit = 0,
            string type = TransactionType.Credit,
            bool paginate = false,
            CancellationToken cancellationToken = default(CancellationToken));
    }
    
}