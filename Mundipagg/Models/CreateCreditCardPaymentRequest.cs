namespace Mundipagg.Models
{
    public class CreateCreditCardPaymentRequest
    {
        public int? Installments { get; set; } = 1;
        public string StatementDescriptor { get; set; }
        public CreateCardRequest Card { get; set; }
        public string CardId { get; set; }
        public string CardToken { get; set; }
        public bool? Recurrence { get; set; }
        public bool? Capture { get; set; } = true;
        public bool? ExtendedLimitEnabled { get; set; }
        public string ExtendedLimitCode { get; set; }
        public long? MerchantCategoryCode { get; set; }
        public CreatePaymentAuthenticationRequest Authentication { get; set; }
        public CreateCardPaymentTokenRequest Token { get; set; }
    }
} 