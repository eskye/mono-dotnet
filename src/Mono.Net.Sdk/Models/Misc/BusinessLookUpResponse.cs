using System;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Misc
{
    public class BusinessLookUpResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("lga")]
        public string Lga { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("rcNumber")] 
        public string RcNumber { get; set; }

        [JsonProperty("classificationId")]
        public long ClassificationId { get; set; }

        [JsonProperty("branchAddress")]
        public string BranchAddress { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("companyStatus")]
        public string CompanyStatus { get; set; }

        [JsonProperty("approvedName")]
        public string ApprovedName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")] 
        public string Code { get; set; }
    }
    
}