using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateOrderSettingsRequest
    {
        public bool MultiPaymentsEnabled { get; set; }

        public bool MultiBuyersEnabled { get; set; }

        public bool OpenOrdersEnabled { get; set; }
    }
}
