using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListTransactionsResponse
    {
        #region Public Properties

        public List<GetTransactionResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}