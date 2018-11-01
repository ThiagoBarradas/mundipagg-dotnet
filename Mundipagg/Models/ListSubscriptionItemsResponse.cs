using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListSubscriptionItemsResponse  
    {
        public List<GetSubscriptionItemResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 