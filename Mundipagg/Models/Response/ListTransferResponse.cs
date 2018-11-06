using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListTransferResponse
    {
        #region Public Properties

        public List<GetTransferResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}