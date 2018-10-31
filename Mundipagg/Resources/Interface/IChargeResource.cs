using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Charge manager
    /// </summary>
    public interface IChargeResource
    {
        /// <summary>
        /// Create new charge
        /// </summary>
        /// <param name="request">Create charge request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> CreateCharge(CreateChargeRequest request);

        /// <summary>
        /// Get charge data
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> GetCharge(string chargeId);

        /// <summary>
        /// List charges
        /// </summary>
        /// <param name="request">List charge request</param>
        /// <returns>Base response with paged charges data</returns>
        BaseResponse<PagingResponse<GetChargeResponse>> ListCharges(ListChargesRequest request);

        /// <summary>
        /// Update charge metadata
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update metadata request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> UpdateMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Update charge credit card
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update credit card request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> UpdateCreditCard(string chargeId, UpdateCreditCardRequest request);

        /// <summary>
        /// Update charge payment method
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update payment method request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> UpdatePaymentMethod(string chargeId, UpdatePaymentMethodRequest request);

        /// <summary>
        /// Update charge due date
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update due date request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> UpdateDueDate(string chargeId, UpdateDueDateRequest request);

        /// <summary>
        /// Capture charge 
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Capture charge request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> CaptureCharge(string chargeId, CaptureChargeRequest request);

        /// <summary>
        /// Cancel charge 
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Cancel charge request</param>
        /// <returns>Base response with charge data</returns>
        BaseResponse<GetChargeResponse> CancelCharge(string chargeId, CancelChargeRequest request);
    }
}
