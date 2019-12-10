using Mundipagg.Models.Enums;
using Mundipagg.Models.Webhooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Response
{
    /// <summary>
    /// Get webhook response
    /// </summary>
    public class GetWebhookResponse : BaseWebhook
    {
        /// <summary>
        /// Attempts made/total
        /// </summary>
        public string Attempts { get; set; }

        /// <summary>
        /// Hook event type
        /// </summary>
        [JsonProperty("event")]
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
    }
}