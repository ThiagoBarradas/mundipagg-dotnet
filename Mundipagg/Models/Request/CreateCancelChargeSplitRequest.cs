using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeSplitRequest
    {
        public string Type { get; set; }

        public int Amount { get; set; }

        public string RecipientId { get; set; }

        public CreateSplitOptionsRequest Options { get; set; } = new CreateSplitOptionsRequest();
    }
}