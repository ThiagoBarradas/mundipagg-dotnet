using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListUsagesResponse
    {

        public List<GetUsageResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}