using System.Collections.Generic;


namespace Mundipagg.Models
{
    public class CreateCheckoutCreditCardPaymentRequest 
    {
        public string StatementDescriptor { get; set; }
        public List<CreateCheckoutCardInstallmentOptionRequest> Installments { get; set; }
        public CreatePaymentAuthenticationRequest Authentication { get; set; }
    }
} 