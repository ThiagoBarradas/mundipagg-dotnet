using MundiPagg.Models;
using MundiPagg.Models.Request;
using MundiPagg.Models.Response;
using MundiPagg.Resources.Interface;
using MundiPagg.Utils;
using System.Net.Http;

namespace MundiPagg.Resources
{
    /// <summary>
    /// Charge manager
    /// </summary>
    public class ChargeResource : BaseResource, IChargeResource
    {
        /// <summary>
        /// Creates a new charge manager
        /// </summary>
        /// <param name="configuration">MundiPagg Api configuration</param>
        public ChargeResource(Configuration configuration) : base(configuration) {}

        /// <summary>
        /// Create new charge
        /// </summary>
        /// <param name="request">Create charge request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> CreateCharge(CreateChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/core/v1/charges";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Get charge data
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> GetCharge(string chargeId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/charges/{chargeId}";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        /// <summary>
        /// List charges
        /// </summary>
        /// <param name="request">List charge request</param>
        /// <returns>Base response with paged charges data</returns>
        public BaseResponse<PagingResponse<GetChargeResponse>> ListCharges(ListChargesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/core/v1/charges";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<PagingResponse<GetChargeResponse>>(method, endpoint, null, query);
        }

        /// <summary>
        /// Update charge metadata
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update metadata request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> UpdateMetadata(string chargeId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/core/v1/charges/{chargeId}/metadata";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Update charge credit card
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update credit card request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> UpdateCreditCard(string chargeId, UpdateCreditCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/core/v1/charges/{chargeId}/credit-card";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Update charge payment method
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update payment method request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> UpdatePaymentMethod(string chargeId, UpdatePaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/core/v1/charges/{chargeId}/payment-method";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Update charge due date
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Update due date request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> UpdateDueDate(string chargeId, UpdateDueDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/core/v1/charges/{chargeId}/due-date";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Capture a charge 
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Capture charge request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> CaptureCharge(string chargeId, CaptureChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/core/v1/charges/{chargeId}/capture";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Cancel a charge 
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <param name="request">Cancel charge request</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> CancelCharge(string chargeId, CancelChargeRequest request)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/core/v1/charges/{chargeId}";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        /// <summary>
        /// Retry a charge 
        /// </summary>
        /// <param name="chargeId">Charge code</param>
        /// <returns>Base response with charge data</returns>
        public BaseResponse<GetChargeResponse> RetryCharge(string chargeId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/core/v1/charges/{chargeId}/retry";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, null);
        }
    }
}
