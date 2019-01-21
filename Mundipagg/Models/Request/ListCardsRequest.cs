namespace Mundipagg.Models.Request
{
    public class ListCardsRequest : BaseListRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListCardsRequest(string customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }
    }
}