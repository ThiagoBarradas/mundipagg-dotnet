using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListRecipientResponse
    {
        #region Public Properties

        public List<GetRecipientResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}