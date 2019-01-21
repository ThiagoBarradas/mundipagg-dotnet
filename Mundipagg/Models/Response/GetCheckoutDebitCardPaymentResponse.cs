namespace Mundipagg.Models.Response
{
    public class GetCheckoutDebitCardPaymentResponse
    {
        public GetPaymentAuthenticationResponse Authentication { get; set; }

        public string StatementDescriptor { get; set; }
    }
}