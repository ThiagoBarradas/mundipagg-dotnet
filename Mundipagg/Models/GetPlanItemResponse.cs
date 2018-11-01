using System;


namespace Mundipagg.Models
{
    public class GetPlanItemResponse 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public GetPricingSchemeResponse PricingScheme { get; set; }
        public string Description { get; set; }
        public GetPlanResponse Plan { get; set; }
        public int? Quantity { get; set; }
        public int? Cycles { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
} 