using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePriceBracketRequest
    {
        public int? EndQuantity { get; set; }

        public int? OveragePrice { get; set; }

        public int Price { get; set; }

        public int StartQuantity { get; set; }
    }
}