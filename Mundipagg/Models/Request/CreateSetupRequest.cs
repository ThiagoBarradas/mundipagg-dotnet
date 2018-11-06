namespace Mundipagg.Models.Request
{
    public class CreateSetupRequest
    {
        #region Public Properties

        public int Amount { get; set; }

        public string Description { get; set; }

        public CreatePaymentRequest Payment { get; set; }

        #endregion Public Properties
    }
}