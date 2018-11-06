namespace Mundipagg.Models.Request
{
    public class ApplePayHeaderRequest
    {
        #region Public Properties

        public string EphemeralPublicKey { get; set; }

        public string PublicKeyHash { get; set; }

        public string TransactionId { get; set; }

        #endregion Public Properties
    }
}