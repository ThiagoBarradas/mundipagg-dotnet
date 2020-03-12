using Mundipagg.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateMerchantStatusRequest
    {
        public MerchantStatusEnum Status { get; set; }
    }
}