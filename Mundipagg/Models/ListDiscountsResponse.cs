using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListDiscountsResponse 
    {
        public List<GetDiscountResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 