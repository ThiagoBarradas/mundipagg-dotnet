using System;


namespace Mundipagg.Models
{
    public class GetUsageResponse 
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime UsedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
        public DateTime? DeletedAt { get; set; }
        public GetSubscriptionItemResponse SubscriptionItem { get; set; }
        public string Code { get; set; }
        public string Mgroup { get; set; }
    }
} 