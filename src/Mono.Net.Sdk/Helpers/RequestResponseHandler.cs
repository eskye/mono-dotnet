using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Mono.Net.Sdk.Exceptions;
using Mono.Net.Sdk.Models;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Helpers
{
    public class RequestResponseHandler<T>
    {
        public HttpResponseMessage Message { get; set; }
        public string ResponseBody { get; set; }
        public T Data { get; set; }
        public ApiResponse<T> ToApiResponse()
        {
            return new ApiResponse<T>
            {
                Data = Data
            };
        }
        /// <summary>
        /// Retrieve the HTTP Response content.
        /// </summary>
        /// <param name="message"></param> 
        /// <returns name="RequestResponseHandler"></returns>
        /// <exception cref="MonoApiException"></exception>
        public static async Task<RequestResponseHandler<T>> FromMessage(HttpResponseMessage message)
        {
            var response = new RequestResponseHandler<T>
            {
                Message = message, 
                ResponseBody = await message.Content.ReadAsStringAsync()
            };
            if (!message.IsSuccessStatusCode) throw new MonoApiException(message.StatusCode, message.ReasonPhrase);
              response.Data = JsonConvert.DeserializeObject<T>(response.ResponseBody); 
            return response;
        }
    }
}