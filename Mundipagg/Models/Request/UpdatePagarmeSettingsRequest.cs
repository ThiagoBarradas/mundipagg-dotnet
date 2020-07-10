using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdatePagarmeSettingsRequest
    {
        public string ApiKey { get; set; }

        public string CryptoKey { get; set; }

        public int? Version { get; set; }
    }
}
