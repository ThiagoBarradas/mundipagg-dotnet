using Mundipagg.Resources;
using Mundipagg.Resources.Interface;

namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client
    /// </summary>
    public class MundipaggApiClient : IMundipaggApiClient
    {
        /// <summary>
        /// Creates a new api client using default values for api url and timeout and empty secret key
        /// </summary>
        public MundipaggApiClient()
        {
            this.Initialize(new Configuration());
        }

        /// <summary>
        /// Creates a new api client using default values for api url and timeout
        /// </summary>
        /// <param name="secretKey">Your secret key, something like sk_xxxxx or sk_test_xxxx</param>
        public MundipaggApiClient(string secretKey)
        {
            this.Initialize(new Configuration(secretKey));
        }

        /// <summary>
        /// Creates a new api client using a custom values for url and timeout
        /// </summary>
        /// <param name="apiUrl"></param>
        public MundipaggApiClient(string apiUrl, int timeout, string requestKey)    
        {
            this.Initialize(new Configuration(apiUrl, timeout)
            {
                RequestKey = requestKey    
            });
        }

        /// <summary>
        /// Creates a new api with full configuration
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        public MundipaggApiClient(Configuration configuration)
        {
            this.Initialize(configuration);
        }

        public IChargeResource Charge { get; private set; }

        public Configuration Configuration
        {
            get { return _configuration; }
            set
            {
                this._configuration = value;
                this.Charge.Configuration = this._configuration;
                this.Customer.Configuration = this._configuration;
                this.Invoice.Configuration = this._configuration;
                this.Order.Configuration = this._configuration;
                this.Subscription.Configuration = this._configuration;
                //this.Plans.Configuration = this._configuration;
                //this.Recipients.Configuration = this._configuration;
                //this.Sellers.Configuration = this._configuration;
                //this.Tokens.Configuration = this._configuration;
            }
        }

        public ICustomerResource Customer { get; private set; }

        public IInvoiceResource Invoice { get; private set; }

        public IOrderResource Order { get; private set; }

        public ISubscriptionResource Subscription { get; private set; }

        public IWebhookResource Webhook { get; private set; }

        private Configuration _configuration { get; set; }

        public void SetSecretKey(string secretKey)
        {
            this.Configuration.SecretKey = secretKey;
        }

        public void SetSecretKey(string secretKey, string accountId)
        {
            this.Configuration.SecretKey = secretKey;
            this.Configuration.AccountId = accountId;
        }

        public void SetSecretKey(string secretKey, string accountId, string merchantId)
        {
            this.Configuration.SecretKey = secretKey;
            this.Configuration.AccountId = accountId;
            this.Configuration.MerchantId = merchantId;
        }

        /// <summary>
        /// Initialize api client
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        private void Initialize(Configuration configuration)
        {
            this.Customer = new CustomerResource(configuration);
            this.Webhook = new WebhookResource(configuration);
            this.Charge = new ChargeResource(configuration);
            this.Invoice = new InvoiceResource(configuration);
            this.Order = new OrderResource(configuration);
            this.Subscription = new SubscriptionResource(configuration);
            this.Configuration = configuration;
        }
    }
}