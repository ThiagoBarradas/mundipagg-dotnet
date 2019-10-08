using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetAnticipationLimitsResponse
    {
        public GetAnticipationLimitResponse Max { get; set; }

        public GetAnticipationLimitResponse Min { get; set; }
    }
}