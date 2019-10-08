using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCardTokenResponse
    {
        public string Brand { get; set; }

        public string ExpMonth { get; set; }

        public string ExpYear { get; set; }

        public string HolderDocument { get; set; }

        public string HolderName { get; set; }

        public string LastFourDigits { get; set; }

        public string Type { get; set; }
    }
}