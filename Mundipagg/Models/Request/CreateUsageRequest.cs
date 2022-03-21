using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateUsageRequest
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string Mgroup { get; set; }

        public int Amount { get; set; }
        
        public int Quantity { get; set; }

        public DateTime UsedAt { get; set; }
    }
}