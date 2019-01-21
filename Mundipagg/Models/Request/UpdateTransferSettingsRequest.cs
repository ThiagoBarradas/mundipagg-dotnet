namespace Mundipagg.Models.Request
{
    public class UpdateTransferSettingsRequest
    {
        public string TransferDay { get; set; }

        public string TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}