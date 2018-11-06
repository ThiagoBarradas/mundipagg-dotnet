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
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request);

        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> CreateCharge(CreateChargeRequest request);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> GetCharge(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> RetryCharge(string chargeId);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        BaseResponse<ListChargesResponse> GetCharges(ListChargesRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> CancelCharge(string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> CaptureCharge(string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: </param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse> ConfirmPayment(string chargeId, CreateConfirmPaymentRequest request = null);
    }
}