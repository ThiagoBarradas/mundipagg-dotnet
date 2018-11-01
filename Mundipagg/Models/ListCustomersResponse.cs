using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListCustomersResponse 
    {
        public List<GetCustomerResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 