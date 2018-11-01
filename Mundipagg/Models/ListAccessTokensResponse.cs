using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class ListAccessTokensResponse 
    {
        public List<GetAccessTokenResponse> Data { get; set; }
        public PagingResponse Paging { get; set; }
    }
} 