namespace Mundipagg.Models.Request
{
    public class UpdateSubscriptionPaymentMethodRequest
    {
        #region Public Properties

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string PaymentMethod { get; set; }

        #endregion Public Properties
    }
}