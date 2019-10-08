using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateChargeCardRequest
    {
        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public bool Recurrence { get; set; }

        public bool UpdateSubscription { get; set; }
    }
}