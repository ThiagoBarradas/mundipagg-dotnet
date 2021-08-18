using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Merchant manager
    /// </summary>
    public interface IMerchantResource : IResource
    {
        /// <summary>
        /// Get merchant info
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> GetMerchant(string merchantId);

        /// <summary>
        /// Get merchant info
        /// </summary>
        /// <param name="merchantId"></param>
        /// <returns></returns>
        Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> GetMerchantAsync(string merchantId);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> CreateMerchant(CreateMerchantRequest request);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> CreateMerchantAsync(CreateMerchantRequest request);

        /// <summary>
        /// Update a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request);

        /// <summary>
        /// Update a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantAsync(string merchantId, UpdateMerchantRequest request);

        /// <summary>
        /// Update status of a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchantStatus(string merchantId, UpdateMerchantStatusRequest request);

        /// <summary>
        /// Update status of a merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantStatusAsync(string merchantId, UpdateMerchantStatusRequest request);

        /// <summary>
        /// Update settings of a Merchant
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchantSettings(string merchantId, UpdateMerchantSettingsRequest request);
        
        /// <summary>
        /// Update settings of a Merchant
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantSettingsAsync(string merchantId, UpdateMerchantSettingsRequest request);
    }
}