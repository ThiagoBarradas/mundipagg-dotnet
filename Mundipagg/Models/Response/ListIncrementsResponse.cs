using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListIncrementsResponse
    {
        #region Public Properties

        public List<GetIncrementResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}