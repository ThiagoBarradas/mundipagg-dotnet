namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateBankTransferSettingsRequest
    {

        /// <summary>
        /// Indica se o pagamento com transferência bancária está habilitado
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Banco
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// Gateway responsável pelo processamento do pagamento
        /// </summary>
        public string Gateway { get; set; }
    }
}
