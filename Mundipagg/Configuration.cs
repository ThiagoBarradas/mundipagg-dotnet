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
        private readonly string API_URL = "https://api.mundipagg.com/core/v1";

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
        /// Constructor with api url and timeout
        /// </summary>
        /// <param name="apiUrl"></param>
        /// <param name="timeout"></param>
        public Configuration(string apiUrl, int? timeout = TIMEOUT)
        {
            this.ApiUrl = apiUrl;
            this.Timeout = timeout ?? TIMEOUT;
        }

        /// <summary>
        /// Creates a new configuration using default values for api url and timeout
        /// </summary>
        /// <param name="secretKey">Your secret key, something like sk_xxxxx or sk_test_xxxx</param>
        public Configuration(string secretKey)
        {
            this.SecretKey = secretKey;
            this.ApiUrl = API_URL;
            this.Timeout = TIMEOUT;
        }

        /// <summary>
        /// Creates a new configuration using default values for api url and timeout
        /// </summary>
        /// <param name="secretKey">Your secret key, something like sk_xxxxx or sk_test_xxxx</param>
        /// <param name="requestKey">some identifier</param>
        public Configuration(string secretKey, string requestKey)
        {
            this.SecretKey = secretKey;
            this.ApiUrl = API_URL;
            this.Timeout = TIMEOUT;
            this.RequestKey = requestKey;
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

        public string AccountId { get; set; }

        /// <summary>
        /// Timeout in milliseconds
        /// </summary>
        public int Timeout { get; set; }
    }
}