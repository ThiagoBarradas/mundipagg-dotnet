using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Webhooks
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Account
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string MerchantId { get; set; }
    }
}