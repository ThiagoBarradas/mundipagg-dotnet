using Mundipagg.Resources.Interface;

namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client
    /// </summary>
    public interface IMundipaggApiClient
    {
        Configuration Configuration { get; set; }

        /// <summary>
        /// Customers resource
        /// </summary>
        ICustomerResource Customer { get; }

        /// <summary>
        /// Webhook resource
        /// </summary>
        IWebhookResource Webhook { get; }

        /// <summary>
        /// Charges resource
        /// </summary>
        IChargeResource Charge { get; }

        /// <summary>
        /// Invoices resource
        /// </summary>
        IInvoiceResource Invoice { get; }

        /// <summary>
        /// Orders resource
        /// </summary>
        IOrderResource Order { get; }

        /// <summary>
        /// Subscriptions resource
        /// </summary>
        ISubscriptionResource Subscription { get; }

        void SetSecretKey(string secretKey);
    }
}