namespace Mundipagg.Models
{
    public class UpdateSubscriptionItemRequest 
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public UpdatePricingSchemeRequest PricingScheme { get; set; }
        public string Name { get; set; }
        public int? Cycles { get; set; }
        public int? Quantity { get; set; }
        public int? MinimumPrice { get; set; }
    }
} 