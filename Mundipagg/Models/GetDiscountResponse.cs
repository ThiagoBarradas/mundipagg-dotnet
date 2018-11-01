using System;


namespace Mundipagg.Models
{
    public class GetDiscountResponse
    {
        public string Id { get; set; }
        public double Mvalue { get; set; }
        public string DiscountType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? Cycles { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Description { get; set; }
        public GetSubscriptionResponse Subscription { get; set; }
        public GetSubscriptionItemResponse SubscriptionItem { get; set; }
    }
} 