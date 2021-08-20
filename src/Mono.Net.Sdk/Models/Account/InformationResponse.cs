using System;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public  class InformationResponse
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }
    }

    public  class Account
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("institution")]
        public Institution Institution { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("balance")]
        public long Balance { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("bvn")] 
        public string Bvn { get; set; }
    }

    public class Institution
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Meta
    {
        [JsonProperty("data_status")]
        public string DataStatus { get; set; }

        [JsonProperty("auth_method")]
        public string AuthMethod { get; set; }
    }
    
}