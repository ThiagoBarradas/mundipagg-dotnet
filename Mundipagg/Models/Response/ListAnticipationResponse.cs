using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAnticipationResponse
    {

        public List<GetAnticipationResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}