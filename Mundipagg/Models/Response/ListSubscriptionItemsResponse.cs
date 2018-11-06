using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSubscriptionItemsResponse
    {
        #region Public Properties

        public List<GetSubscriptionItemResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}