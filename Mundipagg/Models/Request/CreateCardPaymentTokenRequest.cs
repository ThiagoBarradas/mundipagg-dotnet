namespace Mundipagg.Models.Request
{
    public class CreateCardPaymentTokenRequest
    {
        public ApplePayRequest ApplePay { get; set; }

        public string Type { get; set; }
    }
}