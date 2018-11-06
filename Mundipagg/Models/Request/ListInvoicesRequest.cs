using System;

namespace Mundipagg.Models.Request
{
    public class ListInvoicesRequest : BaseListRequest
    {
        #region Public Properties

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

        //TODO: Map invoice status enum
        /// <summary>
        /// Filter by status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Filter by subscription id
        /// </summary>
        public string SubscriptionId { get; set; }

        #endregion Public Properties
    }
}