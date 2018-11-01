namespace Mundipagg.Models
{
    public class CreateCardPaymentTokenRequest 
    {
        public string Type { get; set; }
        public ApplePayRequest ApplePay { get; set; }
    }
} 