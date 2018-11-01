namespace Mundipagg.Models
{
    public class ApplePayHeaderRequest
    {
        public string PublicKeyHash { get; set; }
        public string EphemeralPublicKey { get; set; }
        public string TransactionId { get; set; }
    }
} 