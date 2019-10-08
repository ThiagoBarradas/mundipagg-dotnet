using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePlanItemRequest
    {
        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public CreatePricingSchemeRequest PricingScheme { get; set; }

        public int? Quantity { get; set; }
    }
}