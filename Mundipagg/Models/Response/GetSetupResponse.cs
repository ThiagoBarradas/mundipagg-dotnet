using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetSetupResponse
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        public string Status { get; set; }
    }
}