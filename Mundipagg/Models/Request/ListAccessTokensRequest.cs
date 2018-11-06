namespace Mundipagg.Models.Request
{
    public class ListAccessTokensRequest : BaseListRequest
    {
        #region Public Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListAccessTokensRequest(string customerId)
        {
            CustomerId = customerId;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }

        #endregion Public Properties
    }
}