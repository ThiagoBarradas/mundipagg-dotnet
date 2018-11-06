namespace Mundipagg.Models.Request
{
    public class UpdateSubscriptionCardRequest
    {
        #region Public Properties

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        #endregion Public Properties
    }
}