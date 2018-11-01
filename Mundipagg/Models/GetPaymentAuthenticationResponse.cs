namespace Mundipagg.Models
{
    public class GetPaymentAuthenticationResponse 
    {
        public string Type { get; set; }
        public GetThreeDSecureResponse ThreedSecure { get; set; }
    }
} 