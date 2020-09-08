using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class AccountResource : BaseResource, IAccountResource
    {
        public AccountResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> GetAccount(string accountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> ListAccounts()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<PagingResponse<GetAccountResponse>, MundipaggErrorsResponse> GetTestAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateAccount(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request) {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdateMundipaggConfig(string accountId, UpdateMundipaggConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse, MundipaggErrorsResponse> UpdatePagarmeConfig(string accountId, UpdatePagarmeConfigRequest request)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/pagarme-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
    }
}