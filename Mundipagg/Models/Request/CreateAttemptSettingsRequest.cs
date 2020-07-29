using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateAttemptSettingsRequest
    {
        public string Type { get; set; }

        public double[] Intervals { get; set; }
    }
}
