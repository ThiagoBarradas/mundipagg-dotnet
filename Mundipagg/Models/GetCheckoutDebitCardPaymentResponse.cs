namespace Mundipagg.Models
{
    public class GetCheckoutDebitCardPaymentResponse
    {
        public string StatementDescriptor { get; set; }
        public GetPaymentAuthenticationResponse Authentication { get; set; }
    }
} 