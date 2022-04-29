namespace Mundipagg.Models.Request
{
    public class CreateAuthenticationPOIRequest
    {
        public string AuthenticationMethod { get; set; }

        public string ContentType { get; set; }

        public string DerivationIdentification { get; set; }

        public string EncryptedKey { get; set; }

        public string EncryptedData { get; set; }
    }
}
