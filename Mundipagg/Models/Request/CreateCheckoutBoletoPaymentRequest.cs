using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutBoletoPaymentRequest
    {
        public string Bank { get; set; }

        public DateTime DueAt { get; set; }

        public string Instructions { get; set; }
    }
}