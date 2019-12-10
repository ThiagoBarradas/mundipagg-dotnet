using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ApplePayRequest
    {
        public string Data { get; set; }

        public ApplePayHeaderRequest Header { get; set; }

        public string MerchantIdentifier { get; set; }

        public string Signature { get; set; }

        public string Version { get; set; }
    }
}