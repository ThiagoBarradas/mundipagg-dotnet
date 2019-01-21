using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListCardsResponse
    {

        public List<GetCardResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}