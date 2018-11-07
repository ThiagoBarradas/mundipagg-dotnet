using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListPlansResponse
    {
        #region Public Properties

        public List<GetPlanResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}