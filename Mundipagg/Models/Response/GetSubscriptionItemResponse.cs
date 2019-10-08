using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetSubscriptionItemResponse
    {
        public DateTime CreatedAt { get; set; }

        public int? Cycles { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string Description { get; set; }

        public List<GetDiscountResponse> Discounts { get; set; }

        public string Id { get; set; }

        public List<GetIncrementResponse> Increments { get; set; }

        public string Name { get; set; }

        public GetPricingSchemeResponse PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public string Status { get; set; }

        public GetSubscriptionResponse Subscription { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}