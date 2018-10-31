namespace Mundipagg.Models.Request
{
    /// <summary>
    /// Cancel charge request
    /// </summary>
    public class CancelChargeRequest
    {
        /// <summary>
        /// Amount in cents to cancel
        /// </summary>
        public int Amount { get; set; }
    }
}
