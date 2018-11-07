using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListCardsResponse
    {
        #region Public Properties

        public List<GetCardResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}