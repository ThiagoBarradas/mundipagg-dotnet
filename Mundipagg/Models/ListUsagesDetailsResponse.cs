using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListUsagesDetailsResponse 
    {
        public List<GetUsageResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 