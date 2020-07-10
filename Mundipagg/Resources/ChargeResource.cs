using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class ChargeResource : BaseResource, IChargeResource
    {
        public ChargeResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> GetCharge(string chargeId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges/{chargeId}";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<PagingResponse<GetChargeResponse>, MundipaggErrorsResponse> ListCharges(ListChargesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetChargeResponse>>(method, endpoint, null, query);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/charges/{chargeId}";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/capture";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/confirm-payment";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> RetryCharge(string chargeId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/retry";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/credit-card";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/due-date";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/metadata";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, MundipaggErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/payment-method";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }
    }
}