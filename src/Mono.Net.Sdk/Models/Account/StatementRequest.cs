using System;
using System.Collections.Generic;
using Mono.Net.Sdk.Helpers;

namespace Mono.Net.Sdk.Models.Account
{
    public class StatementRequest
    { 
        public string Period { get; set; }
        public string Output { get; set; }
        public string PathWithQuery(string path)
        {
            var queryParameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(Period)) queryParameters.Add("period", Period);
            if (!string.IsNullOrEmpty(Output)) queryParameters.Add("output", Output);
            return QueryHelpers.AddQueryString(path, queryParameters);
        }
    }
}