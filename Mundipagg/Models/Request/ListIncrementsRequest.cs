namespace Mundipagg.Models.Request
{
    public class ListIncrementsRequest : BaseListRequest
    {
        #region Public Constructors

        public ListIncrementsRequest(string subscriptionId)
        {
            SubscriptionId = subscriptionId;
        }

        #endregion Public Constructors

        #region Public Properties

        public string SubscriptionId { get; set; }

        #endregion Public Properties
    }
}