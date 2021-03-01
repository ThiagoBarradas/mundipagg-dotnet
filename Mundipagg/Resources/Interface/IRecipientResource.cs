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
    }
}