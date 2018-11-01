namespace Mundipagg.Models
{
    public class CreatePaymentAuthenticationRequest
    {
        public string Type { get; set; }
        public CreateThreeDSecureRequest ThreedSecure { get; set; }
    }
} 