using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListIncrementsRequest : BaseListRequest
    {
        public ListIncrementsRequest(string subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        public string SubscriptionId { get; set; }
    }
}