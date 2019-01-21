namespace Mundipagg.Models.Request
{
    public class CreateBankTransferPaymentRequest
    {
        public string Bank { get; set; }

        public int Retries { get; set; }
    }
}