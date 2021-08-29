using Mono.Net.Sdk.Account;
using Mono.Net.Sdk.Auth;

namespace Mono.Net.Sdk
{
    public interface IMonoClient
    {
        /// <summary>
        /// Get the Accounts API.
        /// </summary>
        IAccountsClient Accounts { get; }

        /// <summary>
        /// Expose Auth Api Methods 
        /// </summary>
        IAuthClient Auth { get; }
    }
}
