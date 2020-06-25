namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateMundiPaggSettingsRequest
    {

        /// <summary>
        /// Chave da empresa
        /// </summary>
        public string MerchantKey { get; set; }

        /// <summary>
        /// Código da loja 
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código da empresa
        /// </summary>
        public string MerchantId { get; set; }
    }
}
