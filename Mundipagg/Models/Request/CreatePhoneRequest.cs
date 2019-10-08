using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreatePhoneRequest
    {
        public string AreaCode { get; set; }

        public string CountryCode { get; set; }

        public string Number { get; set; }
    }
}