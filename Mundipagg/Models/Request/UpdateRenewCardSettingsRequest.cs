using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateRenewCardSettingsRequest
    {
        public bool? RenewOnPaymentEnabled { get; set; }

        public bool? ManualRenewEnabled { get; set; }
    }
}
