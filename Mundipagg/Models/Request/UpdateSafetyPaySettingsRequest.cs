namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateSafetyPaySettingsRequest
    {

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código da loja
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Indica se o pagamento com safety pay está habilitado
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gateway responsável pelo processamento do pagamento
        /// </summary>
        public string Gateway { get; set; }
    }
}
