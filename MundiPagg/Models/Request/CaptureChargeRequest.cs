namespace Mundipagg.Models.Request
{
    /// <summary>
    /// Capture charge request
    /// </summary>
    public class CaptureChargeRequest
    {
        /// <summary>
        /// Amount in cents to capture
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// New code (charge code at merchant system).
        /// Optional.
        /// </summary>
        public string Code { get; set; }
    }
}
