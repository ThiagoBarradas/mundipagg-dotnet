using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListInvoicesResponse
    {
        #region Public Properties

        public List<GetInvoiceResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}