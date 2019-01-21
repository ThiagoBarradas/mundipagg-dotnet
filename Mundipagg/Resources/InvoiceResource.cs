using Mundipagg.Models.Request;
using Mundipagg.Models.Response;
using Mundipagg.Resources.Interface;
using Mundipagg.Utils;
using System.Net.Http;

namespace Mundipagg.Resources
{
    public class InvoiceResource : BaseResource, IInvoiceResource
    {
        public InvoiceResource(Configuration configuration) : base(configuration) { }

        public BaseResponse<GetInvoiceResponse> CancelInvoice(string invoiceId)
        {
            var method = HttpMethod.Delete;
            var endpoint = $"/invoices/{invoiceId}";

            return this.HttpClientUtil.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<GetInvoiceResponse> CreateInvoice(string subscriptionId, string cycleId)
        {
            var method = HttpMethod.Post;
            var endpoint = $"/subscriptions/{subscriptionId}/cycles/{cycleId}/pay";

            return this.HttpClientUtil.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<GetInvoiceResponse> GetInvoice(string invoiceId)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices/{invoiceId}";

            return this.HttpClientUtil.SendRequest<GetInvoiceResponse>(method, endpoint, null);
        }

        public BaseResponse<ListInvoicesResponse> ListInvoices(ListInvoicesRequest request)
        {
            var method = HttpMethod.Get;
            var endpoint = $"/invoices";
            var query = request.ToDictionary();

            return this.HttpClientUtil.SendRequest<ListInvoicesResponse>(method, endpoint, null, query);
        }

        public BaseResponse<GetInvoiceResponse> UpdateInvoiceMetadata(string invoiceId, UpdateMetadataRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/metadata";

            return this.HttpClientUtil.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }

        public BaseResponse<GetInvoiceResponse> UpdateInvoiceStatus(string invoiceId, UpdateInvoiceStatusRequest request)
        {
            var method = new HttpMethod("PATCH");
            var endpoint = $"/invoices/{invoiceId}/status";

            return this.HttpClientUtil.SendRequest<GetInvoiceResponse>(method, endpoint, request);
        }

    }
}