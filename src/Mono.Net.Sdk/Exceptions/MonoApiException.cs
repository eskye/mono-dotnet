using System;
using System.Net;

namespace Mono.Net.Sdk.Exceptions
{
    public class MonoApiException : Exception
    {
        /// <summary>
        /// Gets the HTTP Request Status code.
        /// </summary>
        /// <value></value>
        public HttpStatusCode StatusCode { get; }
        public MonoApiException(HttpStatusCode statusCode, string message):base(message)
        {
            StatusCode = statusCode;
        }
    }
}