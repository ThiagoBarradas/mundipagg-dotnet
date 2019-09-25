using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
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

            return this.HttpClientUtil.SendRequest<GetAccountResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> CreateAccount(CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts";

            return this.HttpClientUtil.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
    }
}