namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateNotificationSettingsRequest
    {

        /// <summary>
        /// Indica se aviso está habilitado
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Id da Conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Id do comerciante
        /// </summary>
        public string MerchantId { get; set; }
    }
}
