using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListInvoicesResponse
    {

        public List<GetInvoiceResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}