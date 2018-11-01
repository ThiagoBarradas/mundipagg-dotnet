using System;


namespace Mundipagg.Models
{
    public class GetBankTransferTransactionResponse 
    {
        public string Url { get; set; }
        public string BankTid { get; set; }
        public string Bank { get; set; }
        public DateTime? PaidAt { get; set; }
        public int? PaidAmount { get; set; }
    }
} 