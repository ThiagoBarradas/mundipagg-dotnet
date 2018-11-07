namespace Mundipagg.Models.Request
{
    public class CreateCancelSubscriptionRequest
    {
        #region Public Properties

        public bool CancelPendingInvoices { get; set; } = true;

        #endregion Public Properties
    }
}