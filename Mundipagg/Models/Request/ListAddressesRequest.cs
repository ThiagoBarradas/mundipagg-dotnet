namespace Mundipagg.Models.Request
{
    public class ListAddressesRequest : BaseListRequest
    {

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="customerId">required</param>
        public ListAddressesRequest(string customerId)
        {
            CustomerId = customerId;
        }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }

    }
}