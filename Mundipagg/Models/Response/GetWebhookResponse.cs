using Mundipagg.Models.Enums;
using Mundipagg.Models.Webhooks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Response
{
    public class GetWebhookResponse : BaseWebhook
    {
        public string Attempts { get; set; }

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

        public DateTime? LastAttempt { get; set; }

        public string ResponseRaw { get; set; }

        public string ResponseStatus { get; set; }

        public WebhookStatusEnum Status { get; set; }

        public string Url { get; set; }
    }
}