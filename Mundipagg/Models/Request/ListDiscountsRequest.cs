namespace Mundipagg.Models.Request
{
    public class ListDiscountsRequest : BaseListRequest
    {
        #region Public Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="subscriptionId">required</param>
        public ListDiscountsRequest(string subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
        }

        #endregion Public Constructors

        #region Public Properties

        public string SubscriptionId { get; set; }

        #endregion Public Properties
    }
}