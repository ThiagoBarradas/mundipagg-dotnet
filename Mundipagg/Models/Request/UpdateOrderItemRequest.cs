using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateOrderItemRequest
    {
        public int Amount { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}