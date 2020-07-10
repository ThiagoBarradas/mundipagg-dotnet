using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListUsagesRequest : BaseListRequest
    {
        public string Code { get; set; }

        public string ItemId { get; set; }

        public string Mgroup { get; set; }

        public string SubscriptionId { get; set; }
    }
}
