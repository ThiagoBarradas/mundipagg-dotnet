using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

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
        BaseResponse<GetMerchantResponse> GetMerchant(string merchantId);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse> CreateMerchant(CreateMerchantRequest request);

        /// <summary>
        /// Cretes a new merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<GetMerchantResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request);

    }
}