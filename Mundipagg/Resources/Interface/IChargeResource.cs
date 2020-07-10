using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;

namespace Mundipagg.Resources.Interface
{
    /// <summary>
    /// Charge manager
    /// </summary>
    public interface IChargeResource : IResource
    {
        /// <summary>
        /// Creates a new charge2
        /// <see cref="https://docs.mundipagg.com/v1/reference#incluir-cobranca-no-pedido"/>
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> GetCharge(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the BaseResponse<GetChargeResponse> response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> RetryCharge(string chargeId);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the BaseResponse<PagingResponse<GetChargeResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetChargeResponse>, MundipaggErrorsResponse> ListCharges(ListChargesRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="idempontencyKey">Required parameter: Idempontency Key</param>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Confirm Charge payment
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request);
       
        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request);
    }
}