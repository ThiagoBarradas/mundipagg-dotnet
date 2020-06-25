namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateRenewCardSettingsRequest
    {

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Id da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Indica se a renovação no ato do pagamento
        /// está habilitada
        /// </summary>
        public bool RenewOnPaymentEnabled { get; set; }

        /// <summary>
        /// Indica se a operação manual através
        /// do endpoint de renovação está habilitado
        /// </summary>
        public bool ManualRenewEnabled { get; set; }
    }
}
