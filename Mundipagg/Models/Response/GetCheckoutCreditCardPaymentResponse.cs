using System.Collections.Generic;

namespace Mundipagg.Models.Response
{
    public class GetCheckoutCreditCardPaymentResponse
    {
        #region Public Properties

        public GetPaymentAuthenticationResponse Authentication { get; set; }

        public List<GetCheckoutCardInstallmentOptionsResponse> Installments { get; set; }

        public string StatementDescriptor { get; set; }

        #endregion Public Properties
    }
}