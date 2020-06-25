namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateBoletoSettingsRequest
    {

        /// <summary>
        /// Indica se o pagamento com boleto esta habilitado
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Banco
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// Instruções do boleto
        /// </summary>
        public string Instructions { get; set; }

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

        /// <summary>
        /// Vencimento do Boleto
        /// </summary>
        public int? DueDays { get; set; }

        /// <summary>
        /// Permite que uma cobrança de boleto que esteja 'canceled'
        /// Tenha sua transação atualizada conforme a notificação que está vindo na requisição
        /// </summary>
        public bool? AllowChargeRecovery { get; set; }
    }
}
