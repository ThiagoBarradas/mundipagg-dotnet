using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateTransferSettingsRequest
    {
        public string TransferDay { get; set; }

        public string TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}