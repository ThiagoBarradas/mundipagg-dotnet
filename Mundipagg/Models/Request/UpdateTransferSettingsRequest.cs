namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateTransferSettingsRequest
    {
        public string TransferDay { get; set; }

        public string TransferEnabled { get; set; }

        public string TransferInterval { get; set; }
    }
}