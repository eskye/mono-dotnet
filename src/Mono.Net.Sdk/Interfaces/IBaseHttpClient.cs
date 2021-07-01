using System.Net.Http;

namespace Mono.Net.Sdk.Interfaces
{
    public interface IBaseHttpClient
    {
        /// <summary>
        /// Return <see cref="HttpClient"/> http client instance;
        /// </summary>
        /// <returns></returns>
        HttpClient CreateClient();
    }
}