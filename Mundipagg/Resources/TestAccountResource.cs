using System.Net.Http;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;

namespace Mundipagg.Resources
{
    public class TestAccountResource : BaseResource, ITestAccountResource
    {
        public TestAccountResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<ListAccountsResponse> GetAccounts(string masterAccountId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.HttpClientUtil.SendRequest<ListAccountsResponse>(method, endpoint, null, authMode: "amk");
        }

        public BaseResponse<GetAccountResponse> CreateAccount(string masterAccountId, CreateAccountRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/accounts/{masterAccountId}/tests";

            return this.HttpClientUtil.SendRequest<GetAccountResponse>(method, endpoint, request, authMode: "amk");
        }
    }
}