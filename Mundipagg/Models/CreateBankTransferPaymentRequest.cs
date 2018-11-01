namespace Mundipagg.Models
{
    public class CreateBankTransferPaymentRequest
    {
        public string Bank { get; set; }
        public int Retries { get; set; }
    }
} 