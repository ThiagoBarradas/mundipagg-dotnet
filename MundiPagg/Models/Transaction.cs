using System;

namespace Mundipagg.Models
{
    /// <summary>
    /// Transaction model
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Transaction code
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        public string TransactionType { get; }

        /// <summary>
        /// Identifier at payment gateway
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Transaction status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether transaction was successfully executed
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Transaction auto retries number (only performed)
        /// </summary>
        public int AttemptCount { get; set; }

        /// <summary>
        /// Next auto retry date
        /// </summary>
        public DateTime? NextAttempt { get; set; }

        /// <summary>
        /// Max auto retry number
        /// </summary>
        public int MaxAttempts { get; set; }

        /// <summary>
        /// Transaction create date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Transaction update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gateway response
        /// </summary>
        public GatewayResponse GatewayResponse { get; set; }

        /// <summary>
        /// Splits
        /// </summary>
        public Split[] Splits { get; set; }
    }
}
