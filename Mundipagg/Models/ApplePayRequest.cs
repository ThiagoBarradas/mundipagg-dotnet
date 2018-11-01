namespace Mundipagg.Models
{
    public class ApplePayRequest 
    {
        public string Version { get; set; }
        public string Data { get; set; }
        public ApplePayHeaderRequest Header { get; set; }
        public string Signature { get; set; }
        public string MerchantIdentifier { get; set; }
    }
} 