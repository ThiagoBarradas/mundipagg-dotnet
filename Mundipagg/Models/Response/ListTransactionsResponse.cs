using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListTransactionsResponse
    {
        public List<GetTransactionResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}