using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateSplitOptionsRequest
    {
        public bool? Liable { get; set; }

        public bool? ChargeProcessingFee { get; set; }

        public bool? ChargeRemainderFee { get; set; }
    }
}