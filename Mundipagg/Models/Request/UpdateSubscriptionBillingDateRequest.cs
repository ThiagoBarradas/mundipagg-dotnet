using System;

namespace Mundipagg.Models.Request
{
    public class UpdateSubscriptionBillingDateRequest
    {
        public DateTime NextBillingAt { get; set; }
    }
}