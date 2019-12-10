using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetChargeResponse
    {
        public int Amount { get; set; }

        public int CanceledAmount { get; set; }

        public int PaidAmount { get; set; }

        public DateTime? CanceledAt { get; set; }

        public string Code { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Currency { get; set; }

        public GetCustomerResponse Customer { get; set; }

        public DateTime DueAt { get; set; }

        public string GatewayId { get; set; }

        public string Id { get; set; }

        public GetInvoiceResponse Invoice { get; set; }

        public GetTransactionResponse LastTransaction { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public GetOrderResponse Order { get; set; }

        public DateTime? PaidAt { get; set; }

        public string PaymentMethod { get; set; }

        public string Status { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}