using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetGatewayResponseResponse
    {
        public string Code { get; set; }

        public List<GetGatewayErrorResponse> Errors { get; set; }
    }
}