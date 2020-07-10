using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSubscriptionSettingsRequest
    {
        public bool Enabled { get; set; }

        public int? BoletoDueDays { get; set; }

        public bool? UsageReportEnabled { get; set; }
    }
}
