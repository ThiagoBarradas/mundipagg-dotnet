using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListDiscountsRequest : BaseListRequest
    {
        public string SubscriptionId { get; set; }
    }
}