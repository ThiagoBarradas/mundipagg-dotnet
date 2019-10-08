using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetTokenResponse
    {
        public GetCardTokenResponse Card { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ExpiresAt { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }
    }
}