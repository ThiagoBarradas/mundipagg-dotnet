using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateDiscountRequest
    {
        public int? Cycles { get; set; }

        public string Description { get; set; }

        public string DiscountType { get; set; }

        public string ItemId { get; set; }

        public double Mvalue { get; set; }
    }
}