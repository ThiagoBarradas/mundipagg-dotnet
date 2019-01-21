using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateSubscriptionItemRequest
    {

        public int? Cycles { get; set; }

        public string Description { get; set; }

        public List<CreateDiscountRequest> Discounts { get; set; }

        public string Id { get; set; }

        public int? MinimumPrice { get; set; }

        public string Name { get; set; }

        public string PlanItemId { get; set; }

        public CreatePricingSchemeRequest PricingScheme { get; set; }

        public int? Quantity { get; set; }

    }
}