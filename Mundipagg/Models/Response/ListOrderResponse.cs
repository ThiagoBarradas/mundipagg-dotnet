using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListOrderResponse
    {
        #region Public Properties

        public List<GetOrderResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}