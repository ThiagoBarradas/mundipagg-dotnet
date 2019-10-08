using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListCardsRequest : BaseListRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListCardsRequest(string customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }
    }
}