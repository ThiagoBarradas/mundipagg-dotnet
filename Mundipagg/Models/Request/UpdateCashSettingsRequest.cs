namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateCashSettingsRequest
    {

        /// <summary>
        /// Indica se o meio de pagamento Cash está habilitado
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Id do comerciante
        /// </summary>
        public string MerchantId { get; set; }
    }
}

