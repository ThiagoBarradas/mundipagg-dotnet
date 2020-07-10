using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListSubscriptionsRequest : BaseListRequest
    {
        public string BillingType { get; set; }

        public string CardId { get; set; }

        public string Code { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string CustomerId { get; set; }

        public DateTime? NextBillingSince { get; set; }

        public DateTime? NextBillingUntil { get; set; }

        public string PlanId { get; set; }

        public string Status { get; set; }
    }
}