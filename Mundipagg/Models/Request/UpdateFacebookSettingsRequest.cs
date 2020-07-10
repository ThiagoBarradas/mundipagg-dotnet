using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateFacebookSettingsRequest
    {
        public long? AppId { get; set; }

        public string AppSecret { get; set; }

        public string[] Permissions { get; set; }
    }
}
