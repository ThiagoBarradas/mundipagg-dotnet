namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateBankTransferSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Bank { get; set; }

        public string Gateway { get; set; }
    }
}
