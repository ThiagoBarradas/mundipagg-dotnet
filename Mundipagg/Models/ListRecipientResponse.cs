using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListRecipientResponse  
    {
        public List<GetRecipientResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 