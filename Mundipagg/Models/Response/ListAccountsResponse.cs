using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAccountsResponse
    {
        public List<GetAccountResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}