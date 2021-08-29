using Mono.Net.Sdk.Account;
using Mono.Net.Sdk.Misc;

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
    }
}