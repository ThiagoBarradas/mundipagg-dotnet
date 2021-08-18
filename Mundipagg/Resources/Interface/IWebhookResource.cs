using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
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
        /// Get webhook data
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<PagingResponse<GetWebhookResponse>, MundipaggErrorsResponse> ListWebhooks(ListWebhooksRequest request);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        Task<BaseResponse<PagingResponse<GetWebhookResponse>, MundipaggErrorsResponse>> ListWebhooksAsync(ListWebhooksRequest request);

        /// <summary>
        /// Get webhook data
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, MundipaggErrorsResponse> GetWebhook(string webhookId);

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        Task<BaseResponse<GetWebhookResponse, MundipaggErrorsResponse>> GetWebhookAsync(string webhookId);

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId">Webhook id</param>
        /// <returns>Base response with webhook data</returns>
        BaseResponse<GetWebhookResponse, MundipaggErrorsResponse> RetryWebhook(string webhookId);

        /// <summary>
        /// Retry send webhook
        /// </summary>
        /// <param name="webhookId"></param>
        /// <returns></returns>
        Task<BaseResponse<GetWebhookResponse, MundipaggErrorsResponse>> RetryWebhookAsync(string webhookId);
    }
}