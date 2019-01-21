namespace Mundipagg.Models.Request
{
    public class CreateVoucherPaymentRequest
    {
        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string CardToken { get; set; }

        public string StatementDescriptor { get; set; }
    }
}