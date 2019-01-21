using System;

namespace Mundipagg.Models.Response
{
    public class GetBankTransferTransactionResponse : GetTransactionResponse
    {
        public string Bank { get; set; }

        public string BankTid { get; set; }

        public int? PaidAmount { get; set; }

        public DateTime? PaidAt { get; set; }

        public string Url { get; set; }
    }
}