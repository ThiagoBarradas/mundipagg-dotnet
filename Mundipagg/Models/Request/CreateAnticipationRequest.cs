using System;

namespace Mundipagg.Models.Request
{
    public class CreateAnticipationRequest
    {
        #region Public Properties

        public int Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string Timeframe { get; set; }

        #endregion Public Properties
    }
}