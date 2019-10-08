using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PagingResponse
    {
        public string Next { get; set; }

        public string Previous { get; set; }

        public int Total { get; set; }
    }
}