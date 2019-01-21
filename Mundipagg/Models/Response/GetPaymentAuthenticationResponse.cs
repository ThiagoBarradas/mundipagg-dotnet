namespace Mundipagg.Models.Response
{
    public class GetPaymentAuthenticationResponse
    {

        public GetThreeDSecureResponse ThreedSecure { get; set; }

        public string Type { get; set; }

    }
}