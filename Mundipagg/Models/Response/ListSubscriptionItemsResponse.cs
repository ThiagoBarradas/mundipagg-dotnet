using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSubscriptionItemsResponse
    {

        public List<GetSubscriptionItemResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

    }
}