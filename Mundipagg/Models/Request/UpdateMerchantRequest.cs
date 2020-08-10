using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateMerchantRequest
    {
        public string Name { get; set; }

        public string ClientId { get; set; }

        public string Status { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}
