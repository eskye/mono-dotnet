using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Sdk.Helpers;

namespace Mono.Net.Sdk.Interfaces
{
    public interface IBaseApiClient
    {
        /// <summary>
        /// Executes a Post request to the specified <paramref="url"/>. 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <typeparam name="TResult">The expected response type to be deserialized</typeparam>
        /// <returns></returns>
        Task<RequestResponseHandler<TResult>> PostHttpAsync<TResult>(string url, object data,  CancellationToken cancellationToken);
        /// <summary>
        /// Executes a Delete request to the specified <paramref="url"/>. 
        /// </summary>
        /// <param name="url">The API Resource url</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <typeparam name="TResult">The expected response type to be deserialized</typeparam>
        /// <returns></returns>
        Task<RequestResponseHandler<TResult>> DeleteHttpAsync<TResult>(string url, CancellationToken cancellationToken);
        /// <summary>
        /// Executes a GET request to the specified <paramref="url"/>. 
        /// </summary>
        /// <param name="url">The API Resource url</param>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the underlying HTTP request.</param>
        /// <typeparam name="TResult">The expected response type to be deserialized</typeparam>
        /// <returns></returns>
        Task<RequestResponseHandler<TResult>> GetHttpAsync<TResult>(string url, CancellationToken cancellationToken);
    }
}