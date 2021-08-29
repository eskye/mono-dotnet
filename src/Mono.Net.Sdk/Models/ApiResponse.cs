using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models
{
     
    public class ApiResponse<T>
    {
        public T Data { get; set; }
    }

    public class ErrorResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}