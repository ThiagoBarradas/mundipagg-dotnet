using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetUsagesDetailsResponse
    {
        public GetPeriodResponse Period { get; set; }

        public string SubscriptionId { get; set; }

        public int TotalAmount { get; set; }

        public int? TotalDiscount { get; set; }

        public int? TotalIncrement { get; set; }

        public List<GetUsageResponse> Usages { get; set; }
    }
}