using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetPhonesResponse
    {
        public GetPhoneResponse HomePhone { get; set; }

        public GetPhoneResponse MobilePhone { get; set; }
    }
}