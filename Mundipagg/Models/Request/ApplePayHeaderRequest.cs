namespace Mundipagg.Models.Request
{
    public class ApplePayHeaderRequest
    {
        public string EphemeralPublicKey { get; set; }

        public string PublicKeyHash { get; set; }

        public string TransactionId { get; set; }
    }
}