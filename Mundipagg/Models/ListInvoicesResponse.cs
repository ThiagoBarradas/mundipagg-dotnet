using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListInvoicesResponse  
    {
        public List<GetInvoiceResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 