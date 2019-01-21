namespace Mundipagg.Models.Request
{
    public class ApplePayRequest
    {
        public string Data { get; set; }

        public ApplePayHeaderRequest Header { get; set; }

        public string MerchantIdentifier { get; set; }

        public string Signature { get; set; }

        public string Version { get; set; }
    }
}