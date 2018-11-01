namespace Mundipagg.Models
{
    public class CreateDebitCardPaymentRequest
    {
        public string StatementDescriptor { get; set; }
        public CreateCardRequest Card { get; set; }
        public string CardId { get; set; }
        public string CardToken { get; set; }
        public bool? Recurrence { get; set; }
        public CreatePaymentAuthenticationRequest Authentication { get; set; }
        public CreateCardPaymentTokenRequest Token { get; set; }
    }
} 