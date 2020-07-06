namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateMerchantSettingsRequest
    {
        /// <summary>
        /// Código
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Número máximo de contas
        /// </summary>
        public int? MaximumAccounts { get; set; }

        /// <summary>
        /// Indica se o cliente tem checkout liberado
        /// </summary>
        public bool CheckoutEnabled { get; set; }

        /// <summary>
        /// Indica se o cliente tem retentativa liberada 
        /// </summary>
        public bool AttemptEnabled { get; set; }

        /// <summary>
        /// Indica se o cliente tem assinatura liberada 
        /// </summary>
        public bool SubscriptionEnabled { get; set; }

        /// <summary>
        /// Indica se o cliente tem renovação de cartão liberada 
        /// </summary>
        public bool RenewCardEnabled { get; set; }
    }
}
