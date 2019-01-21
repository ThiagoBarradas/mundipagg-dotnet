using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSubscriptionsResponse
    {
        public List<GetSubscriptionResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}