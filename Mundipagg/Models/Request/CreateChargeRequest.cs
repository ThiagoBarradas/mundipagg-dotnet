using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateChargeRequest
    {
        public string OrderId { get; set; }

        public int Amount { get; set; }

        public string Code { get; set; }

        public CreateCustomerRequest Customer { get; set; }

        public string CustomerId { get; set; }

        public DateTime? DueAt { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public CreatePaymentRequest Payment { get; set; }
    }
}