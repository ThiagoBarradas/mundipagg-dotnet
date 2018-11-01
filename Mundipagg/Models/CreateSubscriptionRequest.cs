using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Mundipagg;
using Mundipagg.Utilities;


namespace Mundipagg.Models
{
    public class CreateSubscriptionRequest 
    {
        private string description;
        private string currency;
        private string interval;
        private int intervalCount;
        private Models.CreatePricingSchemeRequest pricingScheme;
        private List<Models.CreateSubscriptionItemRequest> items;
        private Models.CreateShippingRequest shipping;
        private List<Models.CreateDiscountRequest> discounts;
        private Dictionary<string, string> metadata;
        private Models.CreateSetupRequest setup;
        private string planId;
        private string customerId;
        private string cardId;
        private int? billingDay;
        private int? installments;
        private DateTime? startAt;
        private int? minimumPrice;
        private int? cycles;
        private string cardToken;
        private string gatewayAffiliationId;
        private int? quantity;
        private int? boletoDueDays;
        private List<Models.CreateIncrementRequest> increments;

        public CreateCustomerRequest Customer { get; set; }
        public CreateCardRequest Card { get; set; }
        public string Code { get; set; }
        public string PaymentMethod { get; set; }
        public string BillingType { get; set; }
        public string StatementDescriptor { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Interval { get; set; }
        public int IntervalCount { get; set; }
        public CreatePricingSchemeRequest PricingScheme { get; set; }
        public List<CreateSubscriptionItemRequest> Items { get; set; }
        public CreateShippingRequest Shipping { get; set; }
        public List<CreateDiscountRequest> Discounts { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public CreateSetupRequest Setup { get; set; }
        public string PlanId { get; set; }
        public string CustomerId { get; set; }
        public string CardId { get; set; }
        public int? BillingDay { get; set; }
        public int? Installments { get; set; }
        public DateTime? StartAt { get; set; }
        public int? MinimumPrice { get; set; }
        public int? Cycles { get; set; }
        public string CardToken { get; set; }
        public string GatewayAffiliationId { get; set; }
        public int? Quantity { get; set; }
        public int? BoletoDueDays { get; set; }
        public List<CreateIncrementRequest> Increments { get; set; }
    }
} 