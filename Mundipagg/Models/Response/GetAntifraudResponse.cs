using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetAntifraudResponse
    {
        public string Status { get; set; }

        public string ReturnCode { get; set; }

        public string ReturnMessage { get; set; }
    }
}