using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateBoletoPaymentRequest
    {
        public string Bank { get; set; }

        public CreateAddressRequest BillingAddress { get; set; }

        public string BillingAddressId { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime? DueAt { get; set; }

        public string Instructions { get; set; }

        public string NossoNumero { get; set; }

        public int Retries { get; set; }
    }
}