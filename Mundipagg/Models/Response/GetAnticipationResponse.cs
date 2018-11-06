using System;

namespace Mundipagg.Models.Response
{
    public class GetAnticipationResponse
    {
        #region Public Properties

        public int ApprovedAmount { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Id { get; set; }

        public DateTime PaymentDate { get; set; }

        public string Pgid { get; set; }

        public GetRecipientResponse Recipient { get; set; }

        public int RequestedAmount { get; set; }

        public string Status { get; set; }

        public string Timeframe { get; set; }

        public DateTime UpdatedAt { get; set; }

        #endregion Public Properties
    }
}