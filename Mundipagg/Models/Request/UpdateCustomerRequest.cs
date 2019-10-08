using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateCustomerRequest
    {
        public CreateAddressRequest Address { get; set; }

        public string Code { get; set; }

        public string Document { get; set; }

        public string Email { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public CreatePhonesRequest Phones { get; set; }

        public string Type { get; set; }
    }
}