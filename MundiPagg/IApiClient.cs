using MundiPagg.Resources;
using MundiPagg.Resources.Interface;

namespace MundiPagg
{
    /// <summary>
    /// MundiPagg Api Client
    /// </summary>
    public interface IApiClient
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
