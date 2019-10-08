using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Commons
{
    /// <summary>
    /// Pagination model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Paging
    {
        /// <summary>
        /// Next page url
        /// </summary>
        public string Next { get; set; }

        /// <summary>
        /// Previous page url
        /// </summary>
        public string Previous { get; set; }

        /// <summary>
        /// Items total
        /// </summary>
        public int Total { get; set; }
    }
}