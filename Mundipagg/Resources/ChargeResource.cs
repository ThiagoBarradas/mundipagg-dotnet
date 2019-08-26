using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class ChargeResource : BaseResource, IChargeResource
    {
        public ChargeResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetChargeResponse> GetCharge(string chargeId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges/{chargeId}";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<ListChargesResponse> ListCharges(ListChargesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/charges";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListChargesResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetChargeResponse> CancelCharge(string chargeId, CreateCancelChargeRequest request = null)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/charges/{chargeId}";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> CaptureCharge(string idempotencyKey, string chargeId, CreateCaptureChargeRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/capture";
            var headers = this.GetIdempontecyAsHeader(idempotencyKey);

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request, null, headers);
        }

        public BaseResponse<GetChargeResponse> ConfirmChargePayment(string chargeId, CreateConfirmPaymentRequest request = null)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/confirm-payment";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> CreateCharge(CreateChargeRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> RetryCharge(string chargeId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/charges/{chargeId}/retry";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, null);
        }

        public BaseResponse<GetChargeResponse> UpdateChargeCard(string chargeId, UpdateChargeCardRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/credit-card";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> UpdateChargeDueDate(string chargeId, UpdateChargeDueDateRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/due-date";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> UpdateChargeMetadata(string chargeId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/metadata";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }

        public BaseResponse<GetChargeResponse> UpdateChargePaymentMethod(string chargeId, UpdateChargePaymentMethodRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/charges/{chargeId}/payment-method";

            return this.HttpClientUtil.SendRequest<GetChargeResponse>(method, endpoint, request);
        }
    }
}