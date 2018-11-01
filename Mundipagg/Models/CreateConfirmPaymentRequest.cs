namespace Mundipagg.Models
{
    public class CreateConfirmPaymentRequest 
    {
        public string Description { get; set; }
        public int? Amount { get; set; }
        public string Code { get; set; }
    }
} 