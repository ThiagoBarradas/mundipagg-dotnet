namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateSubscriptionSettingsRequest
    {

        /// <summary>
        /// Indica se assinatura está habilitada
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Id da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Id do comerciante
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Vencimento do Boleto
        /// </summary>
        public int? BoletoDueDays { get; set; }

        /// <summary>
        /// Indica se o cliente assina o relatório de usos
        /// </summary>
        public bool? UsageReportEnabled { get; set; }
    }
}
