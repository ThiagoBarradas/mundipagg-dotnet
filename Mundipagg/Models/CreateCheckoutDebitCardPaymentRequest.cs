namespace Mundipagg.Models
{
    public class CreateCheckoutDebitCardPaymentRequest 
    {
        public string StatementDescriptor { get; set; }
        public CreatePaymentAuthenticationRequest Authentication { get; set; }
    }
} 