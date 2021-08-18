using Mundipagg.Models.Commons;
using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using RestSharp.Easy.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mundipagg.Resources
{
    public class InvoiceResource : BaseResource, IInvoiceResource
    {
        public InvoiceResource(Configuration configuration) : base(configuration) { }


        public BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse> CancelInvoice(string invoiceId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/invoices/{invoiceId}";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse>> CancelInvoiceAsync(string invoiceId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/invoices/{invoiceId}";

            return await this.SendRequestAsync<GetInvoiceResponse>(method, endpoint, null);
        }


        public BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse> CreateInvoice(string subscriptionId, string cycleId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/cycles/{cycleId}/pay";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse>> CreateInvoiceAsync(string subscriptionId, string cycleId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/cycles/{cycleId}/pay";

            return await this.SendRequestAsync<GetInvoiceResponse>(method, endpoint, null);
        }


        public BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse> GetInvoice(string invoiceId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices/{invoiceId}";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }


        public async Task<BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse>> GetInvoiceAsync(string invoiceId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices/{invoiceId}";

            return await this.SendRequestAsync<GetInvoiceResponse>(method, endpoint, null);
        }


        public BaseResponse<PagingResponse<GetInvoiceResponse>, MundipaggErrorsResponse> ListInvoices(ListInvoicesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices";
            var query = request.ToDictionary();

            return this.SendRequest<PagingResponse<GetInvoiceResponse>>(method, endpoint, null, query);
        }


        public async Task<BaseResponse<PagingResponse<GetInvoiceResponse>, MundipaggErrorsResponse>> ListInvoicesAsync(ListInvoicesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices";
            var query = request.ToDictionary();

            return await this.SendRequestAsync<PagingResponse<GetInvoiceResponse>>(method, endpoint, null, query);
        }


        public BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse> UpdateInvoiceMetadata(string invoiceId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/metadata";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse>> UpdateInvoiceMetadataAsync(string invoiceId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/metadata";

            return await this.SendRequestAsync<GetInvoiceResponse>(method, endpoint, request);
        }


        public BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse> UpdateInvoiceStatus(string invoiceId, UpdateInvoiceStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/status";

            return this.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }


        public async Task<BaseResponse<GetInvoiceResponse, MundipaggErrorsResponse>> UpdateInvoiceStatusAsync(string invoiceId, UpdateInvoiceStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/status";

            return await this.SendRequestAsync<GetInvoiceResponse>(method, endpoint, request);
        }
    }
}