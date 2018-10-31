using MundiPagg.Models;
using MundiPagg.Models.Request;
using MundiPagg.Models.Response;

namespace MundiPagg.Resources.Interface
{
    /// <summary>
    /// Webhook manager
    /// </summary>
    public interface IWebhookResource
    {
        /// <summary>
        /// Parse webhook received from MundiPagg Api
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