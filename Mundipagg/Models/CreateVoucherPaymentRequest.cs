namespace Mundipagg.Models
{
    public class CreateVoucherPaymentRequest 
    {
        public string StatementDescriptor { get; set; }
        public string CardId { get; set; }
        public string CardToken { get; set; }
        public CreateCardRequest Card { get; set; }
    }
}