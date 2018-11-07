namespace Mundipagg.Models.Request
{
    public class CreateTransferSettingsRequest
    {
        #region Public Properties

        public int TransferDay { get; set; }

        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }

        #endregion Public Properties
    }
}