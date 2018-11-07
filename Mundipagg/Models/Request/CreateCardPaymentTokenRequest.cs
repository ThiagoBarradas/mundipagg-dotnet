namespace Mundipagg.Models.Request
{
    public class CreateCardPaymentTokenRequest
    {
        #region Public Properties

        public ApplePayRequest ApplePay { get; set; }

        public string Type { get; set; }

        #endregion Public Properties
    }
}