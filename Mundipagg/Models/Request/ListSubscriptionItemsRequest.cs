using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListSubscriptionItemsRequest : BaseListRequest
    {
        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string Description { get; set; }

        public string ItemId { get; set; }

        public string Name { get; set; }

        public string SubscriptionId { get; set; }
    }
}