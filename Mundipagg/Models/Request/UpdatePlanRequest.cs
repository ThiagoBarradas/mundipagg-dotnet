using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdatePlanRequest
    {
        public List<int> BillingDays { get; set; }

        public string BillingType { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public List<int> Installments { get; set; }

        public string Interval { get; set; }

        public int IntervalCount { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public int? MinimumPrice { get; set; }

        public string Name { get; set; }

        public List<string> PaymentMethods { get; set; }

        public bool Shippable { get; set; }

        public string StatementDescriptor { get; set; }

        public string Status { get; set; }

        public int? TrialPeriodDays { get; set; }
    }
}