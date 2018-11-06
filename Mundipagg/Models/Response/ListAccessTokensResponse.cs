using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAccessTokensResponse
    {
        #region Public Properties

        public List<GetAccessTokenResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}