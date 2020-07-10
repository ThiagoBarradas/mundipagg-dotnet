using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateMerchantSettingsRequest
    {
        public int? MaximumAccounts { get; set; }

        public bool CheckoutEnabled { get; set; }

        public bool AttemptEnabled { get; set; }

        public bool SubscriptionEnabled { get; set; }

        public bool RenewCardEnabled { get; set; }
    }
}
