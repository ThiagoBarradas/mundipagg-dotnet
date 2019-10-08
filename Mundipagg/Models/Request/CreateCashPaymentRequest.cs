using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCashPaymentRequest
    {
        public bool Confirm { get; set; }

        public string Description { get; set; }
    }
}