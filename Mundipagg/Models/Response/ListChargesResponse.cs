using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListChargesResponse
    {
        #region Public Properties

        public List<GetChargeResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}