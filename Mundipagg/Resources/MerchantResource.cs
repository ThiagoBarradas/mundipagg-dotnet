using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class MerchantResource : BaseResource, IMerchantResource
    {
        public MerchantResource(Configuration configuration) : base(configuration)
        {
        }

        public BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> GetMerchant(string merchantId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, null, authMode: "token");
        }


        public async Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> GetMerchantAsync(string merchantId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/merchants/{merchantId}";

            return await this.SendRequestAsync<GetMerchantResponse>(method, endpoint, null, authMode: "token");
        }


        public BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> CreateMerchant(CreateMerchantRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/merchants";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public async Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> CreateMerchantAsync(CreateMerchantRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/merchants";

            return await this.SendRequestAsync<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchant(string merchantId, UpdateMerchantRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/merchants/{merchantId}";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public async Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantAsync(string merchantId, UpdateMerchantRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/merchants/{merchantId}";

            return await this.SendRequestAsync<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchantStatus(string merchantId, UpdateMerchantStatusRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/status";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public async Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantStatusAsync(string merchantId, UpdateMerchantStatusRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/status";

            return await this.SendRequestAsync<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public BaseResponse<GetMerchantResponse, MundipaggErrorsResponse> UpdateMerchantSettings(string merchantId, UpdateMerchantSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/merchant-settings";

            return this.SendRequest<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }


        public async Task<BaseResponse<GetMerchantResponse, MundipaggErrorsResponse>> UpdateMerchantSettingsAsync(string merchantId, UpdateMerchantSettingsRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/merchants/{merchantId}/merchant-settings";

            return await this.SendRequestAsync<GetMerchantResponse>(method, endpoint, request, authMode: "token");
        }
    }
}