namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateCreditCardSettingsRequest
    {

        /// <summary>
        /// Indica se o pagamento com cartão de crédito está habilitado
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
        /// Gateway responsável pelo processamento do pagamento
        /// </summary>
        public string Gateway { get; set; }
    }
}
