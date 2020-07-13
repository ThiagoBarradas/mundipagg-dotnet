using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateWebhookSettingsRequest
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string[] Events { get; set; }

        public string Status { get; set; }

        public int Interval { get; set; }

        public int MaxAttempts { get; set; }

        public string AuthenticationType { get; set; }

        [JsonProperty("basic_authentication")]
        public UpdateWebhookBasicAuthenticationRequest WebhookAuthentication { get; set; }

        public string Version { get; set; }
    }
}
