namespace Mundipagg.Models.Request
{
    public class CreateCheckoutDebitCardPaymentRequest
    {

        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public string StatementDescriptor { get; set; }

    }
}