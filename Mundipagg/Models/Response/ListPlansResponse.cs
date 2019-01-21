using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListPlansResponse
    {

        public List<GetPlanResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}