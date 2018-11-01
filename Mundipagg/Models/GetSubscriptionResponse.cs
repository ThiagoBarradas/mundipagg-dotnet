using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetSubscriptionResponse 
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public DateTime StartAt { get; set; }
        public string Interval { get; set; }
        public int IntervalCount { get; set; }
        public string BillingType { get; set; }
        public GetPeriodResponse CurrentCycle { get; set; }
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        public int Installments { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public GetCustomerResponse Customer { get; set; }
        public GetCardResponse Card { get; set; }
        public List<GetSubscriptionItemResponse> Items { get; set; }
        public string StatementDescriptor { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public GetSetupResponse Setup { get; set; }
        public string GatewayAffiliationId { get; set; }
        public DateTime? NextBillingAt { get; set; }
        public int? BillingDay { get; set; }
        public int? MinimumPrice { get; set; }
        public DateTime? CanceledAt { get; set; }
        public List<GetDiscountResponse> Discounts { get; set; }
        public List<GetIncrementResponse> Increments { get; set; }
        public int? BoletoDueDays { get; set; }
    }
} 