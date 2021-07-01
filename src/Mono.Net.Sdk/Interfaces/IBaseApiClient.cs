using System.Threading.Tasks;
using Mono.Net.Sdk.Helpers;

namespace Mono.Net.Sdk.Interfaces
{
    public interface IBaseApiClient
    {
        Task<RequestResponseHandler<T>> PostHttpAsync<T>(string url, object data);
        Task<RequestResponseHandler<T>> DeleteHttpAsync<T>(string url);
        Task<RequestResponseHandler<T>> GetHttpAsync<T>(string url);
    }
}