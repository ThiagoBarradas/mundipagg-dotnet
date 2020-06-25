namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class CreateTransferSettingsRequest
    {
        public int TransferDay { get; set; }

        public bool TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}