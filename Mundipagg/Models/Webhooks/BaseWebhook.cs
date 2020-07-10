using Mundipagg.Models.Enums;
using Mundipagg.Models.Response;
using Mundipagg.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Webhooks
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseWebhook
    {
        public Account Account { get; set; }

        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Hook content (dynamic)
        /// </summary>
        [JsonIgnore]
        public object Data
        {
            get
            {
                if (this.DataType == null || this.DataJToken == null)
                    return null;

                return this.DataJToken.ToObject(this.DataType);
            }
        }

        /// <summary>
        /// Hook content as Json
        /// </summary>
        public string DataJson
        {
            get
            {
                return (this.Data != null)
                    ? JsonConvert.SerializeObject(this.Data, JsonSerializerUtil.SnakeCaseSettings)
                    : null;
            }
        }

        /// <summary>
        /// Hook content as Newtonsoft JToken
        /// </summary>
        [JsonProperty("data")]
        public JToken DataJToken { get; set; }

        /// <summary>
        /// Type to cast hook content
        /// </summary>
        public Type DataType
        {
            get
            {
                return this.GetDataType(this.EventType);
            }
        }

        /// <summary>
        /// Hook id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Event type as Enum
        /// </summary>
        public WebhookEventEnum EventType => JsonConvert.DeserializeObject<WebhookEventEnum>($"\"{this._eventTypeAsString.Replace(".","").Replace("_", "") }\"");

        /// <summary>
        /// Hook event type
        /// </summary>
        protected string _eventTypeAsString { get; set; }

        /// <summary>
        /// Get data type from event type
        /// </summary>
        /// <param name="type">Webhhok event type</param>
        /// <returns></returns>
        protected Type GetDataType(WebhookEventEnum type)
        {
            switch (type)
            {
                case WebhookEventEnum.CustomerCreated:
                case WebhookEventEnum.CustomerUpdated:
                    return typeof(GetCustomerResponse);

                case WebhookEventEnum.ChargeCreated:
                case WebhookEventEnum.ChargeOverpaid:
                case WebhookEventEnum.ChargePaid:
                case WebhookEventEnum.ChargePartialCanceled:
                case WebhookEventEnum.ChargePaymentFailed:
                case WebhookEventEnum.ChargePending:
                case WebhookEventEnum.ChargeRefunded:
                case WebhookEventEnum.ChargeUnderpaid:
                case WebhookEventEnum.ChargeUpdated:
                case WebhookEventEnum.ChargeProcessing:
                    return typeof(GetChargeResponse);

                case WebhookEventEnum.OrderCanceled:
                case WebhookEventEnum.OrderClosed:
                case WebhookEventEnum.OrderPaid:
                case WebhookEventEnum.OrderCreated:
                case WebhookEventEnum.OrderPaymentFailed:
                case WebhookEventEnum.OrderUpdated:
                    return typeof(GetOrderResponse);

                case WebhookEventEnum.SubscriptionCanceled:
                case WebhookEventEnum.SubscriptionCreated:
                case WebhookEventEnum.SubscriptionDeleted:
                case WebhookEventEnum.SubscriptionUpdated:
                    return typeof(GetSubscriptionResponse);

                case WebhookEventEnum.InvoiceCanceled:
                case WebhookEventEnum.InvoiceCreated:
                case WebhookEventEnum.InvoicePaid:
                case WebhookEventEnum.InvoicePaymentFailed:
                case WebhookEventEnum.InvoiceUpdated:
                    return typeof(GetInvoiceResponse);
                    
                default:
                    return null;
            }
        }
    }
}