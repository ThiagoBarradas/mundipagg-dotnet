using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCardPaymentTokenRequest
    {
        public ApplePayRequest ApplePay { get; set; }

        public string Type { get; set; }
    }
}