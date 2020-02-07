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

        public BaseResponse<GetChargeResponse, ErrorsResponse> GetCharge(string chargeId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges/{chargeId}";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<ListChargesResponse, ErrorsResponse> ListCharges(ListChargesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges";
            var query = request.ToDictionary();

            return this.SendRequest<ListChargesResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> CancelCharge(string idempotencyKey, string chargeId, CreateCancelChargeRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/charges/{chargeId}";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/capture";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/confirm-payment";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> CreateCharge(string idempotencyKey, CreateChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> RetryCharge(string chargeId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/retry";

            return this.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/credit-card";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/due-date";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/metadata";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse, ErrorsResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/payment-method";

            return this.SendRequest<GetChargeResponse>(method, endpoint, request);
        }
    }
}