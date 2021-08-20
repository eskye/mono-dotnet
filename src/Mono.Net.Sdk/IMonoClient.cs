using Mono.Net.Sdk.Account;

namespace Mono.Net.Sdk
{
    public interface IMonoClient
    {
        /// <summary>
        /// Get the Accounts API.
        /// </summary>
        IAccountsClient Accounts { get; }
    }
}