using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListAddressesResponse
    {
        #region Public Properties

        public List<GetAddressResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}