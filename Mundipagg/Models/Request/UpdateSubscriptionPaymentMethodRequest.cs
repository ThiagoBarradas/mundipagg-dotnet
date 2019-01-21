namespace Mundipagg.Models.Request
{
    public class UpdateSubscriptionPaymentMethodRequest
    {

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string PaymentMethod { get; set; }

    }
}