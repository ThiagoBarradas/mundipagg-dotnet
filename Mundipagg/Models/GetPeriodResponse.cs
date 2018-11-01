using System;


namespace Mundipagg.Models
{
    public class GetPeriodResponse 
    {
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public string Id { get; set; }
        public DateTime BillingAt { get; set; }
        public GetSubscriptionResponse Subscription { get; set; }
    }
} 