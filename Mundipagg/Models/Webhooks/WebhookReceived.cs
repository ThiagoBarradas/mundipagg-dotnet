using Newtonsoft.Json;

namespace Mundipagg.Models.Webhooks
{
    /// <summary>
    /// Webhook received model
    /// </summary>
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