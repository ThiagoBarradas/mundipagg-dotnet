using System;

namespace Mundipagg.Models
{
    public class CreateAnticipationRequest
    {
        public int Amount { get; set; }
        public string Timeframe { get; set; }
        public DateTime PaymentDate { get; set; }
    }
} 