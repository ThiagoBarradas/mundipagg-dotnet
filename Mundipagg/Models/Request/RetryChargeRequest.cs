using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RetryChargeRequest
    {
        public bool Capture { get; set; }

        public bool AntifraudEnabled { get; set; }
    }
}
