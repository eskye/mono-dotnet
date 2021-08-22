using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Account
{
    public class IdentityResponse
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }
    
        [JsonProperty("email")]
        public string Email { get; set; }
    
        [JsonProperty("phone")]
        public string Phone { get; set; }
    
        [JsonProperty("gender")]
        public string Gender { get; set; }
    
        [JsonProperty("dob")]
        public string Dob { get; set; }
    
        [JsonProperty("bvn")]
        public string Bvn { get; set; }
    
        [JsonProperty("maritalStatus")]
        public object MaritalStatus { get; set; }
    
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }
    
        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }
    }
}