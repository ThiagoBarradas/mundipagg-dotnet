namespace Mundipagg.Models.Response
{
    public class GetCheckoutDebitCardPaymentResponse
    {
        #region Public Properties

        public GetPaymentAuthenticationResponse Authentication { get; set; }

        public string StatementDescriptor { get; set; }

        #endregion Public Properties
    }
}