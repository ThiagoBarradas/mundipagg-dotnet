using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetGatewayRecipientResponse
    {
        public string Gateway { get; set; }

        public string Pgid { get; set; }

        public string Status { get; set; }
        
        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }
    }
}