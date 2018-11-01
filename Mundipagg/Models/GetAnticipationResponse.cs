using System;


namespace Mundipagg.Models
{
    public class GetAnticipationResponse  
    {
        public string Id { get; set; }
        public int RequestedAmount { get; set; }
        public int ApprovedAmount { get; set; }
        public GetRecipientResponse Recipient { get; set; }
        public string Pgid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        public string Timeframe { get; set; }
    }
} 