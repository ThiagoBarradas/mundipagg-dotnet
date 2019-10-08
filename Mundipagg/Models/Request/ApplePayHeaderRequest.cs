using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ApplePayHeaderRequest
    {
        public string EphemeralPublicKey { get; set; }

        public string PublicKeyHash { get; set; }

        public string TransactionId { get; set; }
    }
}