using Mundipagg.Models.Enums;
using System;

namespace Mundipagg.Models.Request
{
    /// <summary>
    /// List charges request
    /// </summary>
    public class ListChargesRequest : BaseListRequest
    {
        /// <summary>
        /// Filter by code - Charge code at merchant system
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Filter by create date - Creation after this date
        /// </summary>
        public DateTime? CreatedSince { get; set; }

        /// <summary>
        /// Filter by create date - Creation before this date
        /// </summary>
        public DateTime? CreatedUntil { get; set; }

        /// <summary>
        /// Filter by customer id
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Filter by order id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Filter by payment method type
        /// </summary>
        public PaymentMethodTypeEnum PaymentMethod { get; set; }

        /// <summary>
        /// Filter by status
        /// </summary>
        public ChargeStatusEnum Status { get; set; }
    }
}