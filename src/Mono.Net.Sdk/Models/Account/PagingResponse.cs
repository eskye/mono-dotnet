using System;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class PagingResponse
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}