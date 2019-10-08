using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetUsageResponse
    {
        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Mgroup { get; set; }

        public int Quantity { get; set; }

        public string Status { get; set; }

        public GetSubscriptionItemResponse SubscriptionItem { get; set; }

        public DateTime UsedAt { get; set; }
    }
}