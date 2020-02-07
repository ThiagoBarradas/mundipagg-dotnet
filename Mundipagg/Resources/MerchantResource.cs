using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class MerchantResource : BaseResource, IMerchantResource
    {
        public MerchantResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetMerchantResponse> GetMerchant(string merchantId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, null, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse> CreateMerchant(CreateMerchantRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/merchants";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }

        public BaseResponse<GetMerchantResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }
    }
}