namespace Mundipagg.Models
{
    public class UpdateSubscriptionPaymentMethodRequest 
    {
        public string PaymentMethod { get; set; }
        public string CardId { get; set; }
        public CreateCardRequest Card { get; set; }
    }
} 