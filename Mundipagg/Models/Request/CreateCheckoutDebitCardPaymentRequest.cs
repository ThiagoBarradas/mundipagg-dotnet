using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutDebitCardPaymentRequest
    {
        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public string StatementDescriptor { get; set; }
    }
}