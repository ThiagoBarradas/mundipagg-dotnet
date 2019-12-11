using System;

namespace Mundipagg
{
    /// <summary>
    /// Mundipagg Api Client Configuration
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Default api url
        /// </summary>
        private const string API_URL = "https://api.mundipagg.com/core/v1";

        /// <summary>
        /// Default timeout
        /// </summary>
        private const int TIMEOUT = 30000;
        
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Configuration()
        {
            this.ApiUrl = API_URL;
            this.Timeout = TIMEOUT;
        }

        /// <summary>
        /// Constructor with params - try named params to set specific configs
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="requestKey"></param>
        /// <param name="apiUrl"></param>
        /// <param name="timeout"></param>
        /// <param name="mpToken"></param>
        /// <param name="accountManagementKey"></param>
        public Configuration(
            string secretKey = null, 
            string requestKey = null, 
            string apiUrl = null, 
            int? timeout = null,
            string mpToken = null,
            string accountManagementKey = null)
        {
            this.SecretKey = secretKey;
            this.ApiUrl = apiUrl ?? API_URL;
            this.Timeout = timeout ?? TIMEOUT;
            this.RequestKey = requestKey ?? new Guid().ToString();
            this.MpToken = mpToken;
            this.AccountManagementKey = accountManagementKey;
        }

        /// <summary>
        /// Api Url
        /// </summary>
        public string ApiUrl { get; set; }

        /// <summary>
        /// Your secret key, something like sk_xxxxx or sk_test_xxxx
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Request Key to send in Header
        /// </summary>
        public string RequestKey { get; set; }

        /// <summary>
        /// AccountManagementKey
        /// </summary>
        public string AccountManagementKey { get; set; }

        /// <summary>
        /// MpToken
        /// </summary>
        public string MpToken { get; set; }

        /// <summary>
        /// Account Id
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Merchant Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Timeout in milliseconds
        /// </summary>
        public int Timeout { get; set; }
    
        public Configuration Clone()
        {
            return (Configuration) this.MemberwiseClone();
        }
    }
}