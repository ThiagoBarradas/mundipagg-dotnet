namespace Mundipagg.Models.Request
{
    public class ApplePayRequest
    {
        #region Public Properties

        public string Data { get; set; }

        public ApplePayHeaderRequest Header { get; set; }

        public string MerchantIdentifier { get; set; }

        public string Signature { get; set; }

        public string Version { get; set; }

        #endregion Public Properties
    }
}