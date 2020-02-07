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

        public BaseResponse<GetAccountResponse> GetAccount(string accountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<PagingResponse<GetAccountResponse>> ListAccounts()
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts";

            return this.SendRequest<PagingResponse<GetAccountResponse>>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<ListAccountsResponse> GetTestAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<ListAccountsResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> CreateTestAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> UpdateAccount(string accountId, UpdateAccountRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/accounts/{accountId}";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> UpdateStatus(string accountId, UpdateAccountStatusRequest request) {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/status";

            return this.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
        
        public BaseResponse<GetAccountResponse> UpdateMundipaggConfig(string accountId, string merchantKey)
        {
            var method = new HttpMethod("patch");
            var endpoint = $"/accounts/{accountId}/mundipagg-settings";

            return this.SendRequest<GetAccountResponse>(method, endpoint, new { merchantKey }, authMode: "amk");
        }
    }
}