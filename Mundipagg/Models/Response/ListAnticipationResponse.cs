using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAnticipationResponse
    {
        #region Public Properties

        public List<GetAnticipationResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}