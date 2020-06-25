namespace Mundipagg.Models.Request
{
    /// <summary>
    /// Configurações de cancelamento garantido
    /// </summary>
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateGuaranteedCancellationSettingsRequest
    {
        /// <summary>
        /// Indica se está habilitado
        /// </summary>
        public bool? Enabled { get; set; }
    }
}