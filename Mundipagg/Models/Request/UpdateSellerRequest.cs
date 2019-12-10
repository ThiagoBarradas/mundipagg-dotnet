using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSellerRequest
    {
        public CreateAddressRequest Address { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Document { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }
    }
}