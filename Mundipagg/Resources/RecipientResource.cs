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

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> CreateRecipient(CreateRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

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

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> UpdateRecipient(string recipientId, UpdateRecipientRequest request)
        {
            var method = HttpMethod.Put;
            var endpoint = $"/recipients/{recipientId}";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> ImportRecipient(CreateImportRecipientRequest request)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/recipients/import";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, request);
        }

        public BaseResponse<GetRecipientResponse, MundipaggErrorsResponse> GetRecipientByCode(string code)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/recipients/code/{code}";

            return this.SendRequest<GetRecipientResponse>(method, endpoint, null);
        }
    }
}