namespace Mundipagg.Models.Request
{

    [Newtonsoft.Json.JsonObject(NamingStrategyType = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy))]
    public class UpdateBoletoSettingsRequest
    {
        public bool Enabled { get; set; }

        public string Bank { get; set; }

        public string Instructions { get; set; }

        public string Gateway { get; set; }

        public int? DueDays { get; set; }

        public bool? AllowChargeRecovery { get; set; }
    }
}
