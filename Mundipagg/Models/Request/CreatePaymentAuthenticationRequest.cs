namespace Mundipagg.Models.Request
{
    public class CreatePaymentAuthenticationRequest
    {
        #region Public Properties

        public CreateThreeDSecureRequest ThreedSecure { get; set; }

        public string Type { get; set; }

        #endregion Public Properties
    }
}