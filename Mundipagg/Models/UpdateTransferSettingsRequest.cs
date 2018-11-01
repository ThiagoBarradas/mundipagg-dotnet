namespace Mundipagg.Models
{
    public class UpdateTransferSettingsRequest
    {
        public string TransferEnabled { get; set; }
        public string TransferInterval { get; set; }
        public string TransferDay { get; set; }
    }
} 