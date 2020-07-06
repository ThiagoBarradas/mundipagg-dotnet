using Newtonsoft.Json;

namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateWebhookSettingsRequest
    {
        /// <summary>
        /// Código
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Eventos
        /// </summary>
        public string[] Events { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Intervalo na tentativa
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// Quantidade máxima de tentativas
        /// </summary>
        public int MaxAttempts { get; set; }

        /// <summary>
        /// Tipo de autenticação
        /// </summary>
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Código da conta
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Código do cliente
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// Dados de autenticação webhook
        /// </summary>
        [JsonProperty("basic_authentication")]
        public UpdateWebhookAuthenticationRequest WebhookAuthentication { get; set; }

        public string Version { get; set; }
    }
}
