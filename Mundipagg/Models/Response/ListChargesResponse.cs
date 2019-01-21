using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListChargesResponse
    {

        public List<GetChargeResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}