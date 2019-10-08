using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCheckoutCardInstallmentOptionRequest
    {
        public int Number { get; set; }

        public int Total { get; set; }
    }
}