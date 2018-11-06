using System;
using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetTransferResponse
    {
        public string Id { get; set; }

        public int Amount { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public GetBankAccountResponse BankAccount { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}