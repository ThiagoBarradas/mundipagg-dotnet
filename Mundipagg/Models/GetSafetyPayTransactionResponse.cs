using System;


namespace Mundipagg.Models
{
    public class GetSafetyPayTransactionResponse : GetTransactionResponse 
    {
        public string Url { get; set; }
        public string BankTid { get; set; }
        public DateTime? PaidAt { get; set; }
        public int? PaidAmount { get; set; }
    }
} 