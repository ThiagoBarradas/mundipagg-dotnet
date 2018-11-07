using System.Collections.Generic;

namespace Mundipagg.Models.Request
{
    public class CreateCheckoutCreditCardPaymentRequest
    {
        #region Public Properties

        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public List<CreateCheckoutCardInstallmentOptionRequest> Installments { get; set; }

        public string StatementDescriptor { get; set; }

        #endregion Public Properties
    }
}