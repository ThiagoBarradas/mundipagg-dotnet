namespace Mundipagg.Models
{
    public class UpdatePlanItemRequest 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public UpdatePricingSchemeRequest PricingScheme { get; set; }
        public int? Quantity { get; set; }
        public int? Cycles { get; set; }
    }
} 