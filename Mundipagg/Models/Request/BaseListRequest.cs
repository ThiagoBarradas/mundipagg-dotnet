using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    /// <summary>
    /// Base list request
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseListRequest
    {
        public BaseListRequest()
        {
            this.Page = 1;
            this.Size = 10;
        }

        /// <summary>
        /// Page number
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        public int Size { get; set; }
    }
}