using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetChargeResponse 
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string GatewayId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DueAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public GetTransactionResponse LastTransaction { get; set; }
        public GetInvoiceResponse Invoice { get; set; }
        public GetOrderResponse Order { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public DateTime? PaidAt { get; set; }
        public DateTime? CanceledAt { get; set; }
        public int CanceledAmount { get; set; }
    }
} 