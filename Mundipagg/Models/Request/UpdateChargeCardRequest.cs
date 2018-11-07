namespace Mundipagg.Models.Request
{
    public class UpdateChargeCardRequest
    {
        #region Public Properties

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public bool Recurrence { get; set; }

        public bool UpdateSubscription { get; set; }

        #endregion Public Properties
    }
}