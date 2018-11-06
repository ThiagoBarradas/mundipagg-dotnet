namespace Mundipagg.Models.Request
{
    public class CreateBankTransferPaymentRequest
    {
        #region Public Properties

        public string Bank { get; set; }

        public int Retries { get; set; }

        #endregion Public Properties
    }
}