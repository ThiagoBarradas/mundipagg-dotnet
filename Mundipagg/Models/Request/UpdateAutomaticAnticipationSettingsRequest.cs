using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateAutomaticAnticipationSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Type { get; set; }

        public int VolumePercentage { get; set; }

        public int Delay { get; set; }

        public List<int> Days { get; set; }
    }
}