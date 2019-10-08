using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateAddressRequest
    {
        public string Complement { get; set; }

        public string Line2 { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Number { get; set; }
    }
}