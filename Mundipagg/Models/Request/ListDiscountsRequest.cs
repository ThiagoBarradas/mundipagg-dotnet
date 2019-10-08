using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListDiscountsRequest : BaseListRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="subscriptionId">required</param>
        public ListDiscountsRequest(string subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
        }

        public string SubscriptionId { get; set; }
    }
}