using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Webhooks
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class WebhookReceived : BaseWebhook
    {
        [JsonProperty("type")]
        public string EventTypeAsString
        {
            get
            {
                return this._eventTypeAsString;
            }
            set
            {
                this._eventTypeAsString = value;
            }
        }
    }
}