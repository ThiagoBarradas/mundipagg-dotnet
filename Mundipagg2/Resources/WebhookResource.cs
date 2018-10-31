using Mundipagg.Models;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Mundipagg.Resources
{
    /// <summary>
    /// Webhook manager
    /// </summary>
    public class WebhookResource : BaseResource, IWebhookResource
    {
        /// <summary>
        /// Creates a new webhook manager
        /// </summary>
        /// <param name="configuration">Mundipagg Api configuration</param>
        public WebhookResource(Configuration configuration) : base(configuration) { }

        /// <summary>
        /// Parse webhook received from Mundipagg Api
        /// </summary>
        /// <param name="json">Received json</param>
        /// <returns></returns>
        public WebhookReceived ParseWebhook(string json)
        {
            if (string.IsNullOrWhiteSpace(json) == true)
                throw new NullReferenceException($"{nameof(json)} can not be null or empty");

            return JsonConvert.DeserializeObject<WebhookReceived>(json, JsonSerializerUtil.SnakeCaseSettings);
        }

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="request">List webhooks request</param>
        /// <returns>Base response with paged webhooks data</returns>
        public BaseResponse<PagingResponse<GetWebhookResponse>> ListWebhooks(ListWebhooksRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/hooks";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<PagingResponse<GetWebhookResponse>>(method, endpoint, null, query);
        }

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        public BaseResponse<GetWebhookResponse> GetWebhook(string webhookId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/hooks/{webhookId}";

            return this.HttpClientUtil.SendRequest<GetWebhookResponse>(method, endpoint, null);
        }

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        public BaseResponse<GetWebhookResponse> RetryWebhook(string webhookId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/core/v1/hooks/{webhookId}/retry";

            return this.HttpClientUtil.SendRequest<GetWebhookResponse>(method, endpoint, null);
        }
    }
}
