﻿using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using RestSharp.Easy.Models;
using System.Threading.Tasks;

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
        /// Creates a new charge2
        /// <see cref="https://docs.mundipagg.com/v1/reference#incluir-cobranca-no-pedido"/>
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> CreateChargeAsync(string idempotencyKey, CreateChargeRequest request);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> GetCharge(string chargeId);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> GetChargeAsync(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the BaseResponse<GetChargeResponse> response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> RetryCharge(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the BaseResponse<GetChargeResponse> response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> RetryChargeAsync(string chargeId);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the BaseResponse<PagingResponse<GetChargeResponse>> response from the API call</return>
        BaseResponse<PagingResponse<GetChargeResponse>, MundipaggErrorsResponse> ListCharges(ListChargesRequest request);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <return>Returns the BaseResponse<PagingResponse<GetChargeResponse>> response from the API call</return>
        Task<BaseResponse<PagingResponse<GetChargeResponse>, MundipaggErrorsResponse>> ListChargesAsync(ListChargesRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> UpdateChargeMetadataAsync(string chargeId, UpdateMetadataRequest request);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> CancelChargeAsync(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="idempontencyKey">Required parameter: Idempontency Key</param>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="idempontencyKey">Required parameter: Idempontency Key</param>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> CaptureChargeAsync(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null);

        /// <summary>
        /// Confirm Charge payment
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null);

        /// <summary>
        /// Confirm Charge payment
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> ConfirmChargePaymentAsync(string chargeId, CreateConfirmPaymentRequest request = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> UpdateChargeDueDateAsync(string chargeId, UpdateChargeDueDateRequest request);

        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> UpdateChargeCardAsync(string chargeId, UpdateChargeCardRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> UpdateChargePaymentMethodAsync(string chargeId, UpdateChargePaymentMethodRequest request);
        
        /// <summary>
        /// Retry a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Configuration to retry a charge</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call</returns>
        BaseResponse<GetChargeResponse, MundipaggErrorsResponse> RetryCharge(string chargeId, RetryChargeRequest request);

        /// <summary>
        /// Retry a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Configuration to retry a charge</param>
        /// <returns>Returns the Models.GetChargeResponse response from the API call</returns>
        Task<BaseResponse<GetChargeResponse, MundipaggErrorsResponse>> RetryChargeAsync(string chargeId, RetryChargeRequest request);
    }
}