namespace Mundipagg.Models
{
    public class CreatePlanItemRequest
    {
        public string Name { get; set; }
        public CreatePricingSchemeRequest PricingScheme { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public int? Cycles { get; set; }
        public int? Quantity { get; set; }
    }
} 