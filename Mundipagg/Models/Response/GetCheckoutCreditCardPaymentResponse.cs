using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutCreditCardPaymentResponse
    {
        public GetPaymentAuthenticationResponse Authentication { get; set; }

        public List<GetCheckoutCardInstallmentOptionsResponse> Installments { get; set; }

        public string StatementDescriptor { get; set; }
    }
}