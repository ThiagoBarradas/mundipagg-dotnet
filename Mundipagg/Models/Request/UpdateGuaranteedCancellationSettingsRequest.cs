using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateGuaranteedCancellationSettingsRequest
    {
        public bool? Enabled { get; set; }
    }
}