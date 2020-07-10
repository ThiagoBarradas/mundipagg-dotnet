using Mundipagg.Models.Response;
using RestSharp.Easy;
using RestSharp.Easy.Interfaces;
using RestSharp.Easy.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Mundipagg.Resources
{
    /// <summary>
    /// Base resource
    /// </summary>
    public abstract class BaseResource
    {
        /// <summary>
        /// Creates a new base resource with Mundipagg Api coniguration
        /// </summary>
        /// <param name="configuration">Mundipagg Api coniguration</param>
        public BaseResource(Configuration configuration, string authMode = "sk")
        {
            this.Configuration = configuration;
        }


        private Configuration _configuration { get; set; }

        /// <summary>
        /// Mundipagg Api coniguration
        /// </summary>
        public Configuration Configuration
        {
            get
            {
                return _configuration;
            }
            set
            {
                this._configuration = value;

                var defaultHeaders = new Dictionary<string, string>()
                { };

                var additionalLog = new Dictionary<string, string>()
                {
                    { "AccountId", this._configuration.AccountId },
                    { "MerchantId", this._configuration.MerchantId }
                };

                this.EasyRestClient = new EasyRestClient(value.ApiUrl,
                    defaultHeaders,
                    SerializeStrategyEnum.SnakeCase,
                    value.Timeout,
                    value.RequestKey,
                    additionalLog,
                    "Mundipagg Dotnet ApiClient https://github.com/ThiagoBarradas/mundipagg-dotnet",
                    enableLog: value.EnableLog);
            }
        }

        /// <summary>
        /// Http client utility
        /// </summary>
        protected IEasyRestClient EasyRestClient { get; set; }

        /// <summary>
        /// Mapper Idempotency Key as Header
        /// </summary>
        protected Dictionary<string, string> GetIdempontecyAsHeader(string idempontencyKey)
        {
            var headers = new Dictionary<string, string>();

            if (!string.IsNullOrWhiteSpace(idempontencyKey))
            {
                headers.Add("Idempotency-key", idempontencyKey);
            }

            return headers;
        }

        public BaseResponse<TSuccess, MundipaggErrorsResponse> SendRequest<TSuccess>(
            HttpMethod method,
            string endpoint,
            object body = null,
            Dictionary<string, string> query = null,
            Dictionary<string, string> headers = null,
            string authMode = "sk")
            where TSuccess : class, new()
        {
            if (authMode == null)
            {
                authMode = "sk";
            }

            var user = "";

            switch (authMode)
            {
                case "amk":
                    user = this.Configuration.AccountManagementKey;
                    break;
                case "token":
                    user = this.Configuration.MpToken;
                    break;
                default:
                    user = this.Configuration.SecretKey;
                    break;
            }

            var basic = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user}:"));

            if (headers == null)
            {
                headers = new Dictionary<string, string>();
            }

            headers.Add("Authorization", $"Basic {basic}");

            return this.EasyRestClient.SendRequest<TSuccess, MundipaggErrorsResponse>
                (method, endpoint, body, query, headers);
        }
    }
}