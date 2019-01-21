using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListIncrementsResponse
    {
        public List<GetIncrementResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}