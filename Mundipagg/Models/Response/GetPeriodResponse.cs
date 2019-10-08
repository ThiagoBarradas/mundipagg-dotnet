using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPeriodResponse
    {
        public DateTime BillingAt { get; set; }

        public DateTime EndAt { get; set; }

        public string Id { get; set; }

        public DateTime StartAt { get; set; }

        public GetSubscriptionResponse Subscription { get; set; }
    }
}