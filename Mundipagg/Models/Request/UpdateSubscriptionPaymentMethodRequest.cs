using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSubscriptionPaymentMethodRequest
    {
        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string PaymentMethod { get; set; }
    }
}