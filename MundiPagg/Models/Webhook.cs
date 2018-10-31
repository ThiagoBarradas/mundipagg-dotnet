using Mundipagg.Models.Enums;
using System;

namespace Mundipagg.Models
{
    /// <summary>
    /// Webhook model
    /// </summary>
    public class Webhook : BaseWebhook
    {
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
        /// Webhook status
        /// </summary>
        public WebhookStatusEnum Status { get; set; }

        /// <summary>
        /// Url to send
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Attempts made/total
        /// </summary>
        public string Attempts { get; set; }

        /// <summary>
        /// Last attempt
        /// </summary>
        public DateTime? LastAttempt { get; set; }

        /// <summary>
        /// Server response status code
        /// </summary>
        public string ResponseStatus { get; set; }

        /// <summary>
        /// Server response content
        /// </summary>
        public string ResponseRaw { get; set; }
    }
}