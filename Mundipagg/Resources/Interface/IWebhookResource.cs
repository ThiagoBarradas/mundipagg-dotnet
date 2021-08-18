using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Models.Webhooks;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

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
        /// <returns>Webhook object</returns>
        WebhookReceived ParseWebhook(string json);

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="request">List webhooks request</param>
        /// <returns>Base response with paged webhooks data</returns>
        BaseResponse<PagingResponse<GetWebhookResponse>, MundipaggErrorsResponse> ListWebhooks(ListWebhooksRequest request);

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="request">List webhooks request</param>
        /// <returns>Base response with paged webhooks data</returns>
        Task<BaseResponse<PagingResponse<GetWebhookResponse>, MundipaggErrorsResponse>> ListWebhooksAsync(ListWebhooksRequest request);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, MundipaggErrorsResponse> GetWebhook(string webhookId);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        Task<BaseResponse<GetWebhookResponse, MundipaggErrorsResponse>> GetWebhookAsync(string webhookId);

        // <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, MundipaggErrorsResponse> RetryWebhook(string webhookId);

        // <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        Task<BaseResponse<GetWebhookResponse, MundipaggErrorsResponse>> RetryWebhookAsync(string webhookId);
    }
}