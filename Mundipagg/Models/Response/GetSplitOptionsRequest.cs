using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetSplitOptionsRequest
    {
        public bool Liable { get; set; }

        public bool ChargeProcessingFee { get; set; }

        public bool ChargeRemainderFee { get; set; }
    }
}
