using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutCreditCardPaymentRequest
    {
        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public List<CreateCheckoutCardInstallmentOptionRequest> Installments { get; set; }

        public string StatementDescriptor { get; set; }

        public bool? Capture { get; set; }
    }
}