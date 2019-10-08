using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateSetupRequest
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public CreatePaymentRequest Payment { get; set; }
    }
}