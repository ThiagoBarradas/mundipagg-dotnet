using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSellerResponse
    {
        public List<GetSellerResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}