namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdatePagarmeSettingsRequest
    {

        /// <summary>
        /// Chave da API
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Chave de criptografia
        /// </summary>
        public string CryptoKey { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Versão da Pagar.me
        /// </summary>
        public int? Version { get; set; }
    }
}
