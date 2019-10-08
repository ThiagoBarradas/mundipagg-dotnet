using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSubscriptionMinimumPriceRequest
    {
        public int? MinimumPrice { get; set; }
    }
}