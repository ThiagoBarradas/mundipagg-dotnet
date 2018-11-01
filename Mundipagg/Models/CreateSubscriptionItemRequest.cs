using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateSubscriptionItemRequest
    {
        public string Description { get; set; }
        public CreatePricingSchemeRequest PricingScheme { get; set; }
        public string Id { get; set; }
        public string PlanItemId { get; set; }
        public List<CreateDiscountRequest> Discounts { get; set; }
        public string Name { get; set; }
        public int? Cycles { get; set; }
        public int? Quantity { get; set; }
        public int? MinimumPrice { get; set; }
    }
} 