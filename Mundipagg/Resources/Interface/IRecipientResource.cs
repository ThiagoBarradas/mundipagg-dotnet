using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

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
        /// Gets a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: recipient id</param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> GetRecipientAsync(string recipientId);

        /// <summary>
        /// Create a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> CreateRecipient(CreateRecipientRequest request);

        /// <summary>
        /// Create a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> CreateRecipientAsync(CreateRecipientRequest request);

        /// <summary>
        /// Update a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateRecipient(string recipientId, UpdateRecipientRequest request);

        /// <summary>
        /// Update a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateRecipientAsync(string recipientId, UpdateRecipientRequest request);

        /// <summary>
        /// Update a recipient's transfer settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateTransferSettings(string recipientId, UpdateTransferSettingsRequest request);

        /// <summary>
        /// Update a recipient's transfer settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateTransferSettingsAsync(string recipientId, UpdateTransferSettingsRequest request);

        /// <summary>
        /// Update a recipient's automatic anticipation settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateAutomaticAnticipationSettings(string recipientId, UpdateAutomaticAnticipationSettingsRequest request);

        /// <summary>
        /// Update a recipient's automatic anticipation settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateAutomaticAnticipationSettingsAsync(string recipientId, UpdateAutomaticAnticipationSettingsRequest request);
        
        /// <summary>
        /// Update a recipient's automatic anticipation settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateDefaultBankAccount(string recipientId, UpdateRecipientDefaultBankAccountRequest request);

        /// <summary>
        /// Update a recipient's automatic anticipation settings
        /// </summary>
        /// <param name="recipientId"></param>
        /// <param name="request"></param>
        /// <return>Returns BaseResponse<GetRecipientResponse> response from the API call</return>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> UpdateDefaultBankAccountAsync(string recipientId, UpdateRecipientDefaultBankAccountRequest request);

        /// <summary>
        /// List recipients
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns BaseResponse<PagingResponse<GetRecipientResponse>> response from the API call</returns>
        BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse> ListRecipients(ListRecipientsRequest request);

        /// <summary>
        /// List recipients
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns BaseResponse<PagingResponse<GetRecipientResponse>> response from the API call</returns>
        Task<BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse>> ListRecipientsAsync(ListRecipientsRequest request);

        /// <summary>
        /// Import a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns BaseResponse<GetRecipientResponse> response from the API call</returns>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> ImportRecipient(CreateImportRecipientRequest request);

        /// <summary>
        /// Import a recipient
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns BaseResponse<GetRecipientResponse> response from the API call</returns>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> ImportRecipientAsync(CreateImportRecipientRequest request);

        /// <summary>
        /// Gets a recipient by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns BaseResponse<GetRecipientResponse> response from the API call</returns>
        BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipientByCode(string code);

        /// <summary>
        /// Gets a recipient by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Returns BaseResponse<GetRecipientResponse> response from the API call</returns>
        Task<BaseResponse<GetRecipientResponse, MundipaggErrorsResponse>> GetRecipientByCodeAsync(string code);
    }
}