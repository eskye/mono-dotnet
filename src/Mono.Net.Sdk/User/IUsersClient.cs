using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Account;
using Mono.Net.Sdk.Models.User;

namespace Mono.Net.Sdk.User
{
    public interface IUsersClient
    {
        /// <summary>
        /// This resource allows you to check the available balance in your Mono wallet
        /// </summary> 
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <returns></returns>
        Task<ApiResponse<WalletBalanceResponse>> GetWalletBalance( CancellationToken cancellationToken = default(CancellationToken));
     
    }
    
}