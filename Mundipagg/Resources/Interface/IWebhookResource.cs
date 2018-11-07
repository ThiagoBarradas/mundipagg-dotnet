using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Models.Webhooks;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Webhook manager
    /// </summary>
    public interface IWebhookResource : IResource
    {
        /// <summary>
        /// Parse webhook received from Mundipagg Api
        /// </summary>
        /// <param name="json">Received json</param>
        /// <returns></returns>
        WebhookReceived ParseWebhook(string json);

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="request">List webhooks request</param>
        /// <returns>Base response with paged webhooks data</returns>
        BaseResponse<PagingResponse<GetWebhookResponse>> ListWebhooks(ListWebhooksRequest request);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse> GetWebhook(string webhookId);

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse> RetryWebhook(string webhookId);
    }
}