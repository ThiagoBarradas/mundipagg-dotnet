using Mundipagg.Models.Enums;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models
{
    /// <summary>
    /// Charge model
    /// </summary>
    public class Charge
    {
        /// <summary>
        /// Charge code
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Code at merchant system
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Identifier at payment gateway
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// Amount in cents
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Amount paid in cents
        /// </summary>
        public int PaidAmount { get; set; }

        /// <summary>
        /// Amount canceled in cents
        /// </summary>
        public int CanceledAmount { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        public CurrencyEnum Currency { get; set; }

        /// <summary>
        /// Charge status
        /// </summary>
        public ChargeStatusEnum Status { get; set; }

        /// <summary>
        /// Due date
        /// </summary>
        public DateTime? DueAt { get; set; }

        /// <summary>
        /// Paid date
        /// </summary>
        public DateTime? PaidAt { get; set; }

        /// <summary>
        /// Canceled date
        /// </summary>
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Payment method type
        /// </summary>
        public PaymentMethodTypeEnum PaymentMethod { get; set; }

        /// <summary>
        /// Charge additional information
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Last transaction
        /// </summary>
        public Transaction LastTransaction { get; set; }

        /// <summary>
        /// Invoice
        /// </summary>
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        //public Order Order { get; set; }

        /// <summary>
        /// Customer
        /// </summary>
        public Customer Customer { get; set; }         
    }
}
