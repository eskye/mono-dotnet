using System.Net.Http;
using System.Threading.Tasks;

namespace Mono.Net.Sdk.Interfaces
{
    public interface IApiAuthHeader
    {
        /// <summary>
        /// Set your mono secret key for the request to be authorized
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        Task SetAuthHeaderCredential(HttpRequestMessage message);
    }
}