using MundiPagg.Models;
using MundiPagg.Resources;
using MundiPagg.Resources.Interface;

namespace MundiPagg
{
    /// <summary>
    /// MundiPagg Api Client
    /// </summary>
    public class ApiClient : IApiClient
    {
        /// <summary>
        /// Creates a new api client using default values for api url and timeout
        /// </summary>
        /// <param name="secretKey">Your secret key, something like sk_xxxxx or sk_test_xxxx</param>
        public ApiClient(string secretKey)
        {
            this.Initialize(new Configuration(secretKey));
        }

        /// <summary>
        /// Creates a new api with full configuration
        /// </summary>
        /// <param name="configuration">MundiPagg Api configuration</param>
        public ApiClient(Configuration configuration)
        {
            this.Initialize(configuration);
        }

        /// <summary>
        /// Initialize api client
        /// </summary>
        /// <param name="configuration">MundiPagg Api configuration</param>
        private void Initialize(Configuration configuration)
        {
            this.Customer = new CustomerResource(configuration);
            this.Webhook = new WebhookResource(configuration);
        }

        /// <summary>
        /// Customer manager
        /// </summary>
        public ICustomerResource Customer { get; private set; }
        
        /// <summary>
        /// Webhook manager
        /// </summary>
        public IWebhookResource Webhook { get; private set; }
    }
}
