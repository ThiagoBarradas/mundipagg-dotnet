using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetMerchantResponse
    {
        public string Id { get; set; }

        public string AccountManagementKey { get; set; }

        public string Name { get; set; }

        public string ClientId { get; set; }

        public DateTime GetdAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Status { get; set; }

        public GetMerchantSettingsResponse MerchantSettings { get; set; }
    }

    public class GetMerchantSettingsResponse
    {
        public DateTime UpdatedAt { get; set;  }

        public bool? CheckoutEnabled { get; set; }

        public bool? AttemptEnabled { get; set; }

        public bool? SubscriptionEnabled { get; set; }

        public bool? RenewCardEnabled { get; set; }

        public int? MaximumAccounts { get; set; }
    }
}
