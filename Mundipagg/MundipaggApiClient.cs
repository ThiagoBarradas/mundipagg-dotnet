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
        /// Constructor
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="requestKey"></param>
        /// <param name="apiUrl"></param>
        /// <param name="timeout"></param>
        /// <param name="mpToken"></param>
        /// <param name="accountManagementKey"></param>
        /// <param name="merchantId"></param>
        /// <param name="accountId"></param>
        public MundipaggApiClient(
            string secretKey = null,
            string requestKey = null,
            string apiUrl = null,
            int? timeout = null,
            string mpToken = null,
            string accountManagementKey = null,
            string merchantId = null,
            string accountId = null)
        {
            this.Initialize(new Configuration(secretKey, requestKey, apiUrl, timeout, mpToken, accountManagementKey)
            {
                MerchantId = merchantId,
                AccountId = accountId
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
                this.Account.Configuration = this._configuration;
                this.Merchant.Configuration = this._configuration;
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

        public IAccountResource Account { get; private set; }

        public IMerchantResource Merchant { get; private set; }

        public ICustomerResource Customer { get; private set; }

        public IInvoiceResource Invoice { get; private set; }

        public IOrderResource Order { get; private set; }

        public ISubscriptionResource Subscription { get; private set; }

        public IWebhookResource Webhook { get; private set; }

        private Configuration _configuration { get; set; }

        /// <summary>
        /// Update configuration - if null, new values are ignored
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="requestKey"></param>
        /// <param name="apiUrl"></param>
        /// <param name="timeout"></param>
        /// <param name="mpToken"></param>
        /// <param name="accountManagementKey"></param>
        /// <param name="merchantId"></param>
        /// <param name="accountId"></param>
        public void UpdateConfiguration(
            string secretKey = null,
            string requestKey = null,
            string apiUrl = null,
            int? timeout = null,
            string mpToken = null,
            string accountManagementKey = null,
            string merchantId = null,
            string accountId = null)
        {
            this._configuration.SecretKey = secretKey ?? this._configuration.SecretKey;
            this._configuration.AccountId = accountId ?? this._configuration.AccountId;
            this._configuration.MerchantId = merchantId ?? this._configuration.MerchantId;
            this._configuration.RequestKey = requestKey ?? this._configuration.RequestKey;
            this._configuration.AccountManagementKey = accountManagementKey ??this._configuration.AccountManagementKey;
            this._configuration.MpToken = mpToken ?? this._configuration.MpToken;
            this._configuration.Timeout = timeout ?? this._configuration.Timeout;
            this._configuration.ApiUrl = apiUrl ?? this._configuration.ApiUrl;
            this.Configuration = _configuration;
        }

        /// <summary>
        /// Initialize api client
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        private void Initialize(Configuration configuration)
        {
            this.Account = new AccountResource(configuration);
            this.Merchant = new MerchantResource(configuration);
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