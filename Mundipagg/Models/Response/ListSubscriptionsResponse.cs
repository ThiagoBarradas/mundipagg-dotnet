using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class ListSubscriptionsResponse
    {
        #region Public Properties

        public List<GetSubscriptionResponse> Data { get; set; }

        public PagingResponse Paging { get; set; }

        #endregion Public Properties
    }
}