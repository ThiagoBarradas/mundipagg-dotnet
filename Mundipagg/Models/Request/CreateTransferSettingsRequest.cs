using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateTransferSettingsRequest
    {
        public int TransferDay { get; set; }

        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}