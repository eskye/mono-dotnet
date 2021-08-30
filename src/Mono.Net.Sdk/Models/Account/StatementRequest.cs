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

    /// <summary>
    /// Query params for the transactions endpoint
    /// </summary>
    public class AccountTransactionsOptionsRequest
    {
        public string Start { get; set; }
        public string End { get; set; }
        public string Narration { get; set; }
        public string Type { get; set; } 
        public bool Paginate { get; set; } 
        public int Limit { get; set; } 
        
        public string PathWithQuery(string path)
        {
            var queryParameters = new Dictionary<string, string>
            {
                {nameof(Paginate).ToLower(), Paginate.ToString().ToLower()}
            };
            if (!string.IsNullOrEmpty(Start)) queryParameters.Add(nameof(Start).ToLower(), Start);
            if (!string.IsNullOrEmpty(End)) queryParameters.Add(nameof(End).ToLower(), End);
            if (!string.IsNullOrEmpty(Type)) queryParameters.Add(nameof(Type).ToLower(), Type);
            if (!string.IsNullOrEmpty(Narration)) queryParameters.Add(nameof(Narration).ToLower(), Narration);  
            if(Limit > 0) queryParameters.Add(nameof(Limit).ToLower(), Limit.ToString());  
            return QueryHelpers.AddQueryString(path, queryParameters);
        }
    }
}