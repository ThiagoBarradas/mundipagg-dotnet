namespace Mundipagg.Models.Request
{
    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateAntifraudSettingsRequest
    {
        public string AccountId { get; set; }
        public bool AutoCancel { get; set; }
        public bool AutoCapture { get; set; }
    }
}
