using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListRecipientResponse
    {

        public List<GetRecipientResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}