using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Recipient resource
    /// </summary>
    public interface IRecipientResource : IResource
    {
        /// <summary>
        /// Gets a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: recipient id</param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipient(string recipientId);

        /// <summary>
        /// List recipients
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns BaseResponse<PagingResponse<GetRecipientResponse>> response from the API call</returns>
        BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse> ListRecipients(ListRecipientsRequest request);
    }
}