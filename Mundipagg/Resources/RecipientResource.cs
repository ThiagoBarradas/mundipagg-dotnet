using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
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

        public BaseResponse<PagingResponse<GetRecipientResponse>, MundipaggErrorsResponse> ListRecipients(ListRecipientsRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetRecipientResponse>>(method, endpoint, null, query);
        }
    }
}