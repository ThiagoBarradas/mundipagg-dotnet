using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class GetCheckoutCreditCardPaymentResponse 
    {
        public string StatementDescriptor { get; set; }
        public List<GetCheckoutCardInstallmentOptionsResponse> Installments { get; set; }
        public GetPaymentAuthenticationResponse Authentication { get; set; }
    }
} 