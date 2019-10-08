using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateCardRequest
    {
        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public int ExpMonth { get; set; }

        public int ExpYear { get; set; }

        public string HolderName { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}