namespace Mundipagg.Models.Response
{
    public class GetTransferSettingsResponse
    {
        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }

        public int? TransferDay { get; set; }
    }
}
