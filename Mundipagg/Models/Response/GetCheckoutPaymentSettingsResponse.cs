using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutPaymentSettingsResponse
    {
        public List<string> AcceptedPaymentMethods { get; set; }

        public int? Amount { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public string DefaultPaymentMethod { get; set; }

        public string GatewayAffiliationId { get; set; }

        public string PaymentUrl { get; set; }

        public string Status { get; set; }

        public string SuccessUrl { get; set; }
    }
}