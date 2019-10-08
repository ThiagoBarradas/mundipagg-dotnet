using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Webhooks
{
    /// <summary>
    /// Account model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Account
    {
        /// <summary>
        /// Account id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        public string Name { get; set; }
    }
}