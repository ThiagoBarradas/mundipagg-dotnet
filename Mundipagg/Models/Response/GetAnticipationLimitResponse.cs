using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetAnticipationLimitResponse
    {
        public int Amount { get; set; }

        public int AnticipationFee { get; set; }
    }
}