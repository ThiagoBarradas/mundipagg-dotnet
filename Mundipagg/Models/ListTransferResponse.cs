using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListTransferResponse  
    {
        public List<GetTransferResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 