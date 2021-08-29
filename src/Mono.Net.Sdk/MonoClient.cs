using Mono.Net.Sdk.Account;
using Mono.Net.Sdk.Config;
using Mono.Net.Sdk.Misc;
using Mono.Net.Sdk.User;

namespace Mono.Net.Sdk
{
    /// <summary>
    /// Default implementation of <see cref="IMonoClient"/> that defines the avaliable Mono.co APIs.
    /// </summary>
    public class MonoClient : IMonoClient
    {
        /// <summary>
        /// Instantiate the mono client by supplying only the secretkey
        /// </summary>
        /// <param name="secretKey"></param>
        public MonoClient(string secretKey) : this(new ApiConfig(secretKey))
        {
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public MonoClient(ApiConfig config)
        {
            var client = new BaseApiClient(config);
            Accounts = new AccountsClient(client, config);
            Misc = new MiscClient(client, config);
            User = new UsersClient(client, config);
        }
        /// <summary>
        /// Get Accounts API.
        /// </summary>
        public IAccountsClient Accounts { get; }
        /// <summary>
        /// Get the Misc.
        /// </summary>
        public IMiscClient Misc { get; }
        
        /// <summary>
        /// Expose User Api Methods 
        /// </summary>
        public IUsersClient User { get; }
        
        public static MonoClient Create(string secretKey)
        {
            var configuration = new ApiConfig(secretKey); 
            return new MonoClient(configuration);
        }
    }
}