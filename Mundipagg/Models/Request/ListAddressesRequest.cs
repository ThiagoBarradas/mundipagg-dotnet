using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListAddressesRequest : BaseListRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListAddressesRequest(string customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }
    }
}