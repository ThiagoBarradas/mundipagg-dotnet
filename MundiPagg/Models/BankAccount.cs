using MundiPagg.Models.Enums;
using System;
using System.Collections.Generic;

namespace MundiPagg.Models
{
    public class BankAccount
    {
        /// <summary>
        /// Bank account code
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Holder name
        /// </summary>
        public string HolderName { get; set; }

        /// <summary>
        /// Holder type
        /// </summary>
        public BankAccountHolderTypeEnum HolderType { get; set; }

        /// <summary>
        /// Holder document
        /// </summary>
        public string HolderDocument { get; set; }

        /// <summary>
        /// Bank number
        /// </summary>
        public string Bank { get; set; }

        /// <summary>
        /// Agency
        /// </summary>
        public string BranchNumber { get; set; }

        /// <summary>
        /// Agency digit
        /// </summary>
        public string BranchCheckDigit { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account digit
        /// </summary>
        public string AccountCheckDigit { get; set; }

        /// <summary>
        /// Bank account type
        /// </summary>
        public BankAccountTypeEnum Type { get; set; }

        /// <summary>
        /// Bank account status
        /// </summary>
        public BankAccountStatusEnum Status { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Delete date
        /// </summary>
        public DateTime? Deleted_At { get; set; }

        /// <summary>
        /// Bank account additional information
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Recipient
        /// </summary>
        public Recipient Recipient { get; set; }
    }
}
