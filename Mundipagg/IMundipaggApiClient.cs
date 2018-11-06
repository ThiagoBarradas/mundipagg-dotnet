using Mundipagg.Resources.Interface;

namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client
    /// </summary>
    public interface IMundipaggApiClient
    {
        /// <summary>
        /// Customer manager
        /// </summary>
        ICustomerResource Customer { get; }

        /// <summary>
        /// Webhook manager
        /// </summary>
        IWebhookResource Webhook { get; }
    }
}