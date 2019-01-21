using Mundipagg.Models.Enums;

namespace Mundipagg.Models.Webhooks
{
    /// <summary>
    /// Webhook received model
    /// </summary>
    public class WebhookReceived : BaseWebhook
    {
        /// <summary>
        /// Hook event type
        /// </summary>
        public WebhookEventEnum Type
        {
            get
            {
                return this.EventType;
            }
            set
            {
                this.EventType = value;
            }
        }
    }
}