using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetOrderItemResponse
    {
        public int Amount { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public GetSellerResponse GetSellerResponse { get; set; }

        public string Id { get; set; }

        public int Quantity { get; set; }
    }
}