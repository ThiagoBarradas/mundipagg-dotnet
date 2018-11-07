using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSellerResponse
    {
        #region Public Properties

        public List<GetSellerResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}