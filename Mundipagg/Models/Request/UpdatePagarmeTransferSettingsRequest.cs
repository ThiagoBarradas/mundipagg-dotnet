namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdatePagarmeTransferSettingsRequest
    {

        /// <summary>
        /// Indica se o recebedor receberá seus pagamentos automaticamente
        /// </summary>
        public bool TransferEnabled { get; set; }

        /// <summary>
        /// Indica a frequência das transferências automáticas para a conta do recebedor
        /// </summary>
        public string TransferInterval { get; set; }

        /// <summary>
        /// Indica o dia em que ocorrerá as transferências automáticas
        /// </summary>
        public int? TransferDay { get; set; }
    }
}
