using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetBankAccountResponse
    {
        #region Public Properties

        public string AccountCheckDigit { get; set; }

        public string AccountNumber { get; set; }

        public string Bank { get; set; }

        public string BranchCheckDigit { get; set; }

        public string BranchNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public string HolderName { get; set; }

        public string HolderType { get; set; }

        public string Id { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public DateTime UpdatedAt { get; set; }

        #endregion Public Properties
    }
}