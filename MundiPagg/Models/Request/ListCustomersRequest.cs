namespace MundiPagg.Models.Request
{
    /// <summary>
    /// List customers request
    /// </summary>
    public class ListCustomersRequest : BaseListRequest
    {
        /// <summary>
        /// Filter by customer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Filter by customer email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Filter by customer document
        /// </summary>
        public string Document { get; set; }
    }
}
