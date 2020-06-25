namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateOrderSettingsRequest
    {

        /// <summary>
        /// Identifica se pedidos Multimeios estão habiltiados para a conta
        /// </summary>
        public bool MultiPaymentsEnabled { get; set; }

        /// <summary>
        /// Identifica se pedidos com MultiCompradores estão habiltiados para a conta
        /// </summary>
        public bool MultiBuyersEnabled { get; set; }

        /// <summary>
        /// Identifica se pedidos abertos estão liberados para a conta
        /// </summary>
        public bool OpenOrdersEnabled { get; set; }

        /// <summary>
        /// Id da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Id do comerciante
        /// </summary>
        public string MerchantId { get; set; }
    }
}
