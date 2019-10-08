using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateSplitRequest
    {
        public int Amount { get; set; }

        public CreateSplitOptionsRequest Options { get; set; }

        public string RecipientId { get; set; }

        public string Type { get; set; }
    }
}