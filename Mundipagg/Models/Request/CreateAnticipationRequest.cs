using System;

namespace Mundipagg.Models.Request
{
    public class CreateAnticipationRequest
    {
        public int Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string Timeframe { get; set; }
    }
}