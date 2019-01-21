namespace Mundipagg.Models.Request
{
    public class CreateTransferSettingsRequest
    {
        public int TransferDay { get; set; }

        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}