using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateAutomaticAnticipationSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Type { get; set; }

        public int VolumePercentage { get; set; }

        public int Delay { get; set; }
    }
}