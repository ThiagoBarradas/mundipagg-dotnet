using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdatePlanItemRequest
    {
        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public UpdatePricingSchemeRequest PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public string Status { get; set; }
    }
}