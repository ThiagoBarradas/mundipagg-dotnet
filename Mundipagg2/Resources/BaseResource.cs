using Mundipagg.Models;
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
        public BaseResource(Configuration configuration, JsonSerializerSettings jsonSerializerSettings = null)
        {
            this.JsonSerializerSettings = (jsonSerializerSettings == null)
                ? JsonSerializerUtil.SnakeCaseSettings
                : jsonSerializerSettings;
            this.Configuration = configuration;
            this.HttpClientUtil = new HttpClientUtil(this.Configuration, this.JsonSerializerSettings);
        }

        /// <summary>
        /// Mundipagg Api coniguration
        /// </summary>
        protected Configuration Configuration { get; set; }

        /// <summary>
        /// Json serialize settings
        /// </summary>
        protected JsonSerializerSettings JsonSerializerSettings { get; set; }

        /// <summary>
        /// Http client utility
        /// </summary>
        protected IHttpClientUtil HttpClientUtil { get; set; }
    }
}
