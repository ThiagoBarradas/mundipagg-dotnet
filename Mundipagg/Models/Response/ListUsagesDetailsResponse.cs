using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListUsagesDetailsResponse
    {

        public List<GetUsageResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}