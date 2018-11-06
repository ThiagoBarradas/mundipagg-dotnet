using Mundipagg.Models.Enums;
using Mundipagg.Models.Webhooks;
using System;

namespace Mundipagg.Models.Response
{
    /// <summary>
    /// Get webhook response
    /// </summary>
    public class GetWebhookResponse : BaseWebhook
    {
        #region Public Properties

        /// <summary>
        /// Attempts made/total
        /// </summary>
        public string Attempts { get; set; }

        /// <summary>
        /// Hook event type
        /// </summary>
        public WebhookEventEnum Event
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

        /// <summary>
        /// Last attempt
        /// </summary>
        public DateTime? LastAttempt { get; set; }

        /// <summary>
        /// Server response content
        /// </summary>
        public string ResponseRaw { get; set; }

        /// <summary>
        /// Server response status code
        /// </summary>
        public string ResponseStatus { get; set; }

        /// <summary>
        /// Webhook status
        /// </summary>
        public WebhookStatusEnum Status { get; set; }

        /// <summary>
        /// Url to send
        /// </summary>
        public string Url { get; set; }

        #endregion Public Properties
    }
}