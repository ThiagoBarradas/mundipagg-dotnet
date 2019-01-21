using System;

namespace Mundipagg.Models.Request
{
    public class ListSubscriptionsRequest : BaseListRequest
    {
        /// <summary>
        /// Filter by billing type
        /// </summary>
        public string BillingType { get; set; }

        /// <summary>
        /// Filter by card id
        /// </summary>
        public string CardId { get; set; }

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
        /// Filter by next billing date - Creation after this date
        /// </summary>
        public DateTime? NextBillingSince { get; set; }

        /// <summary>
        /// Filter by next billing  date - Creation before this date
        /// </summary>
        public DateTime? NextBillingUntil { get; set; }

        /// <summary>
        /// Filter by plan id
        /// </summary>
        public string PlanId { get; set; }

        //TODO: Map subscription status enum
        /// <summary>
        /// Filter by status
        /// </summary>
        public string Status { get; set; }
    }
}