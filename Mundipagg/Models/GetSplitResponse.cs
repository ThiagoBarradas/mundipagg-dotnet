namespace Mundipagg.Models
{
    public class GetSplitResponse 
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public GetRecipientResponse Recipient { get; set; }
        public string GatewayId { get; set; }
    }
} 