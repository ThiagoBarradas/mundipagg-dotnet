using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListPlansRequest : BaseListRequest
    {
        public string Name { get; set; }

        public string BillingType { get; set; }

        public DateTime? CreatedSince { get; set; }

        public DateTime? CreatedUntil { get; set; }

        public string Status { get; set; }
    }
}