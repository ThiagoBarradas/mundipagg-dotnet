using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using RestSharp.Easy.Models;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class RecipientResource : BaseResource, IRecipientResource
    {
        public RecipientResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipient(string recipientId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/{recipientId}";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, null);
        }
    }
}