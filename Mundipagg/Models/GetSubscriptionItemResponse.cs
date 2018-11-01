using System;
using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetSubscriptionItemResponse 
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public GetPricingSchemeResponse PricingScheme { get; set; }
        public List<GetDiscountResponse> Discounts { get; set; }
        public List<GetIncrementResponse> Increments { get; set; }
        public GetSubscriptionResponse Subscription { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public int? Cycles { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
} 