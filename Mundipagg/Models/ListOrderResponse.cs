using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListOrderResponse  
    {
        public List<GetOrderResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 