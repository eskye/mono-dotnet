using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class StatementResponse
    {
        [JsonProperty("meta")]
        public ResponseMeta Meta { get; set; }

        [JsonProperty("data")]
        public List<Statement> StatementList { get; set; }
    }
    
    public class Statement
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }
    }

    public class ResponseMeta
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public enum OutputType
    {
        Pdf=1,
        Json
    }
}