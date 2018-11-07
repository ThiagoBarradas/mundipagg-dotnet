using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListUsagesDetailsResponse
    {
        #region Public Properties

        public List<GetUsageResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}