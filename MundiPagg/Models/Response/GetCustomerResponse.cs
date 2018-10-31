using System;

namespace Mundipagg.Models.Response
{
    /// <summary>
    /// Get customer response
    /// </summary>
    public class GetCustomerResponse : Customer
    {
        /// <summary>
        /// Customer code
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the customer is delinquent
        /// </summary>
        public bool Delinquent { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
