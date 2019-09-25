namespace Mundipagg.Models.Request
{
    public class CreateMerchantRequest
    {
        public string Name { get; set; }

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
