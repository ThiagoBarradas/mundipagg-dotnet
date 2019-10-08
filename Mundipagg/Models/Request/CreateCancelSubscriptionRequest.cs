using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelSubscriptionRequest
    {
        public bool CancelPendingInvoices { get; set; } = true;
    }
}