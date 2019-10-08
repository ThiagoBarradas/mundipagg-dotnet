using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetCheckoutCardInstallmentOptionsResponse
    {
        public string Number { get; set; }

        public int Total { get; set; }
    }
}