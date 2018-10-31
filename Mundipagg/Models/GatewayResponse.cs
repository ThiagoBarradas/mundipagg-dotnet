namespace Mundipagg.Models
{
    /// <summary>
    /// Gateway response model
    /// </summary>
    public class GatewayResponse
    {
        /// <summary>
        /// Status code returned by gateway
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gateway errors
        /// </summary>
        public GatewayError[] Errors { get; set; }
    }
}
