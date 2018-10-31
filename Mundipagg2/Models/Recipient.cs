using Mundipagg.Models.Enums;
using System;
using System.Collections.Generic;

namespace Mundipagg.Models
{
    /// <summary>
    /// Recipient model
    /// </summary>
    public class Recipient
    {
        /// <summary>
        /// Recipient code
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Recipient email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Documento
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Recipient type
        /// </summary>
        public RecipientTypeEnum Type { get; set; }

        /// <summary>
        /// Recipient status
        /// </summary>
        public RecipientStatusEnum Status { get; set; }

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
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Recipient additional information
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Default bank account
        /// </summary>
        public BankAccount DefaultBankAccount { get; set; }

        /// <summary>
        /// Recipient on gateway
        /// </summary>
        public GatewayRecipient[] GatewayRecipients { get; set; }
    }
}
