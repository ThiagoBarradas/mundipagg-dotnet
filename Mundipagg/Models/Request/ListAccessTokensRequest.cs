namespace Mundipagg.Models.Request
{
    public class ListAccessTokensRequest : BaseListRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListAccessTokensRequest(string customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }
    }
}