namespace Mundipagg.Models.Request
{
    public class CreateCheckoutDebitCardPaymentRequest
    {
        #region Public Properties

        public CreatePaymentAuthenticationRequest Authentication { get; set; }

        public string StatementDescriptor { get; set; }

        #endregion Public Properties
    }
}