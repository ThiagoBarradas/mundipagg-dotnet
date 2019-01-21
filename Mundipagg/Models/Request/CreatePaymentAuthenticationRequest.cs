namespace Mundipagg.Models.Request
{
    public class CreatePaymentAuthenticationRequest
    {

        public CreateThreeDSecureRequest ThreedSecure { get; set; }

        public string Type { get; set; }

    }
}