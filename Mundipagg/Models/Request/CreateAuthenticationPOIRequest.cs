namespace Mundipagg.Models.Request
{
    public class CreateAuthenticationPOIRequest
    {
        public string AuthenticationMethod { get; set; }

        public string ContentType { get; set; }

        public string Ksn { get; set; }

        public string EncryptedData { get; set; }
    }
}
