using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutDebitCardPaymentResponse
    {
        public GetPaymentAuthenticationResponse Authentication { get; set; }

        public string StatementDescriptor { get; set; }
    }
}