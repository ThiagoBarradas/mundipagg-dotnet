namespace Mundipagg.Models
{
    public class GetBalanceResponse
    {
        public string Currency { get; set; }
        public int AvailableAmount { get; set; }
        public GetRecipientResponse Recipient { get; set; }
    }
} 