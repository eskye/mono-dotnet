using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Models;
using Mono.Net.Sdk.Models.Auth;

namespace Mono.Net.Sdk.Auth
{
  public interface IAuthClient
  {
    /// <summary>
    /// Use this endpoint to send re-authorization requests.
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<ApiResponse<ReAuthorizeUserResponse>> ReAuthorizeUser(string accountId, CancellationToken cancellationToken = default(CancellationToken));
  }
}
