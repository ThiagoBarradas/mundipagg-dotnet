namespace Mundipagg.Models.Request
{
    public class UpdateTransferSettingsRequest
    {
        #region Public Properties

        public string TransferDay { get; set; }

        public string TransferEnabled { get; set; }

        public string TransferInterval { get; set; }

        #endregion Public Properties
    }
}