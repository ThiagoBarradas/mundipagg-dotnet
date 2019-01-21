namespace Mundipagg.Models.Request
{
    public class CreateCancelSubscriptionRequest
    {

        public bool CancelPendingInvoices { get; set; } = true;

    }
}