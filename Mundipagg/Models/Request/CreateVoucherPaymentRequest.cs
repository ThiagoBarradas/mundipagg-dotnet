namespace Mundipagg.Models.Request
{
    public class CreateVoucherPaymentRequest
    {
        #region Public Properties

        public CreateCardRequest Card { get; set; }

        public string CardId { get; set; }

        public string CardToken { get; set; }

        public string StatementDescriptor { get; set; }

        #endregion Public Properties
    }
}