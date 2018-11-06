using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListCustomersResponse
    {
        #region Public Properties

        public List<GetCustomerResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}