using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetBalanceResponse
    {
        public int AvailableAmount { get; set; }

        public string Currency { get; set; }

        public GetRecipientResponse Recipient { get; set; }
    }
}