using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Helpers
{
    public class HttpHelper
    {
        /// <summary>
        /// Get formatted JSON object for the request body
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
         public static HttpContent GetJsonBody(object value)
        {
            if (value is null) return default;
             return new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");
         }
    }
}