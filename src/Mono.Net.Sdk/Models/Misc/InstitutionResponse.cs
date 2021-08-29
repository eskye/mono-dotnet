using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mono.Net.Sdk.Models.Misc
{
    public class InstitutionResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("coverage")]
        public Coverage Coverage { get; set; }

        [JsonProperty("products")]
        public List<string> Products { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public  class Coverage
    {
        [JsonProperty("countries")]
        public List<string> Countries { get; set; }

        [JsonProperty("business")]
        public bool Business { get; set; }

        [JsonProperty("personal")]
        public bool Personal { get; set; }
    }
}