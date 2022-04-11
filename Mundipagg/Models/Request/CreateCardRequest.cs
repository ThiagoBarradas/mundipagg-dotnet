using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCardRequest
    {
        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public string Brand { get; set; }

        public string Cvv { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderDocument { get; set; }

        public string HolderName { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Number { get; set; }

        public CreateCardOptionsRequest Options { get; set; }

        public bool PrivateLabel { get; set; }

        public string Type { get; set; } = "credit";

        [JsonProperty("track_1")]
        public string Track1 { get; set; }

        [JsonProperty("track_2")]
        public string Track2 { get; set; }

        [JsonProperty("track_3")]
        public string Track3 { get; set; }

        public string Label { get; set; }
    }
}