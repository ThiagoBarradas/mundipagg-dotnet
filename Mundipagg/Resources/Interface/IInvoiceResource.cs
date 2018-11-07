using Mundipagg.Models.Request;
using Mundipagg.Models.Response;

namespace Mundipagg.Resources.Interface
{
    public interface IInvoiceResource : IResource
    {
        /// <summary>
        /// Cancels an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice id</param>
        /// <return>Returns the BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse> CancelInvoice(string invoiceId);

        /// <summary>
        /// Gets an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <return>Returns the BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse> GetInvoice(string invoiceId);

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="subscriptionId">Required parameter: Subscription Id</param>
        /// <param name="cycleId">Required parameter: Cycle Id</param>
        /// <return>Returns the BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse> CreateInvoice(string subscriptionId, string cycleId);

        /// <summary>
        /// Updates the status from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: Invoice Id</param>
        /// <param name="request">Required parameter: Request for updating an invoice's status</param>
        /// <return>Returns the BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse> UpdateInvoiceStatus(string invoiceId, UpdateInvoiceStatusRequest request);

        /// <summary>
        /// Gets all invoices
        /// </summary>
        /// <return>Returns the ListInvoicesResponse response from the API call</return>
        BaseResponse<ListInvoicesResponse> GetInvoices(ListInvoicesRequest request);

        /// <summary>
        /// Updates the metadata from an invoice
        /// </summary>
        /// <param name="invoiceId">Required parameter: The invoice id</param>
        /// <param name="request">Required parameter: Request for updating the invoice metadata</param>
        /// <return>Returns the BaseResponse<GetInvoiceResponse> response from the API call</return>
        BaseResponse<GetInvoiceResponse> UpdateInvoiceMetadata(string invoiceId, UpdateMetadataRequest request);
    }
}