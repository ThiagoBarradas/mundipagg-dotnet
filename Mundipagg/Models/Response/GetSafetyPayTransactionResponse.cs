using System;

namespace Mundipagg.Models.Response
{
    public class GetSafetyPayTransactionResponse : GetTransactionResponse
    {
        #region Public Properties

        public string BankTid { get; set; }

        public int? PaidAmount { get; set; }

        public DateTime? PaidAt { get; set; }

        public string Url { get; set; }

        #endregion Public Properties
    }
}