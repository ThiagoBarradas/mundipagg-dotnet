namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateAttemptSettingsRequest
    {

        /// <summary>
        /// Código
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Tipo da Retentativa
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Intervalos de horas entre as retentativas
        /// </summary>
        public double[] Intervals { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
    }
}
