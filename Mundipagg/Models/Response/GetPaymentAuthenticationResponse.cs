namespace Mundipagg.Models.Response
{
    public class GetPaymentAuthenticationResponse
    {
        #region Public Properties

        public GetThreeDSecureResponse ThreedSecure { get; set; }

        public string Type { get; set; }

        #endregion Public Properties
    }
}