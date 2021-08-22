using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public  class TransactionsResponse
    {
        [JsonProperty("paging")]
        public PagingResponse Paging { get; set; }

        [JsonProperty("data")]
        public List<Transaction> Transactions { get; set; }
    }

    public class Transaction
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
}