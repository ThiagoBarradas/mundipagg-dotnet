using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateSubscriptionRequest
    {
        public int? BillingDay { get; set; }

        public string BillingType { get; set; }

        public int? BoletoDueDays { get; set; }

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string CardToken { get; set; }

        public string Code { get; set; }

        public string Currency { get; set; }

        public CreateCustomerRequest Customer { get; set; }

        public string CustomerId { get; set; }

        public int? Cycles { get; set; }

        public string Description { get; set; }

        public List<CreateDiscountRequest> Discounts { get; set; }

        public string GatewayAffiliationId { get; set; }

        public List<CreateIncrementRequest> Increments { get; set; }

        public int? Installments { get; set; }

        public string Interval { get; set; }

        public int IntervalCount { get; set; }

        public List<CreateSubscriptionItemRequest> Items { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public int? MinimumPrice { get; set; }

        public string PaymentMethod { get; set; }

        public string PlanId { get; set; }

        public CreatePricingSchemeRequest PricingScheme { get; set; }

        public int? Quantity { get; set; }

        public CreateSetupRequest Setup { get; set; }

        public CreateShippingRequest Shipping { get; set; }

        public DateTime? StartAt { get; set; }

        public string StatementDescriptor { get; set; }
    }
}