using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateMerchantRequest
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string ClientId { get; set; }

        public CreateMerchantSettingsRequest MerchantSettings { get; set; }
    }

    public class CreateMerchantSettingsRequest
    {
        public bool? CheckoutEnabled { get; set; }

        public bool? AttemptEnabled { get; set; }

        public bool? SubscriptionEnabled { get; set; }

        public bool? RenewCardEnabled { get; set; }

        public int? MaximumAccounts { get; set; }
    }
}
