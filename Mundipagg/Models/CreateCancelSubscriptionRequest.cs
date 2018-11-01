namespace Mundipagg.Models
{
    public class CreateCancelSubscriptionRequest 
    {
        public bool CancelPendingInvoices { get; set; } = true;
    }
} 