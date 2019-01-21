using Mundipagg.Utils;
using Newtonsoft.Json;

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
        public BaseResource(Configuration configuration)
        {
            this.Configuration = configuration;
            this.HttpClientUtil = new RestSharpClientUtil(this.Configuration);
        }

        /// <summary>
        /// Mundipagg Api coniguration
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Http client utility
        /// </summary>
        protected IHttpClientUtil HttpClientUtil { get; set; }
    }
}