using Mono.Net.Sdk.Account;
using Mono.Net.Sdk.Auth;
using Mono.Net.Sdk.Misc;
using Mono.Net.Sdk.User;

namespace Mono.Net.Sdk
{
    public interface IMonoClient
    {
        /// <summary>
        /// Get the Accounts API.
        /// </summary>
        IAccountsClient Accounts { get; }
        
        /// <summary>
        /// Get the Misc.
        /// </summary>
        IMiscClient Misc { get; }
        
        /// <summary>
        /// Expose User Api Methods 
        /// </summary>
        IUsersClient User { get; }
        
        /// <summary>
        /// Expose Auth Api Methods 
        /// </summary>
        IAuthClient Auth { get; }
    }
}