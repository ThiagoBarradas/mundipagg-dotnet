namespace Mundipagg.Models.Request
{
    public class CreateConfirmPaymentRequest
    {
        #region Public Properties

        public int? Amount { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        #endregion Public Properties
    }
}