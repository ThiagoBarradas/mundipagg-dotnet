using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPlanItemResponse
    {
        public DateTime CreatedAt { get; set; }

        public int? Cycles { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public GetPlanResponse Plan { get; set; }

        public GetPricingSchemeResponse PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public string Status { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}