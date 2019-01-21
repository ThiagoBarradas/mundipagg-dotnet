using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListTransferResponse
    {
        public List<GetTransferResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}