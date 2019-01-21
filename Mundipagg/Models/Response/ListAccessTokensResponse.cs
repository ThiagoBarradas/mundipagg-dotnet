using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAccessTokensResponse
    {
        public List<GetAccessTokenResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }
    }
}